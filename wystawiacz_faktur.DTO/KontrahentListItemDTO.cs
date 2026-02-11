using System;
using System.Collections.Generic;
using System.Text;

namespace wystawiacz_faktur.DTO
{
    public class KontrahentListItemDTO
    {
        public int id_nabywca { get; set; }
        public string nazwa { get; set; }
        public string NIP { get; set; }
        public string adres { get; set; }
        public string numer_konta { get; set; }
        public string typ { get; set; }
    }
    
}
