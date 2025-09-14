using System;
using System.Windows.Forms;
using TVNewsManager.Entities;
using TVNewsManager.Services;

namespace TVNewsManager.UI
{
    public partial class PersonForm : Form
    {
        private QuanLyBanTin manager;

        public PersonForm(QuanLyBanTin ql)
        {
            InitializeComponent();
            manager = ql;
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {
            cmbType.Items.Clear();
            cmbType.Items.Add("Phóng viên");
            cmbType.Items.Add("Biên tập viên");
            cmbType.SelectedIndex = 0;

            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            dgvPersons.Rows.Clear();
            foreach (NhanSu ns in manager.LayTatCaNhanSu())
            {
                string loai = ns is PhongVien ? "Phóng viên" : "Biên tập viên";
                dgvPersons.Rows.Add(ns.HoTen, ns.Email, ns.SoDienThoai, loai);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ten = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (ten == "" || email == "" || phone == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            NhanSu ns;
            if (cmbType.SelectedItem.ToString() == "Phóng viên")
                ns = new PhongVien(ten, email, phone);
            else
                ns = new BienTapVien(ten, email, phone);

            manager.ThemNhanSu(ns);

            HienThiDanhSach();

            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPersons.SelectedRows.Count > 0)
            {
                int index = dgvPersons.SelectedRows[0].Index;
                manager.XoaNhanSu(index);
                HienThiDanhSach();
            }
            else
            {
                MessageBox.Show("Chọn nhân sự để xóa.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                XuLyFile.Luu("nhansu.xml", manager);
                MessageBox.Show("Đã lưu danh sách nhân sự vào nhansu.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // quay lại MainForm
        }
    }
}
