using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wystawiacz_faktur.DTO;

namespace wystawiacz_faktur.RepositoryEF
{
    public class KontrahentRepository
    {


        public IList<KontrahentListItemDTO> PobierzKontrahentList()
        {
            var result = new List<KontrahentListItemDTO>();

            try
            {
                using (var db = new praktyki2026Entities())
                {
                    foreach (var item in db.kontrahent)
                    {
                        result.Add(new KontrahentListItemDTO
                        {
                            id_nabywca = item.id_nabywca,
                            nazwa = item.nazwa,
                            NIP = item.NIP,
                            adres = item.adres,
                            numer_konta = item.numer_konta,
                            typ = item.typ
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }




        public IList<AddKontrahentListItemDTO> DodajKontrahentList(IList<AddKontrahentListItemDTO> lista)
        {
            var result = new List<AddKontrahentListItemDTO>();

            try
            {
                using (var db = new praktyki2026Entities())
                {
                    var kontrahent = new kontrahent
                    {
                        nazwa = lista[0].nazwa,
                        NIP = lista[0].NIP,
                        adres = lista[0].adres,
                        numer_konta = lista[0].numer_konta,
                        kod_pocztowy = lista[0].kod_pocztowy,
                        miasto = lista[0].miasto,
                        typ = lista[0].typ
                    };
                    db.kontrahent.Add(kontrahent);
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
        }

        public IList<DropKontrahentListItemDTO> UsunKontrahentList(IList<DropKontrahentListItemDTO> lista)
        {
            var result = new List<DropKontrahentListItemDTO>();
            using (var db = new praktyki2026Entities())
            {
                var kontrahent = db.kontrahent.Where(x => x.id_nabywca == int.Parse(lista[0].id_nabywca)).FirstOrDefault();
                if (kontrahent != null)
                {
                    db.kontrahent.Remove(kontrahent);
                    db.SaveChanges();
                }
            }

            return result;
        }

        public IList<UpdateKontrahentListItemDTO> DownloadForUpdateKontrahentList(int idNab)
        {
            var result = new List<UpdateKontrahentListItemDTO>();
            using (var db = new praktyki2026Entities())
            {
                var kontrahent = db.kontrahent.Where(x => x.id_nabywca == idNab).FirstOrDefault();
                if (kontrahent != null)
                {
                    result.Add(new UpdateKontrahentListItemDTO
                    {
                        id_nabywca = kontrahent.id_nabywca,
                        nazwa = kontrahent.nazwa,
                        NIP = kontrahent.NIP,
                        adres = kontrahent.adres,
                        numer_konta = kontrahent.numer_konta,
                        kod_pocztowy = kontrahent.kod_pocztowy,
                        miasto = kontrahent.miasto,
                        typ = kontrahent.typ
                    });
                }
            }

            return result;
        }
        public IList<UpdateKontrahentListItemDTO> UpdateKontrahentList(IList<UpdateKontrahentListItemDTO> lista)
        {
            var result = new List<UpdateKontrahentListItemDTO>();

            using (var db = new praktyki2026Entities())
            {
                var kontrahent = db.kontrahent.Where(x => x.id_nabywca == lista[0].id_nabywca).FirstOrDefault();
                if (kontrahent != null)
                {
                    kontrahent.nazwa = lista[0].nazwa;
                    kontrahent.NIP = lista[0].NIP;
                    kontrahent.adres = lista[0].adres;
                    kontrahent.numer_konta = lista[0].numer_konta;
                    kontrahent.kod_pocztowy = lista[0].kod_pocztowy;
                    kontrahent.miasto = lista[0].miasto;
                    kontrahent.typ = lista[0].typ;
                    db.SaveChanges();
                }
            }
            return result;
        }
    }
}
