using Microsoft.AspNetCore.Identity;

namespace WebTest.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? AvatartPath { get; set; }
        public string? FullName { get; set; }
        public string? Address { get; set; }
        public string? GetRole { get; set; }
        public bool IsAcitive { get; set; }
        public DateTime CreateDate { get; set; }
        public string? Atributted { get; set; }
        public int SalesCommissions { get; set; } = 0;
    }
}
