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

using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace ManagerParole
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var registryKey = Registry.CurrentUser.OpenSubKey("Names");
            string stored = registryKey?.GetValue("UserCP") as string;

            if (string.IsNullOrEmpty(stored))
            {
                MessageBox.Show("Set a master password with which you will access the application in the future", "First Step");

                using (var cp = new ChangePass(null))
                {
                    if (cp.ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new Manager(cp.CreatedPassword));
                    }
                    else
                    {
                        MessageBox.Show("Setup canceled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                using (var loginForm = new Login())
                {
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new Manager(loginForm.EnteredPassword));
                    }
                    else
                    {
                        MessageBox.Show("Login failed or canceled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
