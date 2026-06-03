using Droplink.UserControls;
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

namespace Droplink
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnDownloadingList.BackColor = Color.FromArgb(26, 31, 44);
            btnSettings.BackColor = Color.FromArgb(26, 31, 44);

            btnHome.BackColor = Color.FromArgb(59, 130, 246);

            pnlMain.Controls.Clear();
            HomeUserControl.Instance.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(HomeUserControl.Instance);
        }

        private void btnDownloadingList_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(26, 31, 44);
            btnSettings.BackColor = Color.FromArgb(26, 31, 44);

            btnDownloadingList.BackColor = Color.FromArgb(59, 130, 246);

            pnlMain.Controls.Clear();
            DownloadingHistoryUserControl ucDownloadingList = new DownloadingHistoryUserControl();
            ucDownloadingList.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(ucDownloadingList);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(26, 31, 44);
            btnDownloadingList.BackColor = Color.FromArgb(26, 31, 44);

            btnSettings.BackColor = Color.FromArgb(59, 130, 246);

            pnlMain.Controls.Clear();
            SettingsUserControl ucSettings = new SettingsUserControl();
            ucSettings.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(ucSettings);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnHome.PerformClick();
        }

    }
}
