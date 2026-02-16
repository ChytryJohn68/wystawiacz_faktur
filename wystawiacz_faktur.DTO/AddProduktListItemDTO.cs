using System;
using System.Collections.Generic;
using System.Text;

namespace wystawiacz_faktur.DTO
{
    public class AddProduktListItemDTO
    {
        public string nazwa { get; set; }
        public string cena_brutto { get; set; }
        public string cena_netto { get; set; }
        public string VAT { get; set; }
        public string Jedn_miary { get; set; }
        public string wartosc_vat { get; set; }
        public int ilosc { get; set; }
    }
}
