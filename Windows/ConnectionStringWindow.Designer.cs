
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
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(37, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name:";
            // 
            // txtServerName
            // 
            this.txtServerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServerName.Location = new System.Drawing.Point(115, 3);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(378, 20);
            this.txtServerName.TabIndex = 1;
            // 
            // txtDbName
            // 
            this.txtDbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDbName.Location = new System.Drawing.Point(115, 34);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(378, 20);
            this.txtDbName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(19, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database Name: ";
            // 
            // txtServerLogin
            // 
            this.txtServerLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServerLogin.Location = new System.Drawing.Point(115, 65);
            this.txtServerLogin.Name = "txtServerLogin";
            this.txtServerLogin.Size = new System.Drawing.Size(378, 20);
            this.txtServerLogin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(39, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Server Login:";
            // 
            // txtServerPass
            // 
            this.txtServerPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServerPass.Location = new System.Drawing.Point(115, 96);
            this.txtServerPass.Name = "txtServerPass";
            this.txtServerPass.Size = new System.Drawing.Size(378, 20);
            this.txtServerPass.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(19, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Server Password:";
            // 
            // btnCredSave
            // 
            this.btnCredSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCredSave.Location = new System.Drawing.Point(2, 2);
            this.btnCredSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCredSave.Name = "btnCredSave";
            this.btnCredSave.Size = new System.Drawing.Size(160, 23);
            this.btnCredSave.TabIndex = 8;
            this.btnCredSave.Text = "Save";
            this.btnCredSave.UseVisualStyleBackColor = true;
            this.btnCredSave.Click += new System.EventHandler(this.btnCredSave_Click);
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTestConnection.Location = new System.Drawing.Point(166, 2);
            this.btnTestConnection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(160, 23);
            this.btnTestConnection.TabIndex = 9;
            this.btnTestConnection.Text = "Test";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(330, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel3.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTestConnection, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCredSave, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 126);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(492, 27);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.txtServerPass, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtServerLogin, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtServerName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtDbName, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(496, 155);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // ConnectionStringWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 171);
            this.Controls.Add(this.tableLayoutPanel3);
            this.MinimumSize = new System.Drawing.Size(378, 209);
            this.Name = "ConnectionStringWindow";
            this.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Database Connection Details";
            this.Load += new System.EventHandler(this.ConnectionStringWindow_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}