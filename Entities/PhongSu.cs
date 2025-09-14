using System;

namespace TVNewsManager.Entities
{
    [Serializable]
    public class PhongSu : BaseEntity
    {
        public string TieuDe { get; set; } = string.Empty;
        public int ThoiLuong { get; set; } // phút
        public PhongVien PhongVien { get; set; } = new PhongVien();

        public PhongSu() { } // constructor mặc định

        public PhongSu(string td, int tl, PhongVien pv)
        {
            TieuDe = td;
            ThoiLuong = tl;
            PhongVien = pv;
        }

        public override string ToString()
        {
            return $"{TieuDe} - {ThoiLuong} phút ({PhongVien?.HoTen})";
        }
    }
}
