using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication03.Data;
using WebApplication03.Models;
using WebApplication03.ViewModels;

namespace WebApplication03.Controllers
{
    public class PeopleController : Controller
    {
        // bara föratt kunna skicka data som ViewModel
        private PersonVM vm = new PersonVM();
        private readonly ApplicationDbContext _context;
        public PeopleController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View(_context.People.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Person person)
        {
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                person.Id = Guid.NewGuid().ToString();
                person.Register = DateTime.Now;
                _context.People.Add(person);
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
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Person person)
        {
            ModelState.Remove("Register");
            if (ModelState.IsValid)
            {
                person.Register = DateTime.Now;
                _context.People.Update(person);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Something wrong happend and we could not chenge the targel, try agan !";
            return View();
        }

        public IActionResult Delete(string Id)
        {
            var person = _context.People.FirstOrDefault(x => x.Id == Id);
            if (person != null)
            {
                _context.People.Remove(person);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        public IActionResult FetchLanguage(string id)
        {
            var person = _context.People.Include(x => x.Languages).FirstOrDefault(x => x.Id == id);
            ViewBag.Id = person.Id;
            ViewBag.Message1 = person.Name;
            ViewBag.Message3 = $"There is no language for him in the Database : {person.Name}";
            return View(person.Languages);
        }
        public IActionResult DeleteLanguage(string languageid, string personid)
        {
            var person = _context.People.Include(x => x.Languages).FirstOrDefault(x => x.Id == personid);
            var language = _context.Languages.Find(languageid);
            person.Languages.Remove(language);
            _context.SaveChanges();
            ViewBag.Message4 = "language deleted ! ";
            return View("FetchLanguage", person.Languages);
        }
        public IActionResult AddLanguage(string id)
        {
            var person = _context.People.FirstOrDefault(x => x.Id == id);
            ViewBag.Id = person.Id;
            ViewBag.Person = person.Name;
            ViewBag.Language = new SelectList(_context.Languages, "Id", "Name");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddLanguage(string languageId, string personId)
        {
            var person = _context.People.Include(x => x.Languages).FirstOrDefault(x => x.Id == personId);
            var language = _context.Languages.Find(languageId);
            if (!person.Languages.Any(x => x.Id == languageId))
            {
                person.Languages.Add(language);
                _context.SaveChanges();
            }
            else
            {
                ViewBag.Message = "Thaat person have this language !";
                ViewBag.Id = language.Id;
                ViewBag.Person = person.Name;
                ViewBag.Language = new SelectList(_context.Languages.Where(x => x.Id != languageId), "Id", "Name");
                return View();
            }
            return RedirectToAction("Index");
        }
    }
}
