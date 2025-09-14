using System;

namespace TVNewsManager.Entities
{
    [Serializable]
    public class BienTapVien : NhanSu
    {
        public BienTapVien() { } // constructor mặc định

        public BienTapVien(string ten, string e, string sdt) : base(ten, e, sdt) { }

        public override string ToString()
        {
            return $"Biên tập viên: {HoTen}";
        }
    }
}
