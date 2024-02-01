using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebTest.Models.AccountVM
{
    public class RegisterAPI
    {
        public string? FullName { get; set; }

        public string? PasswordHash { get; set; }

        public string? ConfirmPassword { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }
        public string? Address { get; set; }

        public static implicit operator ApplicationUser(RegisterAPI vm)
        {
            return new ApplicationUser
            {
                UserName = vm.Email,
                IsAcitive = true,
                PhoneNumber = vm.PhoneNumber,
                Email = vm.Email,
                FullName = vm.FullName,
            };
        }
    }
}
