using ApiBankTransactionDbContext;
using ApiBankTransactionModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace ApiBankTransaction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly BankTransactionDbContext _context;

        public TransactionController()
        {
            _context = new BankTransactionDbContext();
        }

        //GET : api/Transactions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BankTransaction>>> GetTransactions() => (_context.BankTransactions is not null) ? _context.BankTransactions : NotFound();
        //{
        //    if (_context.BankTransactions == null)
        //    {
        //        return NotFound();
        //    }
        //    return _context.BankTransactions;
        //}

        //GET : api/Ransactions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BankTransaction>> GetTransaction(int id)
        {
            if (_context.BankTransactions == null)
            {
                return NotFound();
            }
            var banktransact = await _context.BankTransactions.FindAsync(id);

            if (banktransact == null)
            {
                return NotFound();
            }
            return new BankTransaction()
            {
                Id = banktransact.Id,
                Transaction_From = banktransact.Transaction_From,
                Transaction_To = banktransact.Transaction_To,
                Transaction_Amount = banktransact.Transaction_Amount
            };
        }
        // POST: api/Transaction
        [HttpPost]
        public async Task<ActionResult<BankTransaction>> PostTransaction(BankTransaction Btransact)
        {
            if (_context.BankTransactions == null)
            {
                return Problem("Entity set 'BankTransactionDbContext.BankTransactions' is null.");
            }
            _context.BankTransactions.Add(Btransact);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTransaction", new { id = Btransact.Id }, Btransact);
        }

        //PUT api/BankTransaction/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutBankTransaction(int id, BankTransaction bankTransaction)
        {
            if (id != bankTransaction.Id)
            {
                return BadRequest();
            }
            BankTransaction dbBankTransact = _context.BankTransactions.FirstOrDefault(btrans => btrans.Id == id);

            if (dbBankTransact is BankTransaction)
            {
                dbBankTransact.Transaction_From = bankTransaction.Transaction_From;
            }
            else
            {
                return NotFound();
            }

            _context.Entry(dbBankTransact).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BankTransactExist(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        // DELETE : api/BankTransaction/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteBankTransaction(int id)
        {
            if (_context.BankTransactions == null)
            {
                return NotFound();
            }
            var banktransact = await _context.BankTransactions.FindAsync(id);
            if (banktransact == null)
            {
                return NotFound();
            }
            _context.BankTransactions.Remove(banktransact);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BankTransactExist(int id)
        {
            return (_context.BankTransactions?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

