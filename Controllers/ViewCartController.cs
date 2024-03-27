using Microsoft.AspNetCore.Mvc;

namespace Cake_Shope.Controllers
{
    public class ViewCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
