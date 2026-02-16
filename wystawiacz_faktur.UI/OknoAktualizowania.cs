using MySql.Data.MySqlClient;
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

namespace wystawiacz_faktur.UI
{
    public partial class OknoAktualizowania : Form
    {
        public KontrahentService KontrahentService = new KontrahentService();

        public OknoAktualizowania()
        {
            InitializeComponent();
        }
        public int _idNab;
        public OknoAktualizowania(int idNab) : this()
        {
            _idNab = idNab;
            var service = new KontrahentService();
            var result = new List<UpdateKontrahentListItemDTO>();
            textBox1.Text = service.DownloadForUpdateKontrahentList(idNab).FirstOrDefault().nazwa;
            textBox3.Text = service.DownloadForUpdateKontrahentList(idNab).FirstOrDefault().adres;
            textBox5.Text = service.DownloadForUpdateKontrahentList(idNab).FirstOrDefault().kod_pocztowy;
            textBox6.Text = service.DownloadForUpdateKontrahentList(idNab).FirstOrDefault().miasto;
            maskedTextBox1.Text = service.DownloadForUpdateKontrahentList(idNab).FirstOrDefault().NIP;
            maskedTextBox2.Text = service.DownloadForUpdateKontrahentList(idNab).FirstOrDefault().numer_konta;
            comboBox1.SelectedItem = service.DownloadForUpdateKontrahentList(idNab).FirstOrDefault().typ == "N" ? "Nabywca" : "Sprzedawca";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var service = new KontrahentService();
            
            if (textBox1.Text == null || maskedTextBox1.Text == null || textBox3.Text == null || textBox5.Text == null || textBox6.Text == null || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("NIE PODANO WSZYSTKICH WARTOSCI");
                return;
            }
            var item = new UpdateKontrahentListItemDTO 
            { 
                id_nabywca = _idNab, 
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
            service.UpdateKontrahentList(result); 
            MessageBox.Show("Dane kontrahenta zostały zaktualizowane"); 
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

