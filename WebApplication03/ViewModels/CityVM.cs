using WebApplication03.Models;

namespace WebApplication03.ViewModels
{
    public class CityVM
    {
        public City City { get; set; }

        public List<City> Cities { get; set; }

        public string Search { get; set; }
    }
}
