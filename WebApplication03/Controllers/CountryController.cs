using Microsoft.AspNetCore.Mvc;
using WebApplication03.Data;
using WebApplication03.Models;
using WebApplication03.ViewModels;

namespace WebApplication03.Controllers
{
    public class CountryController : Controller
    {
        //private CountryVM vm = new CountryVM();
        //private readonly ApplicationDbContext _context;
        //public CountryController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        //public IActionResult Index()
        //{
        //    vm.Countries = _context.Countries.ToList();
        //    return View(vm);
        //}

        //public IActionResult Create()
        //{
        //    return View();
        //}

        //public IActionResult Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit(Country country)
        //{
        //    ModelState.Remove("Register");
        //    if (ModelState.IsValid)
        //    {
        //        country.Register = DateTime.Now;
        //        _context.Countries.Update(country);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return NotFound();
        //}

        //public IActionResult Delete(string Id)
        //{
        //    var country = _context.Countries.FirstOrDefault(x => x.Id == Id);
        //    if (country != null)
        //    {
        //        _context.Countries.Remove(country);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return NotFound();
        //}
    }
}
