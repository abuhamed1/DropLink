using Domains;
using DropLinkBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Droplink.UserControls
{
    public partial class HomeUserControl : UserControl
    {
        // Define the services at the class level
        private readonly DownloadService _downloadService = new DownloadService();
        private readonly SettingService _settingService = new SettingService();

        private static HomeUserControl _instance;

        public static HomeUserControl Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new HomeUserControl();

                return _instance;
            }
        }

        private HomeUserControl()
        {
            InitializeComponent();
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            lblInputTitle.Text = "Drop the video link here:";

            btnPlaylist.BackColor = Color.FromArgb(226, 232, 240);
            btnPlaylist.ForeColor = Color.Black;

            btnVideo.BackColor = Color.FromArgb(59, 130, 246);
            btnVideo.ForeColor = Color.White;
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            lblInputTitle.Text = "Drop the playlist link here:";

            btnVideo.BackColor = Color.FromArgb(226, 232, 240);
            btnVideo.ForeColor = Color.Black;

            btnPlaylist.BackColor = Color.FromArgb(59, 130, 246);
            btnPlaylist.ForeColor = Color.White;
        }

        private void HomeUserControl_Load(object sender, EventArgs e)
        {
            btnVideo.PerformClick();

            try
            {
                Setting userSettings = _settingService.GetSettings();
                string defaultQuality = userSettings.DefaultQuality;

                // 3. Set the ComboBox to match the saved default quality
                // This looks through the items and selects the one matching the text
                if (cmbQuality.Items.Contains(defaultQuality))
                {
                    cmbQuality.SelectedItem = defaultQuality;
                }
                else
                {
                    // Fallback: If nothing matches or it's empty, select the first item
                    if (cmbQuality.Items.Count > 0)
                    {
                        cmbQuality.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Fail silently or log it so it doesn't crash the UI on startup
                txtLogs.AppendText($"⚠️ Note: Could not load default quality: {ex.Message}{Environment.NewLine}");
            }
        }

        private void btnStartDownload_Click(object sender, EventArgs e)
        {
            string videoUrl = txtUrl.Text.Trim();

            // 1. Validation: Check if the URL field is empty
            if (string.IsNullOrEmpty(videoUrl))
            {
                MessageBox.Show("Please paste a valid video URL first!", "Missing URL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Fetch the saved settings
                Setting userSettings = _settingService.GetSettings();
                string savePath = userSettings.DefaultSavePath;
                string quality = cmbQuality.Text;

                // Clear the log textbox and notify the user
                txtLogs.Clear();
                txtLogs.AppendText($"⏳ Starting download process...{Environment.NewLine}");

                // 3. RUN IN BACKGROUND THREAD (To prevent UI freezing!)
                Task.Run(() =>
                {
                    try
                    {
                        _downloadService.StartVideoDownload(videoUrl, savePath, quality, UpdateLogWindow);
                    }
                    catch (Exception ex)
                    {
                        // If anything crashes inside the background thread, show it safely
                        this.Invoke(new Action(() =>
                        {
                            MessageBox.Show($"Download thread error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }));
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateLogWindow(string logMessage)
        {
            // Check if the control requires an Invoke call (cross-thread safety)
            if (txtLogs.InvokeRequired)
            {
                txtLogs.Invoke(new Action<string>(UpdateLogWindow), logMessage);
            }
            else
            {
                // Append the new line coming from yt-dlp to the UI TextBox
                txtLogs.AppendText(logMessage + Environment.NewLine);

                // Auto-scroll to the bottom so the user sees the latest progress percentage
                txtLogs.SelectionStart = txtLogs.Text.Length;
                txtLogs.ScrollToCaret();
            }
        }
    }
}
