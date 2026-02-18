using Microsoft.AspNetCore.Mvc;
using wystawiacz_faktur.DTO;
using wystawiacz_faktur.service;

namespace MyApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KontrahentController : ControllerBase
    {
        private readonly KontrahentService _kontrahentService;

        public KontrahentController(KontrahentService kontrahentService)
        {
            _kontrahentService = kontrahentService;
        }

        [HttpGet("lista")]
        public ActionResult<IList<KontrahentListItemDTO>> PobierzKontahent()
        {
            var lista = _kontrahentService.PobierzKontrahentList();
            return Ok(lista);
        }

        [HttpPost("dodaj-kontrahent")]
        public ActionResult DodajKontrahent([FromBody] IList<AddKontrahentListItemDTO> lista)
        {
            var wynik = _kontrahentService.DodajKontrahentList(lista);
            return Ok(wynik);
        }

        [HttpPost("usun-kontrahent")]
        public ActionResult UsunKontrahent([FromBody] IList<DropKontrahentListItemDTO> lista)
        {
            var wynik = _kontrahentService.UsunKontrahentList(lista);
            return Ok(wynik);
        }

        [HttpPost("update-kontrahent")]
        public ActionResult UpdateKontrahent([FromBody] IList<UpdateKontrahentListItemDTO> lista)
        {
            var wynik = _kontrahentService.UpdateKontrahentList(lista);
            return Ok(wynik);
        }

        [HttpGet("kontrahent-do-update/{idNab}")]
        public ActionResult<IList<UpdateKontrahentListItemDTO>> PobierzKontrahentDoUpdate(int idNab)
        {
            var wynik = _kontrahentService.DownloadForUpdateKontrahentList(idNab);
            return Ok(wynik);
        }
    }
}
