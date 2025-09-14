using System;
using System.Windows.Forms;
using TVNewsManager.Entities;
using TVNewsManager.Services;

namespace TVNewsManager.UI
{
    public partial class ReportForm : Form
    {
        private QuanLyBanTin manager;

        public ReportForm(QuanLyBanTin ql)
        {
            InitializeComponent();
            manager = ql;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // Đổ danh sách phóng viên vào ComboBox
            cmbReporter.Items.Clear();
            foreach (NhanSu ns in manager.LayTatCaNhanSu())
            {
                if (ns is PhongVien)
                {
                    cmbReporter.Items.Add(ns);
                }
            }

            if (cmbReporter.Items.Count > 0)
                cmbReporter.SelectedIndex = 0;

            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            dgvReports.Rows.Clear();
            foreach (BanTin bt in manager.LayTatCaBanTin())
            {
                foreach (PhongSu ps in bt.DanhSachPhongSu)
                {
                    dgvReports.Rows.Add(ps.TieuDe, ps.ThoiLuong, ps.PhongVien.HoTen);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string td = txtTitle.Text.Trim();
            if (td == "")
            {
                MessageBox.Show("Vui lòng nhập tiêu đề phóng sự.");
                return;
            }

            if (!int.TryParse(txtDuration.Text.Trim(), out int thoiLuong) || thoiLuong <= 0)
            {
                MessageBox.Show("Thời lượng phải là số nguyên dương.");
                return;
            }

            if (cmbReporter.SelectedItem is PhongVien pv)
            {
                // Mặc định thêm vào bản tin đầu tiên nếu có
                if (manager.LayTatCaBanTin().Length == 0)
                {
                    MessageBox.Show("Chưa có bản tin nào để thêm phóng sự.");
                    return;
                }

                BanTin bt = manager.LayTatCaBanTin()[0]; // tạm cho vào bản tin đầu tiên
                PhongSu ps = new PhongSu(td, thoiLuong, pv);
                bt.DanhSachPhongSu.Add(ps);

                HienThiDanhSach();
                txtTitle.Clear();
                txtDuration.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReports.SelectedRows.Count > 0)
            {
                int rowIndex = dgvReports.SelectedRows[0].Index;
                int count = 0;

                foreach (BanTin bt in manager.LayTatCaBanTin())
                {
                    for (int i = 0; i < bt.DanhSachPhongSu.Count; i++)
                    {
                        if (count == rowIndex)
                        {
                            bt.DanhSachPhongSu.RemoveAt(i);
                            HienThiDanhSach();
                            return;
                        }
                        count++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn phóng sự cần xóa.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                XuLyFile.Luu("bantin.xml", manager);
                MessageBox.Show("Đã lưu dữ liệu (phóng sự) vào bantin.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // đóng ReportForm, quay lại MainForm
        }
    }
}
