using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Nodes;
using WebApplication03.Data;
using WebApplication03.Models;
using Newtonsoft.Json;

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
            people = _context.People.Include(x => x.City).Include(y=>y.Languages).Include(j => j.City.Country).ToList();
            return people;
        }

        //[HttpGet]
        //[Route("{id}")]

        [HttpDelete("{id}")]
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
            // göra om den till Json
            Person personToCreate = JsonConvert.DeserializeObject<Person>(jsonPerson);
            personToCreate.Id = Guid.NewGuid().ToString();
            if (personToCreate != null)
            {
                _context.People.Add(personToCreate);
                _context.SaveChanges();
                return StatusCode(200);
            }
            return StatusCode(404);
        }


    }
}
