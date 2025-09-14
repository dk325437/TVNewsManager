namespace TVNewsManager.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnNews;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnPersons;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnExit;

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
            btnNews = new Button();
            btnReport = new Button();
            btnPersons = new Button();
            btnStats = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnNews
            // 
            btnNews.Location = new Point(50, 50);
            btnNews.Name = "btnNews";
            btnNews.Size = new Size(150, 40);
            btnNews.TabIndex = 0;
            btnNews.Text = "Quản lý Bản Tin";
            btnNews.UseVisualStyleBackColor = true;
            btnNews.Click += btnNews_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(281, 50);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(150, 40);
            btnReport.TabIndex = 1;
            btnReport.Text = "Quản lý Phóng Sự";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnPersons
            // 
            btnPersons.Location = new Point(50, 120);
            btnPersons.Name = "btnPersons";
            btnPersons.Size = new Size(150, 40);
            btnPersons.TabIndex = 2;
            btnPersons.Text = "Quản lý Nhân Sự";
            btnPersons.UseVisualStyleBackColor = true;
            btnPersons.Click += btnPersons_Click;
            // 
            // btnStats
            // 
            btnStats.Location = new Point(281, 120);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(150, 40);
            btnStats.TabIndex = 3;
            btnStats.Text = "Thống Kê";
            btnStats.UseVisualStyleBackColor = true;
            btnStats.Click += btnStats_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(163, 206);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 40);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // MainForm
            // 
            BackColor = SystemColors.Control;
            ClientSize = new Size(480, 300);
            Controls.Add(btnNews);
            Controls.Add(btnReport);
            Controls.Add(btnPersons);
            Controls.Add(btnStats);
            Controls.Add(btnExit);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Bản Tin Truyền Hình";
            ResumeLayout(false);
        }
    }
}
