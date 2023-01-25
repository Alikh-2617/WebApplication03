using Microsoft.AspNetCore.Identity;

namespace WebApplication03.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string EfterName { get; set; }
        public int Age { get; set; }
        public string? PicPath { get; set; }
        public DateTime Register { get; set; }
        public List <Person>? Anstallda { get; set; }
    }
}
