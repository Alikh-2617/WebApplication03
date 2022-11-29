using WebApplication03.Models;

namespace WebApplication03.ViewModels
{
    public class LanguageVM
    {
        public Language Language { get; set; }

        public List<Language> Languages { get; set; }

        public string Search { get; set; }
    }
}
