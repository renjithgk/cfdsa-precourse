using cfdsa_precourse_assignment.Models;
using cfdsa_precourse_assignment.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace cfdsa_precourse_assignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILandingPageService _landingPageService;

        public HomeController(ILogger<HomeController> logger, ILandingPageService landingPageService)
        {
            _logger = logger;
            _landingPageService = landingPageService;
        }

        public IActionResult Index()
        {
            ViewBag.Text = _landingPageService.GetDynamicText();
            return View();
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