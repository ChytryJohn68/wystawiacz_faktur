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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using wystawiacz_faktur.DTO;
using wystawiacz_faktur.service;
namespace wystawiacz_faktur.UI
{
    public partial class OknoDodawania : Form
    {
        public OknoDodawania()
        {
            InitializeComponent();
            


        }
        private async void ProduktLista_Post(object sender, EventArgs e)
        {
            

           

        }
        public enum TrybOtwarciaOkna
        {
            Nowy,
            Edycja
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(maskedTextBox1.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text) || comboBox1.SelectedItem == null) 
            { 
                MessageBox.Show("NIE PODANO WSZYSTKICH WARTOŚCI"); 
                return; 
            }
            String TxtNazwa = textBox1.Text;
            String TxtNIP = maskedTextBox1.Text;
            String TxtAdres = textBox3.Text;
            String TxtNumer_konta = maskedTextBox2.Text;
            String TxtKod_pocztowy = textBox5.Text;
            String TxtMiasto = textBox6.Text;
            String typ_long = comboBox1.SelectedItem.ToString();
            String TxtTyp;
            if(typ_long == "Nabywca")
            {
                TxtTyp = "N";
            }
            else
            {
                TxtTyp = "S";
            }
            
            var service = new KontrahentService();
            bool exists = service.PobierzKontrahentList().Any(x => x.NIP == TxtNIP);
            if (exists)
            {
                MessageBox.Show($"PODANY NIP JUZ ISTNIEJE");
                return;
            }
            
            var result = new List<AddKontrahentListItemDTO>();
            result.Add(new AddKontrahentListItemDTO
            {
                nazwa = TxtNazwa,
                NIP = TxtNIP,
                adres = TxtAdres,
                numer_konta = TxtNumer_konta,
                kod_pocztowy = TxtKod_pocztowy,
                miasto = TxtMiasto,
                typ = TxtTyp
            });
            var http = new HttpClient();
            var kontrahent = await http.PostAsJsonAsync("https://localhost:7174/api/kontrahent/dodaj-kontrahent", result);
           
            MessageBox.Show("Dodano kontrahenta");
            this.Close();

        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

}

}


        


