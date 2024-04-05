using CLDV6211_POE_Part1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace CLDV6211_POE_Part1.Controllers
{
    public class UserController : Controller
    {

        public Table_1 usrtbl = new Table_1();



        [HttpPost]
        public ActionResult Contact(Table_1 Users)
        {
            var result = usrtbl.insert_User(Users);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View(usrtbl);
        }


    }

}

