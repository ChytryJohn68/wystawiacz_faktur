using System.Collections.Generic;
using System.Linq;
using wystawiacz_faktur.DTO;

using wystawiacz_faktur.RepositoryEF;

namespace wystawiacz_faktur.service
{
    public class KontrahentService
    {
        public KontrahentRepository KontrahentRepository = new KontrahentRepository();
        public IList<KontrahentListItemDTO> PobierzKontrahentList()
        {
            return KontrahentRepository.PobierzKontrahentList();
        }
        public IList<AddKontrahentListItemDTO> DodajKontrahentList(IList<AddKontrahentListItemDTO> lista)
        {
            return KontrahentRepository.DodajKontrahentList(lista);
        }
        public IList<DropKontrahentListItemDTO> UsunKontrahentList(IList<DropKontrahentListItemDTO> lista)
        {
            return KontrahentRepository.UsunKontrahentList(lista);
        }
        public IList<UpdateKontrahentListItemDTO> UpdateKontrahentList(IList<UpdateKontrahentListItemDTO> lista)
        {
            return KontrahentRepository.UpdateKontrahentList(lista);
        }
        public IList<UpdateKontrahentListItemDTO> DownloadForUpdateKontrahentList(int idNab)
        {
            return KontrahentRepository.DownloadForUpdateKontrahentList(idNab).ToList();
        }
    }
}
