using Microsoft.AspNetCore.Mvc;
using wystawiacz_faktur.DTO;
using wystawiacz_faktur.service;

namespace MyApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly KontrahentService _kontrahentService;

        public HomeController(KontrahentService kontrahentService)
        {
            _kontrahentService = kontrahentService;
        }

        [HttpGet("{id}")]
        public ActionResult<KontrahentListItemDTO> GetUser(int id)
        {
            var kontrahent = _kontrahentService
                .PobierzKontrahentList(id)
                .FirstOrDefault();

            if (kontrahent == null)
                return NotFound();

            var dto = new KontrahentListItemDTO
            {
                id_nabywca = kontrahent.id_nabywca,
                nazwa = kontrahent.nazwa,
                NIP = kontrahent.NIP,
                adres = kontrahent.adres,
                numer_konta = kontrahent.numer_konta,
                typ = kontrahent.typ,
            };

            return Ok(dto);
        }
    }
}
