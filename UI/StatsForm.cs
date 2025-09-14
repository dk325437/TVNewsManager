using System;
using System.Windows.Forms;
using TVNewsManager.Entities;
using TVNewsManager.Services;

namespace TVNewsManager.UI
{
    public partial class StatsForm : Form
    {
        private QuanLyBanTin manager;

        public StatsForm(QuanLyBanTin ql)
        {
            InitializeComponent();
            manager = ql;
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {
            HienThiThongKe();
        }

        private void HienThiThongKe()
        {
            int tongBanTin = manager.LayTatCaBanTin().Length;
            int tongPhongSu = 0;
            int tongThoiLuong = 0;

            foreach (BanTin bt in manager.LayTatCaBanTin())
            {
                tongPhongSu += bt.DanhSachPhongSu.Count;
                tongThoiLuong += bt.TongThoiLuong();
            }

            lblTotalNews.Text = "Tổng số bản tin: " + tongBanTin;
            lblTotalReports.Text = "Tổng số phóng sự: " + tongPhongSu;
            lblTotalDuration.Text = "Tổng thời lượng: " + tongThoiLuong + " phút";

            dgvStats.Rows.Clear();
            foreach (TheLoai tl in Enum.GetValues(typeof(TheLoai)))
            {
                int count = 0;
                foreach (BanTin bt in manager.LayTatCaBanTin())
                {
                    if (bt.TheLoai == tl) count++;
                }
                dgvStats.Rows.Add(tl.ToString(), count);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // quay lại MainForm
        }
    }
}
