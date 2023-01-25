using System.ComponentModel.DataAnnotations;

namespace WebApplication03.Models
{
    public class Person
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string PhoneNumber { get; set; }

        public string PicPath { get; set; }

        public DateTime Register { get; set; }

        public City? City { get; set; }

        public ApplicationUser? Chef { get; set; }

        public List<Language> Languages { get; set; } = new List<Language>();
    }
}
