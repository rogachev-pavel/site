using Microsoft.AspNetCore.Mvc;

namespace AutoGlassMarket.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Автостекла32 - быстрая замена стекл вашего авто";
            return View();
        }
    }
}
