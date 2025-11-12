namespace ManagerParole
{
    partial class ChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePass));
            this.buttonChangePass = new System.Windows.Forms.Button();
            this.textBoxConfirm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonChangePass
            // 
            this.buttonChangePass.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonChangePass.Location = new System.Drawing.Point(214, 72);
            this.buttonChangePass.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChangePass.Name = "buttonChangePass";
            this.buttonChangePass.Size = new System.Drawing.Size(115, 32);
            this.buttonChangePass.TabIndex = 9;
            this.buttonChangePass.Text = "Change Password";
            this.buttonChangePass.UseVisualStyleBackColor = false;
            this.buttonChangePass.Click += new System.EventHandler(this.buttonChangePass_Click);
            // 
            // textBoxConfirm
            // 
            this.textBoxConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConfirm.Location = new System.Drawing.Point(153, 42);
            this.textBoxConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConfirm.Name = "textBoxConfirm";
            this.textBoxConfirm.Size = new System.Drawing.Size(176, 22);
            this.textBoxConfirm.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Confirm";
            // 
            // textBoxNewKey
            // 
            this.textBoxNewKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNewKey.Location = new System.Drawing.Point(153, 13);
            this.textBoxNewKey.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewKey.Name = "textBoxNewKey";
            this.textBoxNewKey.Size = new System.Drawing.Size(176, 22);
            this.textBoxNewKey.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "New Key";
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(353, 107);
            this.Controls.Add(this.buttonChangePass);
            this.Controls.Add(this.textBoxConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNewKey);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePass";
            this.Load += new System.EventHandler(this.ChangePass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChangePass;
        private System.Windows.Forms.TextBox textBoxConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewKey;
        private System.Windows.Forms.Label label1;
    }
}