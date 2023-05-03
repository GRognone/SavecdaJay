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
        Repository<Cereal> repository;

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
        public Cereal? Get(int id)
        {
            return context.Cereals.FirstOrDefault(c => c.CerealId == id);
        }

        ////    //est équivalent à ceci
        //public Cereal? Get(int id) => context.Cereals.FirstOrDefault(c => c.CerealId == id);// lecture des données


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
            if (this.Get(id) is Cereal cereal && value.CerealId == cereal.CerealId)
            {
                cereal.Name = value.Name;
                cereal.Calories = value.Calories;
                cereal.Protein = value.Protein;
                context.Cereals.Update(cereal);
                context.SaveChanges();
            }

        }

        // DELETE api/<CerealsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) // suppression de l'element
        {
            if (this.Get(id) is Cereal cereal)
            {
                context.Cereals.Remove(cereal);
                context.SaveChanges();
            }
        }
    }
}
