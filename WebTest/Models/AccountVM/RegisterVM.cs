using System.ComponentModel.DataAnnotations;

namespace WebTest.Models.AccountVM
{
    public class RegisterVM
    {
        [Display(Name = "Tài khoản")]
        public string? UserName { get; set; }
        public string? FullName { get; set; }

        [Display(Name = "Mã giới thiệu")]
        public string? Invite { get; set; }

        [Display(Name = "Mật Khẩu")]
        public string? PasswordHash { get; set; }

        [Display(Name = "Xác nhận mật khẩu")]
        public string? ConfirmPassword { get; set; }


        public string? PhoneNumber { get; set; }
        
        public string? Email { get; set; }
        public string? Address { get; set; }
        public DateTime CreateDate { get; set; }
        public int SalesCommissions { get; set; }



        public static implicit operator ApplicationUser(RegisterVM vm)
        {
            return new ApplicationUser
            {
                UserName = vm.UserName,
                IsAcitive = true,
                PhoneNumber = vm.PhoneNumber,
                Email = vm.Email,
                FullName = vm.FullName,
            };
        }
    }
}
