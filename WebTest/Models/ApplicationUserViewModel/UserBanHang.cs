namespace WebTest.Models.ApplicationUserViewModel
{
    public class UserBanHang
    {
        public string UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int ChienDichId { get; set; }
        public string ChienDichName { get; set; }
        public string BuoiMuaHangId { get; set; }
        public string BuoiMuaHangName { get; set; }
        public string CtvId { get; set; }
        public string CtvName { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string DonHangName { get; set; }
        public string? PhieuThuName { get; set; }
        public string SanPhamDaKichHoat { get; set; }
        public DateTime DateActive { get; set; }
        public int Type { get; set; }
        public int Price { get; set; }
        public string MaDonHang { set; get; }
        public string NPrice { get; set; }
        public string DanhSachIdKhoaHoc { get; set; }
    }
}
