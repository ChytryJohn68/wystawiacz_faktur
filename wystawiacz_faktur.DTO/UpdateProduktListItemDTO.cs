using System;
using System.Collections.Generic;
using System.Text;

namespace wystawiacz_faktur.DTO
{
    public class UpdateProduktListItemDTO
    {
        public int id_faktura_poz { get; set; }
        public string nazwa { get; set; }
        public decimal cena_brutto { get; set; }
        public decimal cena_netto { get; set; }
        public decimal VAT { get; set; }
        public string Jedn_miary { get; set; }
        public decimal wartosc_vat { get; set; }
        public int ilosc { get; set; }
    }
}
