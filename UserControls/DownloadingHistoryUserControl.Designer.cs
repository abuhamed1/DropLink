namespace Droplink.UserControls
{
    partial class DownloadingHistoryUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvDownloadHistory = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            DownloadDate = new DataGridViewTextBoxColumn();
            FileSize = new DataGridViewTextBoxColumn();
            OpenFolder = new DataGridViewButtonColumn();
            panel1 = new Panel();
            btnAutoOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDownloadHistory).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDownloadHistory
            // 
            dgvDownloadHistory.AllowUserToAddRows = false;
            dgvDownloadHistory.AllowUserToDeleteRows = false;
            dgvDownloadHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDownloadHistory.BackgroundColor = Color.White;
            dgvDownloadHistory.BorderStyle = BorderStyle.None;
            dgvDownloadHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDownloadHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDownloadHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDownloadHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDownloadHistory.Columns.AddRange(new DataGridViewColumn[] { Id, Title, Type, DownloadDate, FileSize, OpenFolder });
            dgvDownloadHistory.Dock = DockStyle.Fill;
            dgvDownloadHistory.EnableHeadersVisualStyles = false;
            dgvDownloadHistory.Location = new Point(0, 0);
            dgvDownloadHistory.Name = "dgvDownloadHistory";
            dgvDownloadHistory.ReadOnly = true;
            dgvDownloadHistory.RowHeadersVisible = false;
            dgvDownloadHistory.RowHeadersWidth = 51;
            dgvDownloadHistory.RowTemplate.Height = 35;
            dgvDownloadHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDownloadHistory.Size = new Size(640, 364);
            dgvDownloadHistory.TabIndex = 0;
            dgvDownloadHistory.CellContentClick += dgvDownloadHistory_CellContentClick;
            // 
            // Id
            // 
            Id.FillWeight = 50F;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Title
            // 
            Title.FillWeight = 240F;
            Title.HeaderText = "Title";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.ReadOnly = true;
            // 
            // DownloadDate
            // 
            DownloadDate.FillWeight = 150F;
            DownloadDate.HeaderText = "Download date";
            DownloadDate.MinimumWidth = 6;
            DownloadDate.Name = "DownloadDate";
            DownloadDate.ReadOnly = true;
            // 
            // FileSize
            // 
            FileSize.FillWeight = 60F;
            FileSize.HeaderText = "Size";
            FileSize.MinimumWidth = 6;
            FileSize.Name = "FileSize";
            FileSize.ReadOnly = true;
            // 
            // OpenFolder
            // 
            OpenFolder.FillWeight = 120F;
            OpenFolder.HeaderText = "Open Folder";
            OpenFolder.MinimumWidth = 6;
            OpenFolder.Name = "OpenFolder";
            OpenFolder.ReadOnly = true;
            OpenFolder.Resizable = DataGridViewTriState.True;
            OpenFolder.SortMode = DataGridViewColumnSortMode.Automatic;
            OpenFolder.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvDownloadHistory);
            panel1.Location = new Point(20, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 364);
            panel1.TabIndex = 2;
            // 
            // btnAutoOrder
            // 
            btnAutoOrder.BackColor = Color.Gray;
            btnAutoOrder.FlatAppearance.BorderSize = 0;
            btnAutoOrder.FlatStyle = FlatStyle.Flat;
            btnAutoOrder.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutoOrder.ForeColor = Color.White;
            btnAutoOrder.Location = new Point(20, 403);
            btnAutoOrder.Name = "btnAutoOrder";
            btnAutoOrder.Size = new Size(110, 32);
            btnAutoOrder.TabIndex = 3;
            btnAutoOrder.Text = "Auto ordering";
            btnAutoOrder.UseVisualStyleBackColor = false;
            // 
            // DownloadingHistoryUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            Controls.Add(btnAutoOrder);
            Controls.Add(panel1);
            Name = "DownloadingHistoryUserControl";
            Size = new Size(682, 455);
            Load += DownloadingHistoryUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDownloadHistory).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDownloadHistory;
        private Panel panel1;
        private Button btnAutoOrder;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn DownloadDate;
        private DataGridViewTextBoxColumn FileSize;
        private DataGridViewButtonColumn OpenFolder;
    }
}
