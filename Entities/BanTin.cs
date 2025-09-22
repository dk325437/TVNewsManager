using System;
using TVNewsManager.Collections;

namespace TVNewsManager.Entities
{
    // Đánh dấu lớp có thể tuần tự hóa (serialize), giúp lưu trữ/đọc đối tượng ra file, database,...
    [Serializable]
    public class BanTin : BaseEntity  // Kế thừa từ BaseEntity (có thể chứa các thuộc tính chung như Id, NgàyTạo,...)
    {
        // Tiêu đề bản tin
        public string TieuDe { get; set; } = string.Empty;

        // Thể loại của bản tin (ví dụ: Thể thao, Thời sự, Giải trí...)
        public TheLoai TheLoai { get; set; }

        // Danh sách phóng sự thuộc bản tin, dùng MyList (cấu trúc danh sách tùy chỉnh, thay cho List<T>)
        public MyList<PhongSu> DanhSachPhongSu { get; set; } = new MyList<PhongSu>();

        // Constructor mặc định (không tham số) – cần thiết cho việc khởi tạo rỗng hoặc deserialize
        public BanTin() { }

        // Constructor có tham số: khởi tạo bản tin với tiêu đề và thể loại
        public BanTin(string td, TheLoai tl)
        {
            TieuDe = td;
            TheLoai = tl;
        }

        // Tính tổng thời lượng của tất cả phóng sự trong bản tin
        public int TongThoiLuong()
        {
            int tong = 0;
            foreach (PhongSu ps in DanhSachPhongSu) // duyệt qua từng phóng sự
            {
                tong += ps.ThoiLuong; // cộng dồn thời lượng
            }
            return tong;
        }

        // Ghi đè phương thức ToString() để hiển thị bản tin dưới dạng chuỗi
        // Ví dụ: "Thời sự 19h (Thời sự) - 3 phóng sự"
        public override string ToString()
        {
            return $"{TieuDe} ({TheLoai}) - {DanhSachPhongSu.Count} phóng sự";
        }
    }
}
