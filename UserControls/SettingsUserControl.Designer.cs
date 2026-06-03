namespace Droplink.UserControls
{
    partial class SettingsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbSaveSettings = new GroupBox();
            txtSavePath = new TextBox();
            btnBrowse = new Button();
            label1 = new Label();
            gbQualitySettings = new GroupBox();
            cmbQuality = new ComboBox();
            label2 = new Label();
            gbAdvancedSettings = new GroupBox();
            chkStopOnWarnings = new CheckBox();
            btnSaveSettings = new Button();
            gbSaveSettings.SuspendLayout();
            gbQualitySettings.SuspendLayout();
            gbAdvancedSettings.SuspendLayout();
            SuspendLayout();
            // 
            // gbSaveSettings
            // 
            gbSaveSettings.Controls.Add(txtSavePath);
            gbSaveSettings.Controls.Add(btnBrowse);
            gbSaveSettings.Controls.Add(label1);
            gbSaveSettings.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbSaveSettings.ForeColor = Color.FromArgb(30, 41, 59);
            gbSaveSettings.Location = new Point(21, 40);
            gbSaveSettings.Margin = new Padding(3, 2, 3, 2);
            gbSaveSettings.Name = "gbSaveSettings";
            gbSaveSettings.Padding = new Padding(3, 2, 3, 2);
            gbSaveSettings.Size = new Size(642, 94);
            gbSaveSettings.TabIndex = 0;
            gbSaveSettings.TabStop = false;
            gbSaveSettings.Text = "Save Settings:";
            // 
            // txtSavePath
            // 
            txtSavePath.BorderStyle = BorderStyle.FixedSingle;
            txtSavePath.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSavePath.Location = new Point(104, 52);
            txtSavePath.Name = "txtSavePath";
            txtSavePath.ReadOnly = true;
            txtSavePath.Size = new Size(508, 23);
            txtSavePath.TabIndex = 2;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.DimGray;
            btnBrowse.FlatAppearance.BorderSize = 0;
            btnBrowse.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btnBrowse.FlatAppearance.MouseOverBackColor = Color.FromArgb(9, 130, 246);
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(32, 52);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(68, 23);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 30);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 0;
            label1.Text = "Default Download Folder:";
            // 
            // gbQualitySettings
            // 
            gbQualitySettings.Controls.Add(cmbQuality);
            gbQualitySettings.Controls.Add(label2);
            gbQualitySettings.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbQualitySettings.ForeColor = Color.FromArgb(30, 41, 59);
            gbQualitySettings.Location = new Point(21, 154);
            gbQualitySettings.Margin = new Padding(3, 2, 3, 2);
            gbQualitySettings.Name = "gbQualitySettings";
            gbQualitySettings.Padding = new Padding(3, 2, 3, 2);
            gbQualitySettings.Size = new Size(642, 94);
            gbQualitySettings.TabIndex = 3;
            gbQualitySettings.TabStop = false;
            gbQualitySettings.Text = "Quality Preferences:";
            // 
            // cmbQuality
            // 
            cmbQuality.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbQuality.Font = new Font("Segoe UI", 10F);
            cmbQuality.FormattingEnabled = true;
            cmbQuality.Items.AddRange(new object[] { "Best Quality", "1080p", "720p", "480p", "360p", "240p", "144p", "Audio Only (MP3)" });
            cmbQuality.Location = new Point(32, 50);
            cmbQuality.Name = "cmbQuality";
            cmbQuality.Size = new Size(580, 25);
            cmbQuality.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 29);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 0;
            label2.Text = "Default Quality:";
            // 
            // gbAdvancedSettings
            // 
            gbAdvancedSettings.Controls.Add(chkStopOnWarnings);
            gbAdvancedSettings.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbAdvancedSettings.ForeColor = Color.FromArgb(30, 41, 59);
            gbAdvancedSettings.Location = new Point(21, 267);
            gbAdvancedSettings.Margin = new Padding(3, 2, 3, 2);
            gbAdvancedSettings.Name = "gbAdvancedSettings";
            gbAdvancedSettings.Padding = new Padding(3, 2, 3, 2);
            gbAdvancedSettings.Size = new Size(642, 68);
            gbAdvancedSettings.TabIndex = 5;
            gbAdvancedSettings.TabStop = false;
            gbAdvancedSettings.Text = "Safety and Control:";
            // 
            // chkStopOnWarnings
            // 
            chkStopOnWarnings.AutoSize = true;
            chkStopOnWarnings.Cursor = Cursors.Hand;
            chkStopOnWarnings.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            chkStopOnWarnings.Location = new Point(32, 32);
            chkStopOnWarnings.Name = "chkStopOnWarnings";
            chkStopOnWarnings.Size = new Size(280, 23);
            chkStopOnWarnings.TabIndex = 0;
            chkStopOnWarnings.Text = "Automatically stop on security warnings";
            chkStopOnWarnings.UseVisualStyleBackColor = true;
            // 
            // btnSaveSettings
            // 
            btnSaveSettings.BackColor = Color.FromArgb(9, 130, 246);
            btnSaveSettings.FlatAppearance.BorderSize = 0;
            btnSaveSettings.FlatStyle = FlatStyle.Flat;
            btnSaveSettings.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveSettings.ForeColor = Color.White;
            btnSaveSettings.Location = new Point(21, 362);
            btnSaveSettings.Name = "btnSaveSettings";
            btnSaveSettings.Size = new Size(642, 34);
            btnSaveSettings.TabIndex = 6;
            btnSaveSettings.Text = "Save";
            btnSaveSettings.UseVisualStyleBackColor = false;
            btnSaveSettings.Click += btnSaveSettings_Click;
            // 
            // SettingsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            Controls.Add(btnSaveSettings);
            Controls.Add(gbAdvancedSettings);
            Controls.Add(gbQualitySettings);
            Controls.Add(gbSaveSettings);
            Name = "SettingsUserControl";
            Size = new Size(682, 455);
            gbSaveSettings.ResumeLayout(false);
            gbSaveSettings.PerformLayout();
            gbQualitySettings.ResumeLayout(false);
            gbQualitySettings.PerformLayout();
            gbAdvancedSettings.ResumeLayout(false);
            gbAdvancedSettings.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbSaveSettings;
        private Label label1;
        private Button btnBrowse;
        private TextBox txtSavePath;
        private GroupBox gbQualitySettings;
        private Label label2;
        private ComboBox cmbQuality;
        private GroupBox gbAdvancedSettings;
        private CheckBox chkStopOnWarnings;
        private Button btnSaveSettings;
    }
}
