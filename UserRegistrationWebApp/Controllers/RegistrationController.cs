using Microsoft.AspNetCore.Mvc;

namespace UserRegistrationWebApp.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult UserRegistration()
        {
            return View();
        }
    }
}
