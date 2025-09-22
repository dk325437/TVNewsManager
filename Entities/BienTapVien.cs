using System;

namespace TVNewsManager.Entities
{
    // Lớp Biên tập viên kế thừa từ lớp NhanSu
    // Có thể đại diện cho nhân sự cụ thể trong hệ thống
    [Serializable]
    public class BienTapVien : NhanSu
    {
        // Constructor mặc định (không tham số)
        public BienTapVien() { }

        // Constructor có tham số: khởi tạo Biên tập viên với tên, email và số điện thoại
        // Gọi constructor của lớp cha (NhanSu) thông qua từ khóa base
        public BienTapVien(string ten, string e, string sdt) : base(ten, e, sdt) { }

        // Ghi đè phương thức ToString() để hiển thị thông tin biên tập viên
        public override string ToString()
        {
            return $"Biên tập viên: {HoTen}";
        }
    }
}
