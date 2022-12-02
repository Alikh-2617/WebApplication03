using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using WebApplication03.Data;
using WebApplication03.Models;
using WebApplication03.ViewModels;

namespace WebApplication03.Controllers
{
    public class CityController : Controller
    {
        // bara föratt kunna skicka data som ViewModel
        private CityVM vm = new CityVM();
        // Database connection
        private readonly ApplicationDbContext _context;
        public CityController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            vm.Cities = _context.Cities.ToList();
            return View(vm);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(City city)
        {
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                city.Id = Guid.NewGuid().ToString();
                city.Register = DateTime.Now;
                _context.Cities.Add(city);
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
        public IActionResult Edit(City city)
        {
            ModelState.Remove("Register");
            if (ModelState.IsValid)
            {
                city.Register = DateTime.Now;
                _context.Cities.Update(city);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Something wrong happend and we could not chenge the targel, try agan !";
            return View(); 
        }


        public IActionResult Delete(string Id)
        {
            var city = _context.Cities.FirstOrDefault(x => x.Id == Id);
            if (city != null)
            {
                _context.Cities.Remove(city);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        public IActionResult FetchPeople(string id)
        {
            var city = _context.Cities.Include(x => x.People).FirstOrDefault(x => x.Id == id);
            ViewBag.Id = city.Id;
            ViewBag.Message1 = city.Name;
            ViewBag.Message2 = city.PostNumber;
            ViewBag.Message3 = $"there is no person for this city in Database !";
            return View(city.People);
        }
        public IActionResult DeletePerson(string personid, string cityid)
        {
            var city = _context.Cities.Include(x => x.People).FirstOrDefault(x => x.Id == cityid);
            var person = _context.People.Find(personid);
            city.People.Remove(person);
            _context.SaveChanges();
            ViewBag.Message4 = "Person deleted ! ";
            return View("FetchPeople", city.People);
        }

        public IActionResult AddPeople(string id)
        {
            var city = _context.Cities.FirstOrDefault(x => x.Id == id);
            ViewBag.Id = city.Id;
            ViewBag.City = city.Name;
            ViewBag.People = new SelectList(_context.People, "Id", "Name");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPeople(string cityId, string personId)
        {
            var city = _context.Cities.Include(x => x.People).FirstOrDefault(x => x.Id == cityId);
            var person = _context.People.Find(personId);
            if (!city.People.Any(x => x.Id == personId))
            {
                city.People.Add(person);
                _context.SaveChanges();
            }
            else
            {
                ViewBag.Message = "That person living in this City !";
                ViewBag.Id = city.Id;
                ViewBag.City = city.Name;
                ViewBag.People = new SelectList(_context.People.Where(x => x.Id != personId), "Id", "Name");
                return View();
            }
            return RedirectToAction("Index");
        }
    }
}
