using System;
using System.Collections.Generic;
using System.Text;

namespace wystawiacz_faktur.DTO
{
    public class FakturaListItemDTO
    {
        public int id_faktura_poz {  get; set; }
        public string nazwa {  get; set; }
        public string cena_netto { get; set; }
        public string wartosc_vat { get; set; }
        public int ilosc { get; set; }

    }
    
}
