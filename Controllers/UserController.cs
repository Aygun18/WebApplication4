using Microsoft.AspNetCore.Mvc;

namespace ASPNETIntroduction.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Aygun";
            ViewBag.Surname = "Shahmuradova";
            ViewBag.Age = 22;
            ViewBag.Country = "Azerbaijan";
            ViewBag.PhoneNumber = "+9943678765";
            return View();
        }
    }
}
