using System;

namespace TVNewsManager.Entities
{
    [Serializable]
    public class PhongVien : NhanSu
    {
        public PhongVien() { } // bắt buộc cho XmlSerializer

        public PhongVien(string ten, string e, string sdt) : base(ten, e, sdt) { }

        public override string ToString()
        {
            return $"Phóng viên: {HoTen}";
        }
    }
}
