using System;
using TVNewsManager.Collections;

namespace TVNewsManager.Entities
{
    [Serializable]
    public class LichPhatSong : BaseEntity
    {
        public DateTime NgayPhat { get; set; }
        public MyList<BanTin> DanhSachBanTin { get; set; } = new MyList<BanTin>();

        public LichPhatSong() { }

        public LichPhatSong(DateTime ngay)
        {
            NgayPhat = ngay;
        }

        public override string ToString()
        {
            return $"Lịch {NgayPhat.ToShortDateString()} - {DanhSachBanTin.Count} bản tin";
        }
    }
}
