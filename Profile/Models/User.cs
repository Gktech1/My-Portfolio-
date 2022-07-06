using Microsoft.AspNetCore.Identity;

namespace Profile.Models
{
    public class User : IdentityUser
    {
       
        public string LastName { get; set; }
        public string FirstName { get; set; }

    }
}
