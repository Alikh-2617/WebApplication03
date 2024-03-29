﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Nodes;
using WebApplication03.Data;
using WebApplication03.Models;
using Newtonsoft.Json;
using System.Linq;

namespace WebApplication03.Controllers
{
    // end poin
    [Route("api/[controller]")]
    [ApiController]
    public class ReactController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ReactController(ApplicationDbContext context)
        {
            _context = context; 
        }



        [HttpGet]
        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();
            people = _context.People.Include(x => x.City).Include(y => y.Languages).Include(j => j.City.Country).ToList();
            //people = _context.People.Include(x => x.City).ToList();
            //people = _context.People.ToList();
            return people;
        }

        [HttpGet("city")]
        public List<City> GetCityes()
        {
            List<City> cities = new List<City>();
            cities = _context.Cities.ToList();
            // det går specificera vilka delar av city ska skickas också !
            return cities;
        }

        //[HttpGet]
        //[Route("{id}")]

        [HttpGet("{id}")]
        public IActionResult Deletet(string id)
        {
            var person = _context.People.Find(id);
            if(person == null)
            {
                return StatusCode(404);
            }
            _context.People.Remove(person);
            _context.SaveChanges();
            return StatusCode(200);
        }

        [HttpPost("create")]
        public IActionResult create(JsonObject person)
        {
            string jsonPerson = person.ToString();
            React reactObject = JsonConvert.DeserializeObject<React>(jsonPerson)!;

            //if(reactObject != null)
            //{
                Person personToCreate = new Person();
                personToCreate.Id = Guid.NewGuid().ToString();
                personToCreate.Name = reactObject.Name;
                personToCreate.Age = reactObject.age;
                personToCreate.PhoneNumber = reactObject.Phonenumber;
                personToCreate.PicPath = " ";
                personToCreate.Register = DateTime.Now;
                string cityId = reactObject.city;
                var city = _context.Cities.Find(cityId);
                if (city != null)
                {
                    personToCreate.City = city;
                    _context.People.Add(personToCreate);
                    _context.SaveChanges();
                    return StatusCode(200);
                }
                _context.People.Add(personToCreate);
                _context.SaveChanges();
                return StatusCode(202);
            //}

            //return StatusCode(404);
        }
    }
}
