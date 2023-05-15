using BankTransactions.DataBase;
using BankTransactions.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BankTransactions.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private BankDbContext context;

        public TransactionController()
        {
            context = new();
        }
        [HttpGet]
        public ActionResult<IEnumerable<BankTransaction>> GetAll()
        {
            if (context.Transactions == null)
            {
                return NoContent();
            }
            return context.Transactions.ToList();

        }

        [HttpPost]
        public async Task<ActionResult<BankTransaction>> Post(BankTransaction transaction)
        {
            //context.Transactions.Add(transaction);
            if (transaction.Transaction_From == transaction.Transaction_To)
            {
                return BadRequest("Les comptes doivent être differents !");
            }
            EntityEntry<BankTransaction> entry = context.Add(transaction);

            BankTransaction newItem = entry.Entity;

            await context.SaveChangesAsync();

            return newItem;
        }
        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            BankTransaction? dbItem = await context.Transactions.FirstOrDefaultAsync(t => t.Transaction_Id == id);

            if (dbItem is BankTransaction)
            {
                context.Remove(dbItem);
                await context.SaveChangesAsync();
                return NoContent(); // HTTP CODE 204 (pas de contenu à renvoyer)
            }
            return NotFound(); // HTTP CODE 404 (url incorrecte)
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BankTransaction>> Get(int id)
        {
            BankTransaction? dbItem = await context.Transactions.FirstOrDefaultAsync(t => t.Transaction_Id == id);
            if (dbItem is BankTransaction)
            {
                return dbItem; // HTTP CODE 200 (pas de contenu à renvoyer)
            }
            return NotFound(); // HTTP CODE 404 (url incorrecte)
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<BankTransaction>> Put (int id, BankTransaction transaction)
        {
            {
                return NotFound("La mise à jour de la transaction est impossible");
            }
        }
    }
}
