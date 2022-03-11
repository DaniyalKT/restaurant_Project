using Microsoft.AspNetCore.Identity;

namespace Mongo.Services.Identity.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}