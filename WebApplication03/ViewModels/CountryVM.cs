using WebApplication03.Models;

namespace WebApplication03.ViewModels
{
    public class CountryVM
    {
        public Country Country { get; set; }

        public List<Country> Countries { get; set; }

        public string  Search { get; set; }
    }
}
