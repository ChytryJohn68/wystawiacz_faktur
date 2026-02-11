using System;
using System.Collections.Generic;
using System.Text;

namespace wystawiacz_faktur.DTO
{
    public class UpdateKontrahentListItemDTO
    {
        public int idNabywca { get; set; }

        public string id_nabywca { get; set; }
        public string nazwa { get; set; }
        public string NIP { get; set; }
        public string adres { get; set; }
        public string numer_konta { get; set; }
        public string kod_pocztowy { get; set; }
        public string miasto { get; set; }
        public string typ { get; set; }
    }
}
