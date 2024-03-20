using CLDV6211_POE_Part1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CLDV6211_POE_Part1.Controllers
{
    public class UserController1 : Controller
    {
        public Table_1 Table_1 = new Table_1();

        [HttpPost]

        public ActionResult About(Table_1 Users)
        {
            var result = Table_1.insert_user(Users);
            return RedirectToAction("Home", "About");
        }

        [HttpGet]
        public IActionResult Index() 
        {
            return View();
        }
    }
}
