using Microsoft.AspNetCore.Mvc;
using wystawiacz_faktur.service;

namespace MyApp.Api.Controllers
{
    public class ContactController : Controller 
    {
        private readonly KontrahentService _kontrahentService;

        public ContactController(KontrahentService kontrahentService)
        {
            _kontrahentService = kontrahentService;
        }

       
        public IActionResult Index()
        {
            var model = _kontrahentService.PobierzKontrahentList();
            return View(model); 
        }
    }
}