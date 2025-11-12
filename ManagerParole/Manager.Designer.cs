/**************************************************************************
 *                                                                        *
 *  File:        Manager.Designer.cs                                      *
 *  Copyright:   (c) 2025, Manager Parole                                 *
 *  E-mail:      sabin.balauca@gmail.com                                  *
 *  Website:     https://github.com/Sabin10b                              *
 *  Description: This class defines the main form of the ManagerParole    *
 *               application, responsible for managing the encrypted      *
 *               storage of user credentials such as URLs, usernames,     *
 *               and passwords.                                           *
 *                                                                        *
 *                                                                        *
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

namespace ManagerParole
    {
        partial class Manager
        {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.labelURL = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.dataGridViewTabel = new System.Windows.Forms.DataGridView();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Copy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRemarks = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxManager = new System.Windows.Forms.GroupBox();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabel)).BeginInit();
            this.groupBoxManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(7, 74);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(46, 20);
            this.labelURL.TabIndex = 0;
            this.labelURL.Text = "URL:";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(101, 68);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(462, 26);
            this.textBoxURL.TabIndex = 1;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(7, 103);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(87, 20);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(101, 103);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(196, 26);
            this.textBoxUsername.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(303, 106);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(82, 20);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(391, 105);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(172, 26);
            this.textBoxPassword.TabIndex = 5;
            // 
            // dataGridViewTabel
            // 
            this.dataGridViewTabel.AllowUserToAddRows = false;
            this.dataGridViewTabel.AllowUserToDeleteRows = false;
            this.dataGridViewTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.URL,
            this.UserID,
            this.Copy,
            this.Delete,
            this.Pass,
            this.Remarks});
            this.dataGridViewTabel.Location = new System.Drawing.Point(11, 137);
            this.dataGridViewTabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewTabel.Name = "dataGridViewTabel";
            this.dataGridViewTabel.ReadOnly = true;
            this.dataGridViewTabel.RowHeadersWidth = 62;
            this.dataGridViewTabel.Size = new System.Drawing.Size(939, 469);
            this.dataGridViewTabel.TabIndex = 7;
            this.dataGridViewTabel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTabel_CellContentClick);
            this.dataGridViewTabel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxURL_KeyDown);
            // 
            // URL
            // 
            this.URL.DataPropertyName = "url";
            this.URL.FillWeight = 150F;
            this.URL.HeaderText = "URL";
            this.URL.MinimumWidth = 8;
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            this.URL.Width = 150;
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "userid";
            this.UserID.HeaderText = "UserID";
            this.UserID.MinimumWidth = 8;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Width = 150;
            // 
            // Copy
            // 
            this.Copy.DataPropertyName = "password";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            this.Copy.DefaultCellStyle = dataGridViewCellStyle1;
            this.Copy.HeaderText = "Password";
            this.Copy.MinimumWidth = 8;
            this.Copy.Name = "Copy";
            this.Copy.ReadOnly = true;
            this.Copy.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Copy.Text = "Copy";
            this.Copy.UseColumnTextForButtonValue = true;
            this.Copy.Width = 150;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "delete";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.FillWeight = 50F;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Text = "X";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 50;
            // 
            // Pass
            // 
            this.Pass.DataPropertyName = "encryptedPassword";
            this.Pass.HeaderText = "Pass";
            this.Pass.MinimumWidth = 8;
            this.Pass.Name = "Pass";
            this.Pass.ReadOnly = true;
            this.Pass.Visible = false;
            this.Pass.Width = 150;
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.FillWeight = 200F;
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.MinimumWidth = 8;
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            this.Remarks.Width = 200;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Generate Password:";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonGenerate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonGenerate.Location = new System.Drawing.Point(728, 96);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(119, 39);
            this.buttonGenerate.TabIndex = 16;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Remarks:";
            // 
            // textBoxRemarks
            // 
            this.textBoxRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRemarks.Location = new System.Drawing.Point(645, 68);
            this.textBoxRemarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRemarks.Name = "textBoxRemarks";
            this.textBoxRemarks.Size = new System.Drawing.Size(202, 26);
            this.textBoxRemarks.TabIndex = 18;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAdd.Location = new System.Drawing.Point(855, 68);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(95, 67);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBoxManager
            // 
            this.groupBoxManager.Controls.Add(this.buttonUndo);
            this.groupBoxManager.Controls.Add(this.buttonHelp);
            this.groupBoxManager.Controls.Add(this.buttonAdd);
            this.groupBoxManager.Controls.Add(this.textBoxRemarks);
            this.groupBoxManager.Controls.Add(this.label4);
            this.groupBoxManager.Controls.Add(this.buttonGenerate);
            this.groupBoxManager.Controls.Add(this.label5);
            this.groupBoxManager.Controls.Add(this.dataGridViewTabel);
            this.groupBoxManager.Controls.Add(this.textBoxPassword);
            this.groupBoxManager.Controls.Add(this.labelPassword);
            this.groupBoxManager.Controls.Add(this.textBoxUsername);
            this.groupBoxManager.Controls.Add(this.labelUsername);
            this.groupBoxManager.Controls.Add(this.textBoxURL);
            this.groupBoxManager.Controls.Add(this.labelURL);
            this.groupBoxManager.Location = new System.Drawing.Point(7, 2);
            this.groupBoxManager.Name = "groupBoxManager";
            this.groupBoxManager.Size = new System.Drawing.Size(957, 614);
            this.groupBoxManager.TabIndex = 1;
            this.groupBoxManager.TabStop = false;
            // 
            // buttonUndo
            // 
            this.buttonUndo.Location = new System.Drawing.Point(872, 10);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(75, 32);
            this.buttonUndo.TabIndex = 21;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(8, 14);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(83, 32);
            this.buttonHelp.TabIndex = 20;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(966, 628);
            this.Controls.Add(this.groupBoxManager);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manager";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manager_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Manager_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabel)).EndInit();
            this.groupBoxManager.ResumeLayout(false);
            this.groupBoxManager.PerformLayout();
            this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.Label labelURL;
            private System.Windows.Forms.TextBox textBoxURL;
            private System.Windows.Forms.Label labelUsername;
            private System.Windows.Forms.TextBox textBoxUsername;
            private System.Windows.Forms.Label labelPassword;
            private System.Windows.Forms.TextBox textBoxPassword;
            private System.Windows.Forms.DataGridView dataGridViewTabel;
            private System.Windows.Forms.Label label5;
            private System.Windows.Forms.Button buttonGenerate;
            private System.Windows.Forms.Label label4;
            private System.Windows.Forms.TextBox textBoxRemarks;
            private System.Windows.Forms.Button buttonAdd;
            private System.Windows.Forms.GroupBox groupBoxManager;
            private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewButtonColumn Copy;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
    }
    }

