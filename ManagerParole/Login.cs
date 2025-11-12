/**************************************************************************
 *                                                                        *
 *  File:        Login.cs                                                 *
 *  Copyright:   (c) 2025, Manager Parole                                 *
 *  E-mail:      moscalu.sebi@gmail.com                                   *
 *  Website:     https://github.com/Moscalu-Sebastian                     *
 *  Description: This Windows Forms class implements the login            *
 *               functionality for the password manager application.      *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ManagerParole
{
    public partial class Login : Form
    {
        public string EnteredPassword { get; private set; }

        public Login()
        {
            InitializeComponent();
        }

        private void textBoxLoginPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; 
                AttemptLogin();
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            AttemptLogin();

        }
        private void AttemptLogin()
        {
            string encryptedSecret = GetStoredEncryptedValue();

            if (string.IsNullOrEmpty(encryptedSecret))
            {
                using (ChangePass cp = new ChangePass())
                {
                    if (cp.ShowDialog() == DialogResult.OK)
                    {
                        AttemptLogin();
                    }
                }
                return;
            }

            string passwordAttempt = textBoxLoginPassword.Text.Trim();

            try
            {
                string decrypted = Hasher.Decrypt(encryptedSecret, passwordAttempt);

                if (decrypted == "MySecretData")
                {
                    EnteredPassword = passwordAttempt;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid password");
                }
            }
            catch
            {
                MessageBox.Show("Invalid password or corrupted data");
            }
        }

        private string GetStoredEncryptedValue()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("Names"))
            {
                return key?.GetValue("UserCP")?.ToString() ?? "";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
