using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication03.Data;
using WebApplication03.Models;

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
            people = _context.People.ToList();
            return people;
        }

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


    }
}
