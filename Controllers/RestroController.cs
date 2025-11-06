using Microsoft.AspNetCore.Mvc;

namespace JooneliTrading.Controllers
{
    public class RestroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
