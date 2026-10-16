using System;

namespace LabEquipmentCheckout
{
    public class EquipmentTicket
    {
        public string MaPhieu { get; set; }
        public string MaSV { get; set; }
        public string HoTenSV { get; set; }
        public string ThietBi { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }
        public DateTime? NgayTraThucTe { get; set; }
        public string TrangThai { get; set; } // Đang mượn, Đã trả, Quá hạn
    }
}