using System.ComponentModel.DataAnnotations;

namespace WebApplication03.Models
{
    public class Country
    {
        [Key]
        public string  Id { get; set; }

        public string  Name { get; set; }

        public DateTime Register { get; set; }

        public List<City> Cities { get; set; } = new List<City>();
    }
}
