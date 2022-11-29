using Microsoft.AspNetCore.Mvc;
using WebApplication03.Data;
using WebApplication03.Models;
using WebApplication03.ViewModels;

namespace WebApplication03.Controllers
{
    public class CityController : Controller
    {
        //// bara föratt kunna skicka data som ViewModel
        //private CityVM vm = new CityVM();
        //// Database connection
        //private readonly ApplicationDbContext _context;
        //public CityController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        //public IActionResult Index()
        //{
        //    vm.Cities = _context.Cities.ToList();
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
        //public IActionResult Edit(City city)
        //{
        //    ModelState.Remove("Register");
        //    if (ModelState.IsValid)
        //    {
        //        city.Register = DateTime.Now;
        //        _context.Cities.Update(city);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return NotFound();
        //}


        //public IActionResult Delete(string Id)
        //{
        //    var city = _context.Cities.FirstOrDefault(x => x.Id == Id);
        //    if (city != null)
        //    {
        //        _context.Cities.Remove(city);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return NotFound();
        //}
    }
}
