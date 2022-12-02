using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication03.Data;
using WebApplication03.Models;
using WebApplication03.ViewModels;

namespace WebApplication03.Controllers
{
    public class CountryController : Controller
    {
        private CountryVM vm = new CountryVM();
        private readonly ApplicationDbContext _context;
        public CountryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            vm.Countries = _context.Countries.ToList();
            return View(vm);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Country country)
        {
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                country.Id = Guid.NewGuid().ToString();
                country.Register = DateTime.Now;
                _context.Countries.Add(country);
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
        public IActionResult Edit(Country country)
        {
            ModelState.Remove("Register");
            if (ModelState.IsValid)
            {
                country.Register = DateTime.Now;
                _context.Countries.Update(country);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Something wrong happend and we could not chenge the targel, try agan !";
            return View();
        }

        public IActionResult Delete(string Id)
        {
            var country = _context.Countries.FirstOrDefault(x => x.Id == Id);
            if (country != null)
            {
                _context.Countries.Remove(country);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        public IActionResult FetchCities(string id)
        {
            var country = _context.Countries.Include(x => x.cities).FirstOrDefault(x => x.Id == id);
            ViewBag.Id = country.Id;
            ViewBag.Message1 = country.Name;
            ViewBag.Message3 = $"there is no city for this country in Database !";
            return View(country.cities);
        }
        public IActionResult DeleteCity(string countryid, string cityid)
        {
            var country = _context.Countries.Include(x => x.cities).FirstOrDefault(x => x.Id == countryid);
            var city = _context.Cities.Find(cityid);
            country.cities.Remove(city);
            _context.SaveChanges();
            ViewBag.Message4 = "city deleted ! ";
            return View("FetchCities", country.cities);
        }

        public IActionResult AddCity(string id)
        {
            var country = _context.Countries.FirstOrDefault(x => x.Id == id);
            ViewBag.Id = country.Id;
            ViewBag.Country = country.Name;
            ViewBag.City = new SelectList(_context.Cities, "Id", "Name");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCity(string cityId, string countryId)
        {
            var country = _context.Countries.Include(x => x.cities).FirstOrDefault(x => x.Id == countryId);
            var city = _context.Cities.Find(cityId);
            if (!country.cities.Any(x => x.Id == cityId))
            {
                country.cities.Add(city);
                _context.SaveChanges();
            }
            else
            {
                ViewBag.Message = "Thais city exist in this country !";
                ViewBag.Id = country.Id;
                ViewBag.City = country.Name;
                ViewBag.City = new SelectList(_context.Cities.Where(x => x.Id != cityId), "Id", "Name");
                return View();
            }
            return RedirectToAction("Index");
        }
    }
}
