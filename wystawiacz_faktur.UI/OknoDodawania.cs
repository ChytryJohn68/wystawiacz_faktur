using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public enum TrybOtwarciaOkna
        {
            Nowy,
            Edycja
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == null || maskedTextBox1.Text == null || textBox3.Text == null || textBox5.Text == null || textBox6.Text == null || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("NIE PODANO WSZYSTKICH WARTOSCI");
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
            service.DodajKontrahentList(result);
            MessageBox.Show("Dodano kontrahenta");
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

}

}


        


