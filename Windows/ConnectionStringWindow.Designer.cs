
namespace SebContactsApp
{
    partial class ConnectionStringWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtDbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServerPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCredSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name:";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(142, 25);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(196, 22);
            this.txtServerName.TabIndex = 1;
            // 
            // txtDbName
            // 
            this.txtDbName.Location = new System.Drawing.Point(142, 60);
            this.txtDbName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(196, 22);
            this.txtDbName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database Name: ";
            // 
            // txtServerLogin
            // 
            this.txtServerLogin.Location = new System.Drawing.Point(142, 95);
            this.txtServerLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtServerLogin.Name = "txtServerLogin";
            this.txtServerLogin.Size = new System.Drawing.Size(196, 22);
            this.txtServerLogin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Server Login:";
            // 
            // txtServerPass
            // 
            this.txtServerPass.Location = new System.Drawing.Point(142, 130);
            this.txtServerPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtServerPass.Name = "txtServerPass";
            this.txtServerPass.Size = new System.Drawing.Size(196, 22);
            this.txtServerPass.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Server Password:";
            // 
            // btnCredSave
            // 
            this.btnCredSave.Location = new System.Drawing.Point(132, 171);
            this.btnCredSave.Name = "btnCredSave";
            this.btnCredSave.Size = new System.Drawing.Size(75, 23);
            this.btnCredSave.TabIndex = 8;
            this.btnCredSave.Text = "Save";
            this.btnCredSave.UseVisualStyleBackColor = true;
            this.btnCredSave.Click += new System.EventHandler(this.btnCredSave_Click);
            // 
            // ConnectionStringWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 206);
            this.Controls.Add(this.btnCredSave);
            this.Controls.Add(this.txtServerPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtServerLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConnectionStringWindow";
            this.Text = "ConnectionStringWindow";
            this.Load += new System.EventHandler(this.ConnectionStringWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtDbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServerLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServerPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCredSave;
    }
}