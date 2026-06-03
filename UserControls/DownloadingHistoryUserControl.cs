using Domains;
using DropLinkBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Droplink.UserControls
{
    public partial class DownloadingHistoryUserControl : UserControl
    {
        private readonly DownloadService _downloadService = new DownloadService();

        public DownloadingHistoryUserControl()
        {
            InitializeComponent();
        }

        private void DownloadingHistoryUserControl_Load(object sender, EventArgs e)
        {
            _loadHistory();
        }

        private void _loadHistory()
        {
            try
            {
                var historyList = _downloadService.GetAll().ToList();

                dgvDownloadHistory.AutoGenerateColumns = false;

                dgvDownloadHistory.Columns["Id"].DataPropertyName = "Id";
                dgvDownloadHistory.Columns["Title"].DataPropertyName = "Title";
                dgvDownloadHistory.Columns["Type"].DataPropertyName = "Type";
                dgvDownloadHistory.Columns["DownloadDate"].DataPropertyName = "DownloadDate";
                dgvDownloadHistory.Columns["FileSize"].DataPropertyName = "FileSize";

                dgvDownloadHistory.DataSource = historyList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading history: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvDownloadHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDownloadHistory.Columns[e.ColumnIndex].Name == "OpenFolder")
            {
                var clickedDownload = dgvDownloadHistory.Rows[e.RowIndex].DataBoundItem as Download;

                if (clickedDownload != null && Directory.Exists(clickedDownload.FilePath))
                {
                    Process.Start("explorer.exe", clickedDownload.FilePath);
                }
                else
                {
                    MessageBox.Show("Folder directory not found or has been moved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
