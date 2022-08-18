using Microsoft.AspNetCore.Identity;

namespace ForumWebApplication.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
