using Cake_Shope.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cake_Shope.Controllers
{
    public class CakeDetailController : Controller
    {
        Products objmodel = new Products();
        public IActionResult Index()
        {
            objmodel = new Products();
            List<Products> lst = objmodel.getData();
            return View(lst);
        }
    }




}
