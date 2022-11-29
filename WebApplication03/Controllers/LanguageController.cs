using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication03.Data;
using WebApplication03.Models;
using WebApplication03.ViewModels;

namespace WebApplication03.Controllers
{
    public class LanguageController : Controller
    {
        private LanguageVM vm = new LanguageVM();
        private readonly ApplicationDbContext _context;
        public LanguageController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            vm.Languages = _context.Languages.ToList();
            return View(vm);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Language language)
        {
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                language.Id = Guid.NewGuid().ToString();
                language.Register = DateTime.Now;
                _context.Languages.Add(language);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Somethings wrong ! tray again leater !";
            return View();
        }

        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Language language)
        {
            ModelState.Remove("Register");
            if (ModelState.IsValid)
            {
                language.Register = DateTime.Now;
                _context.Languages.Update(language);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }


        public IActionResult Delete(string Id)
        {
            var language = _context.Languages.FirstOrDefault(x => x.Id == Id);
            if (language != null)
            {
                _context.Languages.Remove(language);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
        public IActionResult FetchPeople(string id)
        {
            var language = _context.Languages.Include(x => x.People).FirstOrDefault(x => x.Id == id);
            ViewBag.Id = language.Id;
            ViewBag.Message1 = language.Name;
            ViewBag.Message3 = $"there is no people for this language in Database: {language.Name}";
            return View(language.People);
        }
        public IActionResult DeletePerson(string personid, string languageid)
        {
            var language = _context.Languages.Include(x => x.People).FirstOrDefault(x => x.Id == languageid);
            var person = _context.People.Find(personid);
            language.People.Remove(person);
            _context.SaveChanges();
            ViewBag.Message4 = "person deleted ! ";
            return View("FetchPeople", language.People);
        }
    }
}
