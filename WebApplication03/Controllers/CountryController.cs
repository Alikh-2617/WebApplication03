﻿using Microsoft.AspNetCore.Mvc;
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
                return NotFound();
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
            return NotFound();
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
            var country = _context.Countries.Include(x => x.Cities).FirstOrDefault(x => x.Id == id);
            ViewBag.Id = country.Id;
            ViewBag.Message1 = country.Name;
            ViewBag.Message3 = $"there is no city for this country in Database !";
            return View(country.Cities);
        }
        public IActionResult DeleteCity(string countryid, string cityid)
        {
            var country = _context.Countries.Include(x => x.Cities).FirstOrDefault(x => x.Id == countryid);
            var city = _context.Cities.Find(cityid);
            country.Cities.Remove(city);
            _context.SaveChanges();
            ViewBag.Message4 = "city deleted ! ";
            return View("FetchCities", country.Cities);
        }
    }
}
