using CI_Platform_.net.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CI_Platform_.net.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult LostPassword()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }
        public IActionResult ResetPassword()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult PlatformLanding()
        {
            return View();
        }
        public IActionResult VolunteeringMission()
        {
            return View();
        }
        public IActionResult StoriesListing()
        {
            return View();
        }
        public PartialViewResult GetGridView()
        {
            return PartialView("_GridCard");
        }
        public PartialViewResult GetListView()
        {
            return PartialView("_ListCard");
        }
        public PartialViewResult GetNoMission()
        {
            return PartialView("_NoMissionFound");
        }
    }
}