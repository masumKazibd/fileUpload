using Microsoft.AspNetCore.Mvc;

namespace CRUD_image.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
