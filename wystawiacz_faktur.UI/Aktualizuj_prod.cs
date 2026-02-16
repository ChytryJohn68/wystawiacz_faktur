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
    public partial class Aktualizuj_prod : Form
    {
        public Aktualizuj_prod()
        {
            InitializeComponent();
        }
        public int _idProd;
        public Aktualizuj_prod(int idProd) : this()
        {
            _idProd = idProd;
            var service = new FakturaService();
            var result = new List<UpdateProduktListItemDTO>();
            textBox1.Text = service.DownloadForUpdateProduktList(idProd).FirstOrDefault().nazwa;
            maskedTextBox1.Text = service.DownloadForUpdateProduktList(idProd).FirstOrDefault().cena_brutto;
            maskedTextBox2.Text = service.DownloadForUpdateProduktList(idProd).FirstOrDefault().cena_netto;
            maskedTextBox3.Text = service.DownloadForUpdateProduktList(idProd).FirstOrDefault().VAT;
            textBox2.Text = service.DownloadForUpdateProduktList(idProd).FirstOrDefault().Jedn_miary;
            maskedTextBox4.Text = service.DownloadForUpdateProduktList(idProd).FirstOrDefault().wartosc_vat;
            maskedTextBox5.Text = service.DownloadForUpdateProduktList(idProd).FirstOrDefault().ilosc;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var service = new FakturaService();

            if (textBox1.Text == null || maskedTextBox1.Text == null || textBox2.Text == null || maskedTextBox2.Text == null || maskedTextBox3.Text == null || maskedTextBox4.Text == null || maskedTextBox5.Text == null)
            {
                MessageBox.Show("NIE PODANO WSZYSTKICH WARTOSCI");
                return;
            }
            var item = new UpdateProduktListItemDTO
            {
                id_faktura_poz = _idProd,
                nazwa = textBox1.Text,
                cena_brutto = maskedTextBox1.Text,
                cena_netto = maskedTextBox2.Text,
                VAT = maskedTextBox3.Text,
                Jedn_miary = textBox2.Text,
                wartosc_vat = maskedTextBox4.Text,
                ilosc = maskedTextBox5.Text
            };
            var result = new List<UpdateProduktListItemDTO>
            {
                item
            };
            service.UpdateProduktList(result);
            MessageBox.Show("Dane kontrahenta zostały zaktualizowane");
            this.Close();
        }
    }
}
