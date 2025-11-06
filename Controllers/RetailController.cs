using Microsoft.AspNetCore.Mvc;

namespace JooneliTrading.Controllers
{
    public class RetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
