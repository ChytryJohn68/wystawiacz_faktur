using Microsoft.AspNetCore.Mvc;
using wystawiacz_faktur.DTO;
using wystawiacz_faktur.service;

namespace MyApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FakturaController : ControllerBase
    {
        private readonly FakturaService _fakturaService;

        public FakturaController(FakturaService fakturaService)
        {
            _fakturaService = fakturaService;
        }

        [HttpGet("lista")]
        public ActionResult<IList<FakturaListItemDTO>> PobierzFaktury()
        {
            var lista = _fakturaService.PobierzFakturaList();
            return Ok(lista);
        }

        [HttpPost("dodaj-produkt")]
        public ActionResult DodajProdukt([FromBody] IList<AddProduktListItemDTO> lista)
        {
            var wynik = _fakturaService.DodajProduktList(lista);
            return Ok(wynik);
        }

        [HttpPost("usun-produkt")]
        public ActionResult UsunProdukt([FromBody] IList<DropProduktListItemDTO> lista)
        {
            var wynik = _fakturaService.UsunProduktList(lista);
            return Ok(wynik);
        }

        [HttpPost("update-produkt")]
        public ActionResult UpdateProdukt([FromBody] IList<UpdateProduktListItemDTO> lista)
        {
            var wynik = _fakturaService.UpdateProduktList(lista);
            return Ok(wynik);
        }

        [HttpGet("produkty-do-update/{id}")]
        public ActionResult<IList<UpdateProduktListItemDTO>> PobierzProduktyDoUpdate(int id)
        {
            var wynik = _fakturaService.DownloadForUpdateProduktList(id);
            return Ok(wynik);
        }
    }
}
