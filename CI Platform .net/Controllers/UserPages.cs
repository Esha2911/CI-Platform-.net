using Microsoft.AspNetCore.Mvc;

namespace CI_Platform_.net.Controllers
{
    public class UserPages : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
