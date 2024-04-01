using CLDV6211_POE_Part1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace CLDV6211_POE_Part1.Controllers
{
    public class UserController1 : Controller
    {

        private static string con_string = "Server=tcp:cldv-sql-server-st10152431.database.windows.net,1433;Initial Catalog=CLDV_DB1;Persist Security Info=False;User ID=LouisFrancoisFourie;Password=Monkeys2002;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private static SqlConnection con = new SqlConnection(con_string);

        public IActionResult Index()
        {
            return View();
        }




        public Table_1 Table_1 = new Table_1();


        public ActionResult About(Table_1 Users)
        {
            var result = Table_1.insert_user(Users);
            return RedirectToAction("Home", "About");
        }

    }

}
