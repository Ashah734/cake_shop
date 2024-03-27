using Microsoft.AspNetCore.Mvc;
using Cake_Shope.Models;
namespace Cake_Shope.Controllers
{
    public class Product1 : Controller
    {
        Products objmodel = new Products();
        public IActionResult Index()
        {
            objmodel = new Products();
            List<Products> lst = objmodel.getData();
            return View(lst.Where(data => data.IMGid == 1).ToList());
        }
    }
}
