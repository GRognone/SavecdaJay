using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bdd;
using Domain;

namespace APIWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : Controller
    {
        private readonly BddContext _context;



        public CitiesController()
        {
            _context = new BddContext() ;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<City>>> GetCities() => (_context.Cities is not null) ? _context.Cities : NotFound();


        [HttpPost]
        public async Task<ActionResult<City>> Post(City c)
        {
            if (_context == null)
            {
                return Problem();
            }
            _context.Cities.Add(c);
            await _context.SaveChangesAsync();
            return Created("city",c);
        }

        [HttpPut]
        public async Task<ActionResult> Put(int id, City c) 
        {
            // VERIFIER LE CONTEXTE (PAS NULL)
            if(_context == null)
            {
                return Problem();
            }
            // VERIFIER SI L'IDENTIFIANT EXISTE DANS LA TABLE
            City? tmp = _context.Cities.FirstOrDefault(d => d.Id == id);
            if (tmp is not City)
            {
                return NotFound();
            }
            tmp.Name = c.Name;
            tmp.Countrycode = c.Countrycode;
            tmp.Code = c.Code;
            _context.Entry(tmp).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            } catch(DbUpdateConcurrencyException e)
            {
                return NotFound();
            }
            return NoContent();            
            // FAIRE LA MODIFICATION SI IL EXISTE

        }
    }
}
