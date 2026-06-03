namespace Droplink
{
    partial class MainForm
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
            pnlSidebar = new Panel();
            btnSettings = new Button();
            btnDownloadingList = new Button();
            btnHome = new Button();
            pnlMain = new Panel();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(26, 31, 44);
            pnlSidebar.Controls.Add(btnSettings);
            pnlSidebar.Controls.Add(btnDownloadingList);
            pnlSidebar.Controls.Add(btnHome);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(211, 455);
            pnlSidebar.TabIndex = 0;
            // 
            // btnSettings
            // 
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 65, 85);
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            btnSettings.ForeColor = Color.FromArgb(248, 250, 252);
            btnSettings.Location = new Point(17, 149);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(178, 41);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnDownloadingList
            // 
            btnDownloadingList.Cursor = Cursors.Hand;
            btnDownloadingList.FlatAppearance.BorderSize = 0;
            btnDownloadingList.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 65, 85);
            btnDownloadingList.FlatStyle = FlatStyle.Flat;
            btnDownloadingList.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            btnDownloadingList.ForeColor = Color.FromArgb(248, 250, 252);
            btnDownloadingList.Location = new Point(17, 102);
            btnDownloadingList.Name = "btnDownloadingList";
            btnDownloadingList.Size = new Size(178, 41);
            btnDownloadingList.TabIndex = 1;
            btnDownloadingList.Text = "Downloading List";
            btnDownloadingList.TextAlign = ContentAlignment.MiddleLeft;
            btnDownloadingList.UseVisualStyleBackColor = true;
            btnDownloadingList.Click += btnDownloadingList_Click;
            // 
            // btnHome
            // 
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 65, 85);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            btnHome.ForeColor = Color.FromArgb(248, 250, 252);
            btnHome.Location = new Point(17, 55);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(178, 41);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home / Download";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(211, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(682, 455);
            pnlMain.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 455);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            pnlSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Button btnHome;
        private Button btnSettings;
        private Button btnDownloadingList;
        private Panel pnlMain;
    }
}