using Microsoft.AspNetCore.Identity;

namespace Task10JWT1.Moels
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
