using Microsoft.AspNetCore.Mvc;
using MuOnline.Services.System.Dtos;

namespace MuOnline.Web.Admin.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginUserRequest request)
        {
            return View();
        }
    }
}
