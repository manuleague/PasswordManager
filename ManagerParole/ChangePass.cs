/**************************************************************************
 *                                                                        *
 *  File:        ChangePass.cs                                            *
 *  Copyright:   (c) 2025, Manager Parole                                 *
 *  E-mail:      moscalu.sebi@gmail.com                                   *
 *  Website:     https://github.com/Moscalu-Sebastian                    *
 *  Description: This Windows Forms class provides a UI for setting or    *
 *               changing the master password used to encrypt/decrypt     *
 *               stored password data in the application                  *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using ManagerParole.Data;
using Microsoft.Win32;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ManagerParole
{
    public partial class ChangePass : Form
    {
        private readonly string _oldPassword;

        // Property to expose the newly created or changed password
        public string CreatedPassword { get; private set; }

        // First-time setup constructor
        public ChangePass() : this(null)
        {
            MessageBox.Show(
                "Vă rugăm să vă creați un master password.",
                "Primul Pas",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // Constructor for changing existing password
        public ChangePass(string oldPassword)
        {
            InitializeComponent();
            _oldPassword = oldPassword;
            this.Text = oldPassword == null
                ? "Set Master Password"
                : "Change Master Password";
        }

        private void buttonChangePass_Click(object sender, EventArgs e)
        {
            string newPass = textBoxNewKey.Text.Trim();
            string confirm = textBoxConfirm.Text.Trim();

            if (newPass != confirm)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            try
            {
                // 1) Migrate sys.dat if this isn't first-time
                if (_oldPassword != null)
                    MigratePasswordStore(_oldPassword, newPass);

                // 2) Encrypt and store the secret marker in registry
                string encryptedSecret = Hasher.Encrypt("MySecretData", newPass);
                using var key = Registry.CurrentUser.CreateSubKey("Names");
                key.SetValue("UserCP", encryptedSecret, RegistryValueKind.String);

                // 3) Set the CreatedPassword property for consumption by Program.cs
                CreatedPassword = newPass;

                MessageBox.Show("Password changed successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void MigratePasswordStore(string oldKey, string newKey)
        {
            string xmlPath = Path.Combine(Environment.CurrentDirectory, "sys.dat");
            if (!File.Exists(xmlPath)) return;

            var ds = new DataSet();
            ds.ReadXml(xmlPath);
            DataTable table = ds.Tables["Passwords"]
                            ?? throw new Exception("No 'Passwords' table in sys.dat");

            using (var repository = new PasswordRepository())
            {
                foreach (DataRow row in table.Rows)
                {
                    // Retrieve stored ciphertext
                    object stored = row["encryptedPassword"];
                    byte[] encryptedBytes;

                    if (stored is byte[] bytes)
                    {
                        encryptedBytes = bytes;
                    }
                    else if (stored is string base64)
                    {
                        encryptedBytes = Convert.FromBase64String(base64);
                    }
                    else
                    {
                        throw new InvalidOperationException(
                            $"Unexpected type in sys.dat: {stored?.GetType().Name}"
                        );
                    }

                    // Decrypt with old master password
                    string oldBase64 = Convert.ToBase64String(encryptedBytes);
                    string plain = Hasher.Decrypt(oldBase64, oldKey);

                    // Re-encrypt with new master password
                    string newBase64 = Hasher.Encrypt(plain, newKey);

                    // Add to SQLite database
                    repository.Add(new PasswordEntry
                    {
                        Url = row.Field<string>("url"),
                        UserId = row.Field<string>("userid"),
                        EncryptedPassword = newBase64,
                        Remarks = row.Field<string>("remarks")
                    });
                }
            }

            // Backup original file
            File.Move(xmlPath, xmlPath + ".backup");
        }
        private void ChangePass_Load(object sender, EventArgs e)
        {

        }
    }
}
