/**************************************************************************
 *                                                                        *
 *  File:        Manager.cs                                               *
 *  Copyright:   (c) 2025, Manager Parole                                 *
 *  E-mail:      sabin.balauca@gmail.com                                  *
 *  Website:     https://github.com/Sabin10b                              *
 *  Description: This class defines the main form of the ManagerParole    *
 *               application, responsible for managing the encrypted      *
 *               storage of user credentials such as URLs, usernames,     *
 *               and passwords.                                           *
 *                                                                        *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ManagerParole.Data;

namespace ManagerParole
{
    public partial class Manager : Form
    {
        private readonly string _masterPassword;
        private readonly PasswordRepository _repository;
        private readonly Stack<ICommand> _commandHistory;

        public Manager(string masterPassword)
        {
            InitializeComponent();

            _masterPassword = masterPassword;
            _repository = new PasswordRepository();
            _repository.PasswordStoreChanged += Repository_PasswordStoreChanged;

            _commandHistory = new Stack<ICommand>();


            LoadAll();
        }

        private void LoadAll()
        {
            try
            {
                var list = _repository.GetAll().ToList();

                dataGridViewTabel.DataSource = null;
                dataGridViewTabel.DataSource = list;

                var columnsToHide = new[] { "Id", "EncryptedPassword" };
                foreach (var colName in columnsToHide)
                {
                    if (dataGridViewTabel.Columns.Contains(colName))
                        dataGridViewTabel.Columns[colName].Visible = false;
                }

                dataGridViewTabel.Columns["Url"].DisplayIndex = 0;
                dataGridViewTabel.Columns["UserId"].DisplayIndex = 1;
                dataGridViewTabel.Columns["Copy"].DisplayIndex = 2;
                dataGridViewTabel.Columns["Delete"].DisplayIndex = 3;
                dataGridViewTabel.Columns["Remarks"].DisplayIndex = 4;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void Repository_PasswordStoreChanged(object sender, PasswordEvents e)
        {
            LoadAll();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxURL.Text) ||
                string.IsNullOrWhiteSpace(textBoxUsername.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("URL, UserID and Password are required!",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var entry = new PasswordEntry
            {
                Url = textBoxURL.Text.Trim(),
                UserId = textBoxUsername.Text.Trim(),
                EncryptedPassword = Hasher.Encrypt(textBoxPassword.Text.Trim(), _masterPassword),
                Remarks = textBoxRemarks.Text.Trim()
            };

            var cmd = new AddPasswordCommand(_repository, entry);
            cmd.Execute();
            _commandHistory.Push(cmd);

            textBoxURL.Clear();
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxRemarks.Clear();
            textBoxURL.Focus();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            textBoxPassword.Text = GenerateRandomPassword(12);
        }

        private void dataGridViewTabel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var colName = dataGridViewTabel.Columns[e.ColumnIndex].Name;
            var row = dataGridViewTabel.Rows[e.RowIndex];
            var entry = row.DataBoundItem as PasswordEntry;

            if (entry == null) return;

            if (colName == "Copy")
            {
                var decrypted = Hasher.Decrypt(entry.EncryptedPassword, _masterPassword);
                Clipboard.SetText(decrypted);
                MessageBox.Show("Parola a fost copiată în clipboard!", "Copy",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (colName == "Delete") 
            {
                if (MessageBox.Show("Ștergi această intrare?", "Confirmare",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    var cmd = new RemovePasswordCommand(_repository, entry);
                    cmd.Execute();
                    _commandHistory.Push(cmd);
                }
            }
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            if (_commandHistory.Count > 0)
            {
                var last = _commandHistory.Pop();
                last.Undo();
                MessageBox.Show("The last action has been undone.", "Undo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There are no actions to undo.", "Undo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Manager_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                using (var dlg = new ChangePass(_masterPassword))
                    if (dlg.ShowDialog() == DialogResult.OK)
                        LoadAll();
            }
        }

        private void textBoxURL_KeyDown(object sender, KeyEventArgs e)
        {
            Manager_KeyDown(sender, e);
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private string GenerateRandomPassword(int length)
        {
            var lower = "abcdefghijklmnopqrstuvwxyz";
            var upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var nums = "0123456789";
            var syms = "!@#$%^&*()";
            var all = lower + upper + nums + syms;
            var rnd = new Random();

            var pw = new List<char>
            {
                lower[rnd.Next(lower.Length)],
                upper[rnd.Next(upper.Length)],
                nums[rnd.Next(nums.Length)],
                syms[rnd.Next(syms.Length)]
            };

            for (int i = 4; i < length; i++)
                pw.Add(all[rnd.Next(all.Length)]);

             
            return new string(pw.OrderBy(c => rnd.Next()).ToArray());
        }
       
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            try
            {
                string helpFilePath = System.IO.Path.Combine(Application.StartupPath, "Help - Manager Parole.chm");

                if (System.IO.File.Exists(helpFilePath))
                {
                    Help.ShowHelp(this, helpFilePath);
                }
                else
                {
                    MessageBox.Show("Fișierul de ajutor nu a fost găsit:\n" + helpFilePath,
                                    "Eroare Ajutor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare la deschiderea fișierului de ajutor:\n" + ex.Message,
                                "Eroare Ajutor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
