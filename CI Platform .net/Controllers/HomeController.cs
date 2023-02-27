using CI_Platform_.net.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CI_Platform_.net.Controllers
{
    public class HomeController : Controller
    {

        private readonly CiContext _context;

        public HomeController(CiContext context)
        {
            _context = context;
        }
       


            public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(User user)
        {


            if (user.Email == null || user.Password == null)
            {
                return View();
            }
            var data = _context.Users.Where(d => d.Email == user.Email && d.Password == user.Password).FirstOrDefault();

            if (data != null)
            {
                return RedirectToAction("PlatformLanding", "Home");
            }

            else
            {
                ViewBag.ErrorMessage = "Failed";
                return View();
            }

            //if (result)
            //{ 


            //    return RedirectToAction(nameof(Header)); }
            //else { return NotFound(); }

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