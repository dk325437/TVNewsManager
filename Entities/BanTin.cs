using System;
using TVNewsManager.Collections;

namespace TVNewsManager.Entities
{
    [Serializable]
    public class BanTin : BaseEntity
    {
        public string TieuDe { get; set; } = string.Empty;
        public TheLoai TheLoai { get; set; }
        public MyList<PhongSu> DanhSachPhongSu { get; set; } = new MyList<PhongSu>();

        public BanTin() { }

        public BanTin(string td, TheLoai tl)
        {
            TieuDe = td;
            TheLoai = tl;
        }

        public int TongThoiLuong()
        {
            int tong = 0;
            foreach (PhongSu ps in DanhSachPhongSu)
            {
                tong += ps.ThoiLuong;
            }
            return tong;
        }

        public override string ToString()
        {
            return $"{TieuDe} ({TheLoai}) - {DanhSachPhongSu.Count} phóng sự";
        }
    }
}
