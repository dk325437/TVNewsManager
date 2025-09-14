using System;
using System.Windows.Forms;
using TVNewsManager.Services;

namespace TVNewsManager.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private QuanLyBanTin manager;

        // Constructor nhận manager từ Program.cs
        public MainForm(QuanLyBanTin ql)
        {
            InitializeComponent();
            manager = ql;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Có thể để trống hoặc hiển thị thông báo
            this.Text = "Chương trình Quản lý Bản Tin Truyền Hình";
        }

        
        private void btnNews_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn MainForm
            NewsForm nf = new NewsForm(manager);
            nf.ShowDialog();
            this.Show(); // Khi NewsForm đóng, hiện lại MainForm
        }



        private void btnReport_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn MainForm
            ReportForm rf = new ReportForm(manager);
            rf.ShowDialog();
            this.Show(); // Khi ReportForm đóng, hiện lại MainForm
        }

        private void btnPersons_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn MainForm
            PersonForm pf = new PersonForm(manager);
            pf.ShowDialog();
            this.Show(); // Khi PersonForm đóng, quay lại MainForm
        }


        private void btnStats_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn MainForm
            StatsForm sf = new StatsForm(manager);
            sf.ShowDialog();
            this.Show(); // Khi StatsForm đóng, quay lại MainForm
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
