using System.ComponentModel;


namespace WebTest.Models.ApplicationUserViewModel
{
    public class ApplicationUserViewModel
    {
        public string Id { get; set; }
        [DisplayName("Họ tên")]
        public string FullName { get; set; }
        [DisplayName("Ảnh đại diện")]
        public string AvatartPath { get; set; }
        public string Atributted { get; set; }
        public string UserName { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Số điện thoại")]
        public string PhoneNumber { get; set; }
        [DisplayName("Địa chỉ")]
        public string Address { get; set; }
        [DisplayName("Mật khẩu")]
        public string Password { get; set; }

        [DisplayName("Tag")]
        public string TagId { get; set; }

        [DisplayName("Nhóm")]
        public string GroupId { get; set; }

        public DateTime CreateDate { get; set; }
        [DisplayName("Ảnh đại diện")]
        public IFormFile? AvatarFile { get; set; }
        public int CountCourse { get; set; }
        public int CountTag { get; set; }
        public int CountGroup { get; set; }
        public int CountCertificat { get; set; }
        public DateTime? LastLogin { get; set; }
       
        public List<Paymment>? ListPaymment { get; set; }


        public static implicit operator ApplicationUser(ApplicationUserViewModel item)
        {
            return new ApplicationUser
            {
                Id = item.Id,
                UserName = item.Email,
                Email = item.Email,
                AvatartPath = item.AvatartPath ?? "",
                FullName = item.FullName,
                Address = item.Address,
                Atributted = item.Atributted ?? "",
                IsAcitive = true,
                CreateDate = item.CreateDate,
                PhoneNumber = item.PhoneNumber,
            };
        }

        public static implicit operator ApplicationUserViewModel(ApplicationUser item)
        {
            return new ApplicationUserViewModel
            {
                Id = item.Id,
                UserName = item.UserName,
                Email = item.Email,
                AvatartPath = item.AvatartPath,
                FullName = item.FullName,
                Address = item.Address,
                Atributted = item.Atributted,
                CreateDate = item.CreateDate,
                PhoneNumber = item.PhoneNumber,
            };
        }


    }
}
