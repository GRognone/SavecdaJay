using ApiBankTransactionDbContext;
using ApiBankTransactionModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<ActionResult<IEnumerable<BankTransaction>>> GetTransactions()
        {
            if (_context.BankTransactions == null)
            {
                return NotFound();
            }
            return _context.BankTransactions;
        }

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
                TransactionFrom = banktransact.TransactionFrom,
                TransactionTo = banktransact.TransactionTo,
                TransactionAmount = banktransact.TransactionAmount
            };
        }
        // POST: api/Transaction
        [HttpPost]
        public async Task<ActionResult<BankTransaction>>PostTransaction(BankTransaction Btransact)
        {
            if (_context.BankTransactions == null)
            {
                return Problem("Entity set 'BankTransactionDbContext.BankTransactions' is null.");
            }
            _context.BankTransactions.Add(Btransact);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser")
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
                dbBankTransact.TransactionFrom = bankTransaction.TransactionFrom;
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
                if (!BankTransactionExists(id))
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

        private bool BankTransactionExists(int id)
        {
            throw new NotImplementedException();
        }
    }
}
