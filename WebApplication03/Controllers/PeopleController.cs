using Microsoft.AspNetCore.Mvc;
using WebApplication03.Data;
using WebApplication03.Models;
using WebApplication03.ViewModels;

namespace WebApplication03.Controllers
{
    public class PeopleController : Controller
    {
        //// bara föratt kunna skicka data som ViewModel
        //private PersonVM vm = new PersonVM();
        //// Database connection
        //private readonly ApplicationDbContext _context;
        //public PeopleController(ApplicationDbContext context)
        //{
        //    _context = context; 
        //}

        //public IActionResult Index()
        //{
        //    vm.People = _context.People.ToList();
        //    return View(vm);
        //}

        //public IActionResult Create()
        //{
        //    return View();
        //}

        //public IActionResult Edit(string id)
        //{
        //    if(id == null)
        //    {
        //        return NotFound();
        //    }
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit(Person person)
        //{
        //    ModelState.Remove("Register");
        //    if (ModelState.IsValid)
        //    {
        //        person.Register = DateTime.Now;
        //        _context.People.Update(person);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return NotFound();
        //}

        //public IActionResult Delete(string Id)
        //{
        //    var person = _context.People.FirstOrDefault(x => x.Id == Id);
        //    if (person != null)
        //    {
        //        _context.People.Remove(person);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return NotFound();
        //}

    }
}
