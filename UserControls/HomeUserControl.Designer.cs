namespace Droplink.UserControls
{
    partial class HomeUserControl
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
            pnlToggle = new Panel();
            btnPlaylist = new Button();
            btnVideo = new Button();
            lblInputTitle = new Label();
            txtUrl = new TextBox();
            label1 = new Label();
            cmbQuality = new ComboBox();
            btnStartDownload = new Button();
            progressBar1 = new ProgressBar();
            txtLogs = new RichTextBox();
            lblStatus = new Label();
            label2 = new Label();
            pnlToggle.SuspendLayout();
            SuspendLayout();
            // 
            // pnlToggle
            // 
            pnlToggle.BackColor = Color.FromArgb(226, 232, 240);
            pnlToggle.Controls.Add(btnPlaylist);
            pnlToggle.Controls.Add(btnVideo);
            pnlToggle.Location = new Point(163, 56);
            pnlToggle.Name = "pnlToggle";
            pnlToggle.Size = new Size(349, 42);
            pnlToggle.TabIndex = 0;
            // 
            // btnPlaylist
            // 
            btnPlaylist.Dock = DockStyle.Right;
            btnPlaylist.FlatAppearance.BorderSize = 0;
            btnPlaylist.FlatStyle = FlatStyle.Flat;
            btnPlaylist.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlaylist.Location = new Point(174, 0);
            btnPlaylist.Name = "btnPlaylist";
            btnPlaylist.Size = new Size(175, 42);
            btnPlaylist.TabIndex = 1;
            btnPlaylist.Text = "Playlist";
            btnPlaylist.UseVisualStyleBackColor = true;
            btnPlaylist.Click += btnPlaylist_Click;
            // 
            // btnVideo
            // 
            btnVideo.BackColor = Color.FromArgb(226, 232, 240);
            btnVideo.FlatAppearance.BorderSize = 0;
            btnVideo.FlatStyle = FlatStyle.Flat;
            btnVideo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVideo.Location = new Point(0, 0);
            btnVideo.Name = "btnVideo";
            btnVideo.Size = new Size(175, 42);
            btnVideo.TabIndex = 0;
            btnVideo.Text = "Video";
            btnVideo.UseVisualStyleBackColor = false;
            btnVideo.Click += btnVideo_Click;
            // 
            // lblInputTitle
            // 
            lblInputTitle.AutoSize = true;
            lblInputTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInputTitle.Location = new Point(163, 129);
            lblInputTitle.Name = "lblInputTitle";
            lblInputTitle.Size = new Size(180, 21);
            lblInputTitle.TabIndex = 1;
            lblInputTitle.Text = "Drop the video link here:";
            // 
            // txtUrl
            // 
            txtUrl.BorderStyle = BorderStyle.FixedSingle;
            txtUrl.Font = new Font("Segoe UI", 9F);
            txtUrl.Location = new Point(163, 156);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(349, 23);
            txtUrl.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(163, 198);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 3;
            label1.Text = "Quality list:";
            // 
            // cmbQuality
            // 
            cmbQuality.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbQuality.FlatStyle = FlatStyle.Flat;
            cmbQuality.Font = new Font("Segoe UI", 10F);
            cmbQuality.FormattingEnabled = true;
            cmbQuality.Items.AddRange(new object[] { "Best Quality", "1080p", "720p", "480p", "360p", "240p", "144p", "Audio Only (MP3)" });
            cmbQuality.Location = new Point(163, 225);
            cmbQuality.Name = "cmbQuality";
            cmbQuality.Size = new Size(349, 25);
            cmbQuality.TabIndex = 4;
            // 
            // btnStartDownload
            // 
            btnStartDownload.BackColor = Color.FromArgb(16, 185, 129);
            btnStartDownload.Cursor = Cursors.Hand;
            btnStartDownload.FlatAppearance.BorderSize = 0;
            btnStartDownload.FlatStyle = FlatStyle.Flat;
            btnStartDownload.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartDownload.ForeColor = Color.White;
            btnStartDownload.Location = new Point(163, 260);
            btnStartDownload.Name = "btnStartDownload";
            btnStartDownload.Size = new Size(349, 39);
            btnStartDownload.TabIndex = 5;
            btnStartDownload.Text = "Start Download";
            btnStartDownload.UseVisualStyleBackColor = false;
            btnStartDownload.Click += btnStartDownload_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(163, 354);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(349, 10);
            progressBar1.TabIndex = 6;
            progressBar1.Visible = false;
            // 
            // txtLogs
            // 
            txtLogs.BackColor = Color.Black;
            txtLogs.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogs.ForeColor = Color.FromArgb(248, 250, 252);
            txtLogs.Location = new Point(163, 397);
            txtLogs.Name = "txtLogs";
            txtLogs.ReadOnly = true;
            txtLogs.Size = new Size(349, 46);
            txtLogs.TabIndex = 8;
            txtLogs.Text = "";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(163, 329);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(109, 21);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Downloading..";
            lblStatus.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F);
            label2.Location = new Point(163, 380);
            label2.Name = "label2";
            label2.Size = new Size(46, 13);
            label2.TabIndex = 9;
            label2.Text = "Live log";
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            Controls.Add(label2);
            Controls.Add(txtLogs);
            Controls.Add(lblStatus);
            Controls.Add(progressBar1);
            Controls.Add(btnStartDownload);
            Controls.Add(cmbQuality);
            Controls.Add(label1);
            Controls.Add(txtUrl);
            Controls.Add(lblInputTitle);
            Controls.Add(pnlToggle);
            Name = "HomeUserControl";
            Size = new Size(682, 455);
            Load += HomeUserControl_Load;
            pnlToggle.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlToggle;
        private Button btnVideo;
        private Button btnPlaylist;
        private Label lblInputTitle;
        private TextBox txtUrl;
        private Label label1;
        private ComboBox cmbQuality;
        private Button btnStartDownload;
        private ProgressBar progressBar1;
        private RichTextBox txtLogs;
        private Label lblStatus;
        private Label label2;
    }
}
