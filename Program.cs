using System;
using System.Windows.Forms;
using TVNewsManager.Entities;
using TVNewsManager.Services;

namespace TVNewsManager
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Tạo manager
            QuanLyBanTin manager = new QuanLyBanTin();

            // Seed 6 nhân sự
            PhongVien pv1 = new PhongVien("Nguyễn Văn A", "a@example.com", "0901111111");
            PhongVien pv2 = new PhongVien("Trần Thị B", "b@example.com", "0902222222");
            PhongVien pv3 = new PhongVien("Lê Văn C", "c@example.com", "0903333333");
            BienTapVien bt1 = new BienTapVien("Phạm Thị D", "d@example.com", "0914444444");
            BienTapVien bt2 = new BienTapVien("Hoàng Văn E", "e@example.com", "0915555555");
            BienTapVien bt3 = new BienTapVien("Đỗ Thị F", "f@example.com", "0916666666");

            manager.ThemNhanSu(pv1);
            manager.ThemNhanSu(pv2);
            manager.ThemNhanSu(pv3);
            manager.ThemNhanSu(bt1);
            manager.ThemNhanSu(bt2);
            manager.ThemNhanSu(bt3);

            // Seed 10 bản tin
            BanTin btin1 = new BanTin("Thời sự buổi sáng", TheLoai.ThoiSu);
            btin1.DanhSachPhongSu.Add(new PhongSu("Tin chính trị", 15, pv1));
            btin1.DanhSachPhongSu.Add(new PhongSu("Tin xã hội", 10, pv2));

            BanTin btin2 = new BanTin("Thể thao hôm nay", TheLoai.TheThao);
            btin2.DanhSachPhongSu.Add(new PhongSu("Bóng đá quốc tế", 20, pv1));
            btin2.DanhSachPhongSu.Add(new PhongSu("Điền kinh trong nước", 12, pv3));

            BanTin btin3 = new BanTin("Kinh tế tuần qua", TheLoai.KinhTe);
            btin3.DanhSachPhongSu.Add(new PhongSu("Thị trường chứng khoán", 18, pv2));
            btin3.DanhSachPhongSu.Add(new PhongSu("Xuất nhập khẩu", 14, pv3));

            BanTin btin4 = new BanTin("Văn hóa Việt Nam", TheLoai.VanHoa);
            btin4.DanhSachPhongSu.Add(new PhongSu("Lễ hội truyền thống", 16, pv1));
            btin4.DanhSachPhongSu.Add(new PhongSu("Di sản văn hóa", 12, pv2));

            BanTin btin5 = new BanTin("Giải trí cuối tuần", TheLoai.GiaiTri);
            btin5.DanhSachPhongSu.Add(new PhongSu("Âm nhạc trẻ", 14, pv3));
            btin5.DanhSachPhongSu.Add(new PhongSu("Điện ảnh Việt Nam", 18, pv2));

            BanTin btin6 = new BanTin("Khoa học công nghệ", TheLoai.KhoaHoc);
            btin6.DanhSachPhongSu.Add(new PhongSu("Phát minh mới", 15, pv1));
            btin6.DanhSachPhongSu.Add(new PhongSu("Công nghệ AI", 20, pv3));

            BanTin btin7 = new BanTin("Giáo dục hôm nay", TheLoai.GiaoDuc);
            btin7.DanhSachPhongSu.Add(new PhongSu("Đổi mới phương pháp học", 12, pv2));
            btin7.DanhSachPhongSu.Add(new PhongSu("Tuyển sinh đại học", 14, pv1));

            BanTin btin8 = new BanTin("Sức khỏe cộng đồng", TheLoai.SucKhoe);
            btin8.DanhSachPhongSu.Add(new PhongSu("Phòng chống dịch bệnh", 16, pv3));
            btin8.DanhSachPhongSu.Add(new PhongSu("Dinh dưỡng hợp lý", 10, pv2));

            BanTin btin9 = new BanTin("Thời tiết toàn quốc", TheLoai.ThoiTiet);
            btin9.DanhSachPhongSu.Add(new PhongSu("Dự báo miền Bắc", 8, pv1));
            btin9.DanhSachPhongSu.Add(new PhongSu("Dự báo miền Nam", 7, pv2));

            BanTin btin10 = new BanTin("Chính trị & pháp luật", TheLoai.ThoiSu);
            btin10.DanhSachPhongSu.Add(new PhongSu("Chính sách mới", 15, pv1));
            btin10.DanhSachPhongSu.Add(new PhongSu("Xử lý tham nhũng", 18, pv3));

            // Thêm vào manager
            manager.ThemBanTin(btin1);
            manager.ThemBanTin(btin2);
            manager.ThemBanTin(btin3);
            manager.ThemBanTin(btin4);
            manager.ThemBanTin(btin5);
            manager.ThemBanTin(btin6);
            manager.ThemBanTin(btin7);
            manager.ThemBanTin(btin8);
            manager.ThemBanTin(btin9);
            manager.ThemBanTin(btin10);

            // Chạy MainForm với dữ liệu demo
            Application.Run(new UI.MainForm(manager));
        }
    }
}
