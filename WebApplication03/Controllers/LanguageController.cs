using Microsoft.AspNetCore.Mvc;
using WebApplication03.Data;
using WebApplication03.Models;
using WebApplication03.ViewModels;

namespace WebApplication03.Controllers
{
    public class LanguageController : Controller
    {
        //private LanguageVM vm = new LanguageVM();
        //private readonly ApplicationDbContext _context;
        //public LanguageController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}


        //public IActionResult Index()
        //{
        //    vm.Languages = _context.Languages.ToList();
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
        //public IActionResult Edit(Language language)
        //{
        //    ModelState.Remove("Register");
        //    if (ModelState.IsValid)
        //    {
        //        language.Register = DateTime.Now;
        //        _context.Languages.Update(language);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return NotFound();
        //}


        //public IActionResult Delete(string Id)
        //{
        //    var language = _context.Languages.FirstOrDefault(x => x.Id == Id);
        //    if (language != null)
        //    {
        //        _context.Languages.Remove(language);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return NotFound();
        //}
    }
}
