namespace TVNewsManager.UI
{
    partial class StatsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTotalNews;
        private System.Windows.Forms.Label lblTotalReports;
        private System.Windows.Forms.Label lblTotalDuration;
        private System.Windows.Forms.DataGridView dgvStats;
        private System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTotalNews = new System.Windows.Forms.Label();
            this.lblTotalReports = new System.Windows.Forms.Label();
            this.lblTotalDuration = new System.Windows.Forms.Label();
            this.dgvStats = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalNews
            // 
            this.lblTotalNews.Location = new System.Drawing.Point(20, 20);
            this.lblTotalNews.Text = "Tổng số bản tin: 0";
            this.lblTotalNews.AutoSize = true;
            // 
            // lblTotalReports
            // 
            this.lblTotalReports.Location = new System.Drawing.Point(20, 50);
            this.lblTotalReports.Text = "Tổng số phóng sự: 0";
            this.lblTotalReports.AutoSize = true;
            // 
            // lblTotalDuration
            // 
            this.lblTotalDuration.Location = new System.Drawing.Point(20, 80);
            this.lblTotalDuration.Text = "Tổng thời lượng: 0 phút";
            this.lblTotalDuration.AutoSize = true;
            // 
            // dgvStats
            // 
            this.dgvStats.Location = new System.Drawing.Point(20, 120);
            this.dgvStats.Size = new System.Drawing.Size(440, 150);
            this.dgvStats.ReadOnly = true;
            this.dgvStats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStats.Columns.Add("TheLoai", "Thể loại");
            this.dgvStats.Columns.Add("SoLuong", "Số lượng");
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(180, 280);
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.Text = "Quay lại";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // StatsForm
            // 
            this.ClientSize = new System.Drawing.Size(500, 330);
            this.Controls.Add(this.lblTotalNews);
            this.Controls.Add(this.lblTotalReports);
            this.Controls.Add(this.lblTotalDuration);
            this.Controls.Add(this.dgvStats);
            this.Controls.Add(this.btnBack);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.StatsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
