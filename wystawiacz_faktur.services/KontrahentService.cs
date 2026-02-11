using wystawiacz_faktur.DTO;

namespace wystawiacz_faktur.repository
{
    public class KontrahentService
    {
        public IList<KontrahentListItemDTO> PobierzKontrahentList()
        {
            return new List<KontrahentListItemDTO>() {
                new KontrahentListItemDTO()
                {
                    ID = 1,
                    Adres = "sdsdsd",
                    Nazwa = "sdsdsd"
                }
            };

        }
    }
}
