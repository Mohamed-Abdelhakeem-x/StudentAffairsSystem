using Microsoft.AspNetCore.Identity;

namespace StudentAffairs.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int? StudentYear { get; set; }
    }
}