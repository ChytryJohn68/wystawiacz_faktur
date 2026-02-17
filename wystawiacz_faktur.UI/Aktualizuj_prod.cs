using Mysqlx.Crud;
using MySqlX.XDevAPI.Common;
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
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wystawiacz_faktur.UI
{
    public partial class Aktualizuj_prod : Form
    {
        public int _idProd;
        private readonly HttpClient _http = new HttpClient();
       
        public Aktualizuj_prod(int idProd)
        {
            InitializeComponent();
            _idProd = idProd;
            this.Load += Aktualizuj_prod_Load;
        }

        

        public async void Aktualizuj_prod_Load(object sender, EventArgs e)
        {
            try
            {
                var produkty = await _http.GetFromJsonAsync<IList<UpdateProduktListItemDTO>>($"https://localhost:7174/api/faktura/produkty-do-update/{_idProd}"); 
                var produkt = produkty?.FirstOrDefault();
                if (produkt == null)
                {
                    MessageBox.Show("Nie można znaleźć produktu o podanym ID.");
                    this.Close();
                    return;
                }
                else
                {
                    textBox1.Text = produkt.nazwa;
                    maskedTextBox1.Text = produkt.cena_brutto;
                    maskedTextBox2.Text = produkt.cena_netto;
                    maskedTextBox3.Text = produkt.VAT;
                    textBox2.Text = produkt.Jedn_miary;
                    maskedTextBox4.Text = produkt.wartosc_vat;
                    maskedTextBox5.Text = produkt.ilosc;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas ładowania danych produktu: {ex.Message}");
                this.Close();
            }
        }
        private async void button1_Click(object sender, EventArgs e)
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
            var http = new HttpClient();
            var produkt = await http.PostAsJsonAsync("https://localhost:7174/api/faktura/update-produkt", result);
            MessageBox.Show("Dane faktury zostały zaktualizowane");
            this.Close();
        }
    }
}
