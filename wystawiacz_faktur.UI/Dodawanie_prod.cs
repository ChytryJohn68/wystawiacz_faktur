using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wystawiacz_faktur.DTO;
using wystawiacz_faktur.service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wystawiacz_faktur.UI
{
    public partial class Dodawanie_prod : Form
    {
        public Dodawanie_prod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || maskedTextBox1.Text == null || maskedTextBox2.Text == null || textBox5.Text == null || maskedTextBox3.Text == null || maskedTextBox4.Text == null || maskedTextBox5.Text == null)
            {
                MessageBox.Show("NIE PODANO WSZYSTKICH WARTOSCI");
                return;
            }
            
            String TxtNazwa = textBox1.Text;
            String TxtCenaBrutto = maskedTextBox1.Text;
            String TxtCenaNetto = maskedTextBox2.Text;
            String TxtVAT = textBox5.Text;
            String TxtJednMiary = maskedTextBox3.Text;
            String TxtWartoscVAT = maskedTextBox4.Text;
            String TxtIlosc = maskedTextBox5.Text;
           
            var service = new FakturaService();
           
            

            var result = new List<AddProduktListItemDTO>();
            result.Add(new AddProduktListItemDTO
            {
                nazwa = TxtNazwa,
                cena_brutto = TxtCenaBrutto,
                cena_netto = TxtCenaNetto,
                VAT = TxtVAT,   
                Jedn_miary = TxtJednMiary,
                wartosc_vat = TxtWartoscVAT,
                ilosc = int.Parse(TxtIlosc)
            });
            service.DodajProduktList(result);
            MessageBox.Show("Dodano kontrahenta");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
