using JooneliTrading.Models;
using Microsoft.AspNetCore.Mvc;

namespace JooneliTrading.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            var pricingViewModel = new PricingViewModel
            {
                Products = GetProductsPricing(),
                Faqs = GetFAQs()
            };
            return View(pricingViewModel);
        }

      private List<ProductPricing> GetProductsPricing()
       {
            var pricingPlans = new List<ProductPricing>
            {
                new ProductPricing {Title="Starter",Price="1500.00",
                    YearlyPrice="18,000.00",
                    Description="Essential features to get your business started",
                    Properties={ "Up to 1,000 products", "2 user accounts", "Basic inventory management", "Sales reporting", "Email support" },
                    NotProperties={"Advanced analytics","API access","Custom integrations"}},

                 new ProductPricing {Title="Professional",Price="3500.00",
                    YearlyPrice="42,000.00",
                     Description="For growing businesses with advanced needs",
                    Properties={ "Up to 10,000 products", "10 user accounts", "Advanced inventory management", "Comprehensive  reporting", "Priority  support" ,"Advanced analytics","API access"},
                    NotProperties={ "Custom integrations" } },

                  new ProductPricing {Title="Enterprise",Price="Custom", Description="For growing businesses with advanced needs",
                    Properties={ "Unlimited  products", "Unlimited  users", "Enterprise inventory", "Custom reporting ", "24/7 dedicated support", "Advanced analytics","Full API access","Custom integrations" } },
            };
            return pricingPlans;
       }













        private List<FAQs> GetFAQs()
        {
            var faqs = new List<FAQs>
            {
                new FAQs { Question = "Can I change my plan later?", Answer = "Yes, you can upgrade or downgrade your plan at any time. Changes take effect immediately, and we'll prorate the billing accordingly." },
                new FAQs { Question = "Is there a free trial available?", Answer = "Yes! All paid plans include a 14-day free trial with full access to all features." },
                new FAQs { Question = "What payment methods do you accept?", Answer = "We accept all major digital wallets and bank transfers for annual plans." },
            };
            return faqs;
        }
    }
}
