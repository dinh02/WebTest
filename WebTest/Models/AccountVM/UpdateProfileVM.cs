namespace WebTest.Models.AccountVM
{
    public class UpdateProfileVM
    {
        
        public IFormFile? AvatarFile { get; set; }

        public string? FullName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? PasswordNew { get; set; }
        public string? RePasswordNew { get; set; }

        public string? roleName { get; set; }
        public string? Address { get; set; }
        public int SalesCommissions { get; set; }
    }
}
