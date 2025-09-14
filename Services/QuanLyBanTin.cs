using System;
using TVNewsManager.Entities;
using TVNewsManager.Collections;

namespace TVNewsManager.Services
{
    [Serializable]
    public class QuanLyBanTin
    {
        public MyList<BanTin> DanhSachBanTin { get; set; } = new MyList<BanTin>();
        public MyList<NhanSu> DanhSachNhanSu { get; set; } = new MyList<NhanSu>();

        public QuanLyBanTin() { }

        // Thêm bản tin
        public void ThemBanTin(BanTin bt)
        {
            DanhSachBanTin.Add(bt);
        }

        // Xóa bản tin
        public void XoaBanTin(int index)
        {
            DanhSachBanTin.RemoveAt(index);
        }

        // Thêm nhân sự
        public void ThemNhanSu(NhanSu ns)
        {
            DanhSachNhanSu.Add(ns);
        }

        // Xóa nhân sự
        public void XoaNhanSu(int index)
        {
            DanhSachNhanSu.RemoveAt(index);
        }

        // Lấy tất cả bản tin
        public BanTin[] LayTatCaBanTin()
        {
            return DanhSachBanTin.ToArray();
        }

        // Lấy tất cả nhân sự
        public NhanSu[] LayTatCaNhanSu()
        {
            return DanhSachNhanSu.ToArray();
        }
    }
}
