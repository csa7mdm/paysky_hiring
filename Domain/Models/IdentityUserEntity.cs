using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class IdentityUserEntity : IdentityUser
    {
        // Additional properties or methods specific to your needs
        public User User { get; set; }
    }
}
