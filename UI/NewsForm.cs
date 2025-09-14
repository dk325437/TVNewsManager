using System;
using System.Windows.Forms;
using TVNewsManager.Entities;
using TVNewsManager.Services;

namespace TVNewsManager.UI
{
    public partial class NewsForm : Form
    {
        private QuanLyBanTin manager;

        public NewsForm(QuanLyBanTin ql)
        {
            InitializeComponent();
            manager = ql;
        }

        private void NewsForm_Load(object sender, EventArgs e)
        {
            // Đổ dữ liệu enum TheLoai vào ComboBox
            cmbCategory.DataSource = Enum.GetValues(typeof(TheLoai));

            // Hiển thị dữ liệu hiện có
            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            dgvNews.Rows.Clear();
            foreach (BanTin bt in manager.LayTatCaBanTin())
            {
                dgvNews.Rows.Add(bt.TieuDe, bt.TheLoai, bt.DanhSachPhongSu.Count);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string td = txtTitle.Text.Trim();
            if (td == "")
            {
                MessageBox.Show("Vui lòng nhập tiêu đề.");
                return;
            }

            TheLoai tl = (TheLoai)cmbCategory.SelectedItem;
            BanTin bt = new BanTin(td, tl);
            manager.ThemBanTin(bt);

            HienThiDanhSach();
            txtTitle.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvNews.SelectedRows.Count > 0)
            {
                int index = dgvNews.SelectedRows[0].Index;
                manager.XoaBanTin(index);
                HienThiDanhSach();
            }
            else
            {
                MessageBox.Show("Chọn bản tin cần xóa.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                XuLyFile.Luu("bantin.xml", manager);
                MessageBox.Show("Đã lưu dữ liệu ra file bantin.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng NewsForm, MainForm sẽ hiện lại
        }

    }
}
