using Microsoft.AspNetCore.Identity;

namespace Domain.Models
{
    public class User:BaseEntity
    {
        public User()
        {
            
        }
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public ICollection<Application> Applications { get; set; }
    }
}