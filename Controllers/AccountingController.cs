using Microsoft.AspNetCore.Mvc;

namespace JooneliTrading.Controllers
{
    public class AccountingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
