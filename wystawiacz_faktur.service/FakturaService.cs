using System.Collections.Generic;
using System.Linq;
using wystawiacz_faktur.DTO;
using wystawiacz_faktur.repository;

namespace wystawiacz_faktur.service
{
    public class FakturaService
    {
        public FakturaRespository FakturaRespository = new FakturaRespository();
        public IList<FakturaListItemDTO> PobierzFakturaList()
        {
            return FakturaRespository.PobierzFakturaList();
        }
       
        public IList<AddProduktListItemDTO> DodajProduktList(IList<AddProduktListItemDTO> lista)
        {
            return FakturaRespository.DodajProduktList(lista);
        }
        public IList<DropProduktListItemDTO> UsunProduktList(IList<DropProduktListItemDTO> lista)
        {
            return FakturaRespository.UsunProduktList(lista);
        }
        public IList<UpdateProduktListItemDTO> UpdateProduktList(IList<UpdateProduktListItemDTO> lista)
        {
            return FakturaRespository.UpdateProduktList(lista);
        }
        public IList<UpdateProduktListItemDTO> DownloadForUpdateProduktList(int idProd)
        {
            return FakturaRespository.DownloadForUpdateProduktList(idProd).ToList();
        }
    }
}
