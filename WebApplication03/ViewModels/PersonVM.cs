using WebApplication03.Models;

namespace WebApplication03.ViewModels
{
    public class PersonVM
    {
        public Person Person { get; set; }

        public List<Person> People { get; set; }

        public string Search { get; set; }

    }
}
