using Cake_Shope.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cake_Shope.Controllers
{
    public class ProductController2 : Controller
    {
        Products objmodel = new Products();
        public IActionResult Index()
        {
            objmodel = new Products();
            List<Products> lst = objmodel.getData().ToList();
            //lst.Where(data=>data.IMGid==2).ToList();

            return View(lst.Where(data => data.IMGid == 2).ToList());
        }
    }
}
