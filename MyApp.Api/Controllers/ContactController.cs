using Microsoft.AspNetCore.Mvc;

namespace MyApp.Api.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }

}
