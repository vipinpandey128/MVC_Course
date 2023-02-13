using Microsoft.AspNetCore.Mvc;

namespace FullMVCourse.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            return View();
        }
    }
}
