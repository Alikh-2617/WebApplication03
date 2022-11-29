using System.ComponentModel.DataAnnotations;

namespace WebApplication03.Models
{
    public class Language
    {
        [Key]
        public string Id { get; set; }

        public string  Name { get; set; }

        public DateTime Register { get; set; }

        public List<Person> People { get; set; } = new List<Person>();

    }
}
