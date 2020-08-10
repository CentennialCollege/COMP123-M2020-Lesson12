namespace COMP123_M2020_Lesson11
{
    partial class ContactInfoForm
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
            this.PrimaryMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContactListOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ContactInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailAddressLabel = new System.Windows.Forms.Label();
            this.EmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.ContacNumberLabel = new System.Windows.Forms.Label();
            this.ContactNumberTextBox = new System.Windows.Forms.TextBox();
            this.ContactComboBox = new System.Windows.Forms.ComboBox();
            this.ContactListLabel = new System.Windows.Forms.Label();
            this.PrimaryMenuStrip.SuspendLayout();
            this.ContactInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrimaryMenuStrip
            // 
            this.PrimaryMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.PrimaryMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.PrimaryMenuStrip.Name = "PrimaryMenuStrip";
            this.PrimaryMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.PrimaryMenuStrip.TabIndex = 0;
            this.PrimaryMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ContactListOpenFileDialog
            // 
            this.ContactListOpenFileDialog.DefaultExt = "txt";
            this.ContactListOpenFileDialog.FileName = "ContactList";
            this.ContactListOpenFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
            // 
            // ContactInfoGroupBox
            // 
            this.ContactInfoGroupBox.Controls.Add(this.ContactNumberTextBox);
            this.ContactInfoGroupBox.Controls.Add(this.ContacNumberLabel);
            this.ContactInfoGroupBox.Controls.Add(this.LastNameTextBox);
            this.ContactInfoGroupBox.Controls.Add(this.EmailAddressTextBox);
            this.ContactInfoGroupBox.Controls.Add(this.LastNameLabel);
            this.ContactInfoGroupBox.Controls.Add(this.EmailAddressLabel);
            this.ContactInfoGroupBox.Controls.Add(this.FirstNameTextBox);
            this.ContactInfoGroupBox.Controls.Add(this.FirstNameLabel);
            this.ContactInfoGroupBox.ForeColor = System.Drawing.Color.Black;
            this.ContactInfoGroupBox.Location = new System.Drawing.Point(303, 27);
            this.ContactInfoGroupBox.Name = "ContactInfoGroupBox";
            this.ContactInfoGroupBox.Size = new System.Drawing.Size(445, 368);
            this.ContactInfoGroupBox.TabIndex = 2;
            this.ContactInfoGroupBox.TabStop = false;
            this.ContactInfoGroupBox.Text = "Contact Information";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(7, 38);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(147, 31);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.BackColor = System.Drawing.Color.White;
            this.FirstNameTextBox.Location = new System.Drawing.Point(7, 73);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.ReadOnly = true;
            this.FirstNameTextBox.Size = new System.Drawing.Size(419, 38);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(6, 117);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(145, 31);
            this.LastNameLabel.TabIndex = 0;
            this.LastNameLabel.Text = "Last Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.BackColor = System.Drawing.Color.White;
            this.LastNameTextBox.Location = new System.Drawing.Point(6, 152);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.ReadOnly = true;
            this.LastNameTextBox.Size = new System.Drawing.Size(419, 38);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // EmailAddressLabel
            // 
            this.EmailAddressLabel.AutoSize = true;
            this.EmailAddressLabel.Location = new System.Drawing.Point(7, 198);
            this.EmailAddressLabel.Name = "EmailAddressLabel";
            this.EmailAddressLabel.Size = new System.Drawing.Size(188, 31);
            this.EmailAddressLabel.TabIndex = 0;
            this.EmailAddressLabel.Text = "Email Address";
            // 
            // EmailAddressTextBox
            // 
            this.EmailAddressTextBox.BackColor = System.Drawing.Color.White;
            this.EmailAddressTextBox.Location = new System.Drawing.Point(7, 233);
            this.EmailAddressTextBox.Name = "EmailAddressTextBox";
            this.EmailAddressTextBox.ReadOnly = true;
            this.EmailAddressTextBox.Size = new System.Drawing.Size(419, 38);
            this.EmailAddressTextBox.TabIndex = 1;
            // 
            // ContacNumberLabel
            // 
            this.ContacNumberLabel.AutoSize = true;
            this.ContacNumberLabel.Location = new System.Drawing.Point(6, 277);
            this.ContacNumberLabel.Name = "ContacNumberLabel";
            this.ContacNumberLabel.Size = new System.Drawing.Size(205, 31);
            this.ContacNumberLabel.TabIndex = 0;
            this.ContacNumberLabel.Text = "ContactNumber";
            // 
            // ContactNumberTextBox
            // 
            this.ContactNumberTextBox.BackColor = System.Drawing.Color.White;
            this.ContactNumberTextBox.Location = new System.Drawing.Point(6, 312);
            this.ContactNumberTextBox.Name = "ContactNumberTextBox";
            this.ContactNumberTextBox.ReadOnly = true;
            this.ContactNumberTextBox.Size = new System.Drawing.Size(419, 38);
            this.ContactNumberTextBox.TabIndex = 1;
            // 
            // ContactComboBox
            // 
            this.ContactComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.ContactComboBox.FormattingEnabled = true;
            this.ContactComboBox.Location = new System.Drawing.Point(12, 100);
            this.ContactComboBox.Name = "ContactComboBox";
            this.ContactComboBox.Size = new System.Drawing.Size(245, 145);
            this.ContactComboBox.TabIndex = 3;
            this.ContactComboBox.SelectedIndexChanged += new System.EventHandler(this.ContactComboBox_SelectedIndexChanged);
            // 
            // ContactListLabel
            // 
            this.ContactListLabel.AutoSize = true;
            this.ContactListLabel.Location = new System.Drawing.Point(12, 65);
            this.ContactListLabel.Name = "ContactListLabel";
            this.ContactListLabel.Size = new System.Drawing.Size(159, 31);
            this.ContactListLabel.TabIndex = 4;
            this.ContactListLabel.Text = "Contact List";
            // 
            // ContactInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ContactListLabel);
            this.Controls.Add(this.ContactComboBox);
            this.Controls.Add(this.ContactInfoGroupBox);
            this.Controls.Add(this.PrimaryMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.PrimaryMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "ContactInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactInfoForm_FormClosing);
            this.PrimaryMenuStrip.ResumeLayout(false);
            this.PrimaryMenuStrip.PerformLayout();
            this.ContactInfoGroupBox.ResumeLayout(false);
            this.ContactInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip PrimaryMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ContactListOpenFileDialog;
        private System.Windows.Forms.GroupBox ContactInfoGroupBox;
        private System.Windows.Forms.TextBox ContactNumberTextBox;
        private System.Windows.Forms.Label ContacNumberLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox EmailAddressTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label EmailAddressLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.ComboBox ContactComboBox;
        private System.Windows.Forms.Label ContactListLabel;
    }
}