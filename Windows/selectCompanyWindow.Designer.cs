
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
            this.exportButton = new System.Windows.Forms.Button();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.companyListDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companyListDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.companyListDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companyListDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.companyListDropdown.FormattingEnabled = true;
            this.companyListDropdown.IsDerivedStyle = true;
            this.companyListDropdown.ItemHeight = 20;
            this.companyListDropdown.Location = new System.Drawing.Point(303, 3);
            this.companyListDropdown.Name = "companyListDropdown";
            this.companyListDropdown.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.companyListDropdown.SelectedItemForeColor = System.Drawing.Color.White;
            this.companyListDropdown.Size = new System.Drawing.Size(422, 26);
            this.companyListDropdown.Style = MetroSet_UI.Enums.Style.Light;
            this.companyListDropdown.StyleManager = null;
            this.companyListDropdown.TabIndex = 0;
            this.companyListDropdown.ThemeAuthor = "Narwin";
            this.companyListDropdown.ThemeName = "MetroLite";
            // 
            // exportButton
            // 
            this.exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel1.SetColumnSpan(this.exportButton, 2);
            this.exportButton.Location = new System.Drawing.Point(292, 78);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(144, 29);
            this.exportButton.TabIndex = 1;
            this.exportButton.Text = "Export Contact";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(294, 75);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 2;
            this.metroSetLabel1.Text = "Select contact company:";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.exportButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroSetLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.companyListDropdown, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(728, 110);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // selectCompanyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 110);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "selectCompanyWindow";
            this.Text = "Select Company";
            this.Load += new System.EventHandler(this.selectContactWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetComboBox companyListDropdown;
        private System.Windows.Forms.Button exportButton;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}