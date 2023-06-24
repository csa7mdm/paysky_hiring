using Microsoft.AspNetCore.Identity;

namespace Domain.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() {}

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public ICollection<Application> Applications { get; set; }
    }
}