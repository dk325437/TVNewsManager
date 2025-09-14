using System;

namespace TVNewsManager.Entities
{
    [Serializable]
    public abstract class NhanSu : BaseEntity
    {
        public string HoTen { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string SoDienThoai { get; set; } = string.Empty;

        public NhanSu() { }

        public NhanSu(string ten, string e, string sdt)
        {
            HoTen = ten;
            Email = e;
            SoDienThoai = sdt;
        }
    }
}
