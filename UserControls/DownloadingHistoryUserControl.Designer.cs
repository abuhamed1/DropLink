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
            dgvDownloadsList = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colDownloadDate = new DataGridViewTextBoxColumn();
            colFileSize = new DataGridViewTextBoxColumn();
            colOpenFolder = new DataGridViewButtonColumn();
            panel1 = new Panel();
            btnAutoOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDownloadsList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDownloadsList
            // 
            dgvDownloadsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDownloadsList.BackgroundColor = Color.White;
            dgvDownloadsList.BorderStyle = BorderStyle.None;
            dgvDownloadsList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDownloadsList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDownloadsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDownloadsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDownloadsList.Columns.AddRange(new DataGridViewColumn[] { ColId, colTitle, colType, colDownloadDate, colFileSize, colOpenFolder });
            dgvDownloadsList.Dock = DockStyle.Fill;
            dgvDownloadsList.EnableHeadersVisualStyles = false;
            dgvDownloadsList.Location = new Point(0, 0);
            dgvDownloadsList.Name = "dgvDownloadsList";
            dgvDownloadsList.RowHeadersVisible = false;
            dgvDownloadsList.RowHeadersWidth = 51;
            dgvDownloadsList.RowTemplate.Height = 35;
            dgvDownloadsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDownloadsList.Size = new Size(640, 364);
            dgvDownloadsList.TabIndex = 0;
            // 
            // ColId
            // 
            ColId.FillWeight = 50F;
            ColId.HeaderText = "Id";
            ColId.MinimumWidth = 6;
            ColId.Name = "ColId";
            // 
            // colTitle
            // 
            colTitle.FillWeight = 240F;
            colTitle.HeaderText = "Title";
            colTitle.MinimumWidth = 6;
            colTitle.Name = "colTitle";
            // 
            // colType
            // 
            colType.HeaderText = "Type";
            colType.MinimumWidth = 6;
            colType.Name = "colType";
            // 
            // colDownloadDate
            // 
            colDownloadDate.FillWeight = 150F;
            colDownloadDate.HeaderText = "Download date";
            colDownloadDate.MinimumWidth = 6;
            colDownloadDate.Name = "colDownloadDate";
            // 
            // colFileSize
            // 
            colFileSize.FillWeight = 60F;
            colFileSize.HeaderText = "Size";
            colFileSize.MinimumWidth = 6;
            colFileSize.Name = "colFileSize";
            // 
            // colOpenFolder
            // 
            colOpenFolder.FillWeight = 120F;
            colOpenFolder.HeaderText = "Open Folder";
            colOpenFolder.MinimumWidth = 6;
            colOpenFolder.Name = "colOpenFolder";
            colOpenFolder.Resizable = DataGridViewTriState.True;
            colOpenFolder.SortMode = DataGridViewColumnSortMode.Automatic;
            colOpenFolder.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvDownloadsList);
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
            ((System.ComponentModel.ISupportInitialize)dgvDownloadsList).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDownloadsList;
        private Panel panel1;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colDownloadDate;
        private DataGridViewTextBoxColumn colFileSize;
        private DataGridViewButtonColumn colOpenFolder;
        private Button btnAutoOrder;
    }
}
