using Microsoft.AspNetCore.Mvc;

namespace JooneliTrading.Controllers
{
    public class FeaturesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
