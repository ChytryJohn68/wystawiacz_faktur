using MySql.Data.MySqlClient;
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
    public partial class OknoAktualizowania : Form
    {
        public KontrahentService KontrahentService = new KontrahentService();

        public int IdNab;
        public OknoAktualizowania(int idNab)
        {
            InitializeComponent();
            IdNab = idNab;
            this.Load += Aktualizuj_Kon_Load;
        }
        public async void Aktualizuj_Kon_Load(object sender, EventArgs e)
        {
            try
            {
                var http = new HttpClient();
                var kontrahenci = await http.GetFromJsonAsync<IList<UpdateKontrahentListItemDTO>>($"https://localhost:7174/api/kontrahent/kontrahent-do-update/{IdNab}");
                
                if (kontrahenci == null)
                {
                    MessageBox.Show("Nie można znaleźć produktu o podanym ID.");
                    MessageBox.Show(IdNab.ToString());
                    this.Close();
                    return;
                }
                else
                {
                    textBox1.Text = kontrahenci[0].nazwa;
                    textBox3.Text = kontrahenci[0].adres;
                    textBox5.Text = kontrahenci[0].kod_pocztowy;
                    textBox6.Text = kontrahenci[0].miasto;
                    maskedTextBox1.Text = kontrahenci[0].NIP;
                    maskedTextBox2.Text = kontrahenci[0].numer_konta;
                    comboBox1.SelectedItem = kontrahenci[0].typ == "N" ? "Nabywca" : "Sprzedawca";                  
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas ładowania danych produktu: {ex.Message}");
                MessageBox.Show(IdNab.ToString());
                this.Close();
            }
        }

        

        private async void button1_Click(object sender, EventArgs e)
        {
            var service = new KontrahentService();
            
            if (textBox1.Text == null || maskedTextBox1.Text == null || textBox3.Text == null || textBox5.Text == null || textBox6.Text == null || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("NIE PODANO WSZYSTKICH WARTOSCI");
                return;
            }
            var item = new UpdateKontrahentListItemDTO 
            { 
                id_nabywca = IdNab, 
                nazwa = textBox1.Text, 
                NIP = maskedTextBox1.Text, 
                adres = textBox3.Text, 
                numer_konta = maskedTextBox2.Text, 
                kod_pocztowy = textBox5.Text, 
                miasto = textBox6.Text, 
                typ = comboBox1.SelectedItem.ToString() == "Nabywca" ? "N" : "S" 
            }; 
            var result = new List<UpdateKontrahentListItemDTO> 
            { 
                item 
            };
            var http = new HttpClient();
            var kontrahent = await http.PostAsJsonAsync("https://localhost:7174/api/kontrahent/update-kontrahent", result);
            
            MessageBox.Show("Dane kontrahenta zostały zaktualizowane"); 
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

