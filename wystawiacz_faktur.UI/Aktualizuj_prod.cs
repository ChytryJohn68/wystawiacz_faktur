using Mysqlx.Crud;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.RegularExpressions;
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
        public int IdProd;
        
       
        public Aktualizuj_prod(int idProd)
        {
            InitializeComponent();
            IdProd = idProd;
            this.Load += Aktualizuj_prod_Load;
        }

        

        public async void Aktualizuj_prod_Load(object sender, EventArgs e)
        {
            try
            {
                var http = new HttpClient();
                var produkty = await http.GetFromJsonAsync<IList<UpdateProduktListItemDTO>>($"https://localhost:7174/api/faktura/produkty-do-update/{IdProd}"); 
                var produkt = produkty?.FirstOrDefault();
                if (produkty == null)
                {
                    MessageBox.Show("Nie można znaleźć produktu o podanym ID.");
                    MessageBox.Show(IdProd.ToString());
                    this.Close();
                    return;
                }
                else
                {
                    textBox1.Text = produkty[0].nazwa;
                    textBox2.Text = produkty[0].Jedn_miary;
                    maskedTextBox1.Text = produkty[0].cena_brutto.ToString();
                    maskedTextBox2.Text = produkty[0].cena_netto.ToString();
                    maskedTextBox3.Text = produkty[0].VAT.ToString();
                    maskedTextBox4.Text = produkty[0].wartosc_vat.ToString();
                    maskedTextBox5.Text = produkty[0].ilosc.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas ładowania danych produktu: {ex.Message}");
                MessageBox.Show(IdProd.ToString());
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
                id_faktura_poz = IdProd,
                nazwa = textBox1.Text,
                Jedn_miary = textBox2.Text,
                cena_brutto = decimal.Parse(maskedTextBox1.Text),
                cena_netto = decimal.Parse(maskedTextBox2.Text),
                VAT = decimal.Parse(maskedTextBox3.Text),
                wartosc_vat = decimal.Parse(maskedTextBox4.Text),
                ilosc = int.Parse(maskedTextBox5.Text),
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
