using Cake_Shope.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Cake_Shope.Controllers
{
    
    public class RegisterController : Controller
    {
        UserDetails logObj = new UserDetails();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserDetails model)
        {
            logObj = new UserDetails();
            logObj.insert(model);
            return View(model);
        }
    }
}
