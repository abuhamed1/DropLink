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
    public partial class SettingsUserControl : UserControl
    {
        private readonly SettingService _settingService = new SettingService();
        private Setting _currentSettings;

        public SettingsUserControl()
        {
            InitializeComponent();

            try
            {
                // Fetch settings using the service
                _currentSettings = _settingService.GetSettings();

                // Assign values to your UI controls (TextBox and ComboBox)
                txtSavePath.Text = _currentSettings.DefaultSavePath;
                cmbQuality.SelectedItem = _currentSettings.DefaultQuality;
                chkStopOnWarnings.Checked = _currentSettings.StopOnWarnings;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                // Update the settings object with the new values from the UI
                _currentSettings.DefaultSavePath = txtSavePath.Text.Trim();
                _currentSettings.DefaultQuality = cmbQuality.SelectedItem?.ToString() ?? "Best Quality";
                _currentSettings.StopOnWarnings = chkStopOnWarnings.Checked;

                // Call the business service to validate and save
                _settingService.SaveSettings(_currentSettings);

                MessageBox.Show("Settings saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DirectoryNotFoundException dirEx)
            {
                // Friendly message if the folder path doesn't exist on Windows
                MessageBox.Show(dirEx.Message, "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSavePath.Text = folderDialog.SelectedPath;
                }
            }
        }
    }
}
