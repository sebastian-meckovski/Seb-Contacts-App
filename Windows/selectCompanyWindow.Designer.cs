
namespace SebContactsApp
{
    partial class selectCompanyWindow
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
            this.companyListDropdown = new MetroSet_UI.Controls.MetroSetComboBox();
            this.SuspendLayout();
            // 
            // companyListDropdown
            // 
            this.companyListDropdown.AllowDrop = true;
            this.companyListDropdown.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.companyListDropdown.BackColor = System.Drawing.Color.Transparent;
            this.companyListDropdown.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.companyListDropdown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.companyListDropdown.CausesValidation = false;
            this.companyListDropdown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.companyListDropdown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.companyListDropdown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.companyListDropdown.DisplayMember = "cd_statement_name";
            this.companyListDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.companyListDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companyListDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.companyListDropdown.FormattingEnabled = true;
            this.companyListDropdown.IsDerivedStyle = true;
            this.companyListDropdown.ItemHeight = 20;
            this.companyListDropdown.Location = new System.Drawing.Point(117, 94);
            this.companyListDropdown.Name = "companyListDropdown";
            this.companyListDropdown.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.companyListDropdown.SelectedItemForeColor = System.Drawing.Color.White;
            this.companyListDropdown.Size = new System.Drawing.Size(237, 26);
            this.companyListDropdown.Style = MetroSet_UI.Enums.Style.Light;
            this.companyListDropdown.StyleManager = null;
            this.companyListDropdown.TabIndex = 0;
            this.companyListDropdown.ThemeAuthor = "Narwin";
            this.companyListDropdown.ThemeName = "MetroLite";
            // 
            // selectCompanyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 233);
            this.Controls.Add(this.companyListDropdown);
            this.Name = "selectCompanyWindow";
            this.Text = "Select Company";
            this.Load += new System.EventHandler(this.selectContactWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetComboBox companyListDropdown;
    }
}