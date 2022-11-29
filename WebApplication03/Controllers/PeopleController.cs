using Microsoft.AspNetCore.Mvc;
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
            vm.People = _context.People.ToList();
            return View(vm);
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
                return NotFound();
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
            return NotFound();
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
    }
}
