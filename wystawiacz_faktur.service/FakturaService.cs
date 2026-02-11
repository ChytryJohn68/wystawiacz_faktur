using System.Collections.Generic;
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
    }
}
