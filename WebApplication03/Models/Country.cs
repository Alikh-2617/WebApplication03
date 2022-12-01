using System.ComponentModel.DataAnnotations;

namespace WebApplication03.Models
{
    public class Country
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public DateTime Register { get; set; }

        public List<City> cities { get; set; } = new List<City>();

    }
}
