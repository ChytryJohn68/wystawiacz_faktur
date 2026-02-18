using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
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
        private async void ProduktLista_Post(object sender, EventArgs e)
        {

        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || numericUpDown3.Text == null || numericUpDown2.Text == null || textBox5.Text == null || numericUpDown1.Text == null || numericUpDown4.Text == null || numericUpDown5.Text == null)
            {
                MessageBox.Show("NIE PODANO WSZYSTKICH WARTOSCI");
                return;
            }
            
            var item = new AddProduktListItemDTO
            {
                nazwa = textBox1.Text,
                Jedn_miary = textBox5.Text,
                cena_brutto = decimal.Parse(numericUpDown3.Text),
                cena_netto = decimal.Parse(numericUpDown2.Text),
                VAT = decimal.Parse(numericUpDown1.Text),   
                wartosc_vat = decimal.Parse(numericUpDown4.Text),
                ilosc = int.Parse(numericUpDown5.Text)
            };
            var result = new List<AddProduktListItemDTO>
            {
                item
            };
            var http = new HttpClient();
            var produkt = await http.PostAsJsonAsync("https://localhost:7174/api/faktura/dodaj-produkt", result);
            MessageBox.Show("Dodano Produkt");
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
