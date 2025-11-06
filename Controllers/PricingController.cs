using Microsoft.AspNetCore.Mvc;

namespace JooneliTrading.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //private List<ProductPricing> GetProductPricing()
        //{
        //    var Products = new List<ProductPricing>
        //    {
        //        new ProductPricing { Title="Starter", Price=2900, Description="Essential features to get your business started", Properties={'Up to 1,000 products'}},
        //    };
        //    return Products;
        //}
    }
}
