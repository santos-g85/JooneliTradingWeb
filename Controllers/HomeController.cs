using System.Diagnostics;
using JooneliTrading.Models;
using Microsoft.AspNetCore.Mvc;

namespace JooneliTrading.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            var homeviewmodel = new HomeViewModel
            {
                Features= GetFeatures(),
                Benefits = GetBenefits()
            };
            return View(homeviewmodel);
        }

        public List<Benefits> GetBenefits()
        {
            var benefits = new List<Benefits>
            {
                    new Benefits { Title = "Streamlined Operations" },
                    new Benefits { Title = "Cost Savings" },
                    new Benefits { Title = "Data-Driven Decisions" },
                    new Benefits { Title = "Improved Customer Satisfaction" },
                    new Benefits { Title = "Scalability" },
                    new Benefits { Title = "Enhanced Collaboration" }
            };
            return benefits;
        }

        public List<Feature> GetFeatures()
        {
            var features = new List<Feature>
            {
                    new Feature { Icon = "bi bi-box", Title = "Real-Time Tracking", Description = "Monitor stock levels across all locations in real-time. Get instant updates on inventory movements and never run out of stock." },
                    new Feature { Icon = "bi bi-bar-chart", Title = "Advanced Analytics", Description = "Make data-driven decisions with comprehensive reports and insights. Track trends, forecast demand, and optimize inventory." },
                    new Feature { Icon = "bi bi-bell", Title = "Smart Alerts", Description = "Receive automated notifications for low stock, expiring items, and unusual activities. Stay ahead of potential issues." },
                    new Feature { Icon = "bi bi-people", Title = "Multi-User Access", Description = "Collaborate seamlessly with role-based permissions. Control who can view, edit, or manage inventory data." },
                    new Feature { Icon = "bi bi-lightning", Title = "Quick Integration", Description = "Connect with your existing tools and platforms. Seamless integration with popular e-commerce and ERP systems." },
                    new Feature { Icon = "bi bi-shield-check", Title = "Enterprise Security", Description = "Bank-level encryption and security measures. Your inventory data is protected with industry-leading protocols." }
            };
            return features;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
