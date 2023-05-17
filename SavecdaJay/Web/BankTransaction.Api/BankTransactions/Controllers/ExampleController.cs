using BankTransactions.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankTransactions.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NamedView()
        {
            return View("MySuperView");
        }

        public IActionResult DataView()
        {
            ViewData["chaine1"] = "Voici une super chaine de caractères !";

            ViewBag.chaine2 = "Voilà une autre chaine, avec un chapeau !";

            return View();
        }

        public IActionResult ModelView()
        {
            BankTransaction transaction = new()
            {
                Transaction_Id = 22,
                Transaction_Date = DateTime.Now,
                Transaction_From = 23145698745,
                Transaction_To = 01234567890,
                Transaction_Amount = (decimal) 1000.45
            };
            return View(transaction);
        }
    }
}
