using Microsoft.AspNetCore.Mvc;

namespace Dep_injection.Controllers
{
    public class TokenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
