using CerealsApi.Db;
using CerealsApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CerealsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CerealsController : ControllerBase
    {
        CerealsDbContext context;

        public CerealsController() : base()
        {
            context = new CerealsDbContext();
        }
        // GET: api/<CerealsController> 
        [HttpGet]
        public IEnumerable<Cereal> Get()
        {
            return context.Cereals.ToList();
        }

        // GET api/<CerealsController>/5
        [HttpGet("{id}")]
        public string Get(int id) // lecture des données
        {
            // UTILISER UNE EXPRESSION LAMBDA
            return "value";
        }

        // POST api/<CerealsController>
        [HttpPost]
        public void Post([FromBody] Cereal value) // ajout d'element
        {
            context.Cereals.Add(value);
            context.SaveChanges();
        }

        // PUT api/<CerealsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cereal value) // mise à jour element existant
        {
            context.Cereals.Update(value);
            context.SaveChanges();
        }

        // DELETE api/<CerealsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) // suppression de l'element
        {
            context.Cereals = context.Cereals.Delete();
            context.SaveChanges();
        }
    }
}
