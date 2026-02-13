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
        private int _idNabywca;
        public string Styp;
        
        public OknoAktualizowania()
        {
            InitializeComponent();
        }
        public OknoAktualizowania(int idNab) : this()
        {
            _idNabywca = idNab;
            this.Load += OknoAktualizowania_Load;
            var service = new KontrahentService();
            var result = new List<UpdateKontrahentListItemDTO>();
            
        }
        private void OknoAktualizowania_Load(object sender, EventArgs e)
        {

            var dane = KontrahentService.DownloadForUpdateKontrahentList(_idNabywca).FirstOrDefault();
            if(dane.typ == "N")
            {
                Styp = "Nabywca";
            }
            else
            {
                Styp = "Sprzedawca";
            }
            if (dane != null)
            {
              
                textBox1.Text = dane.nazwa;
                textBox4.Text = dane.miasto;
                maskedTextBox1.Text = dane.NIP;
                comboBox1.SelectedItem = dane.typ; 
                textBox2.Text = dane.adres;
                maskedTextBox2.Text = dane.numer_konta;
                textBox3.Text = dane.kod_pocztowy;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Nabywca")
            {
                Styp = "N";
            }
            else
            {
                Styp = "S";
            }
            var updateDto = new UpdateKontrahentListItemDTO
            {
                id_nabywca = _idNabywca.ToString(),
                nazwa = textBox1.Text,
                miasto = textBox4.Text,
                NIP = maskedTextBox1.Text,
                typ = Styp,
                adres = textBox2.Text,
                numer_konta = maskedTextBox2.Text,
                kod_pocztowy = textBox3.Text
            };
            if(textBox1.Text == null || textBox2.Text == null || textBox3.Text == null || textBox4.Text == null || maskedTextBox1.Text == null || maskedTextBox2.Text == null || comboBox1.Text == null)
            {
                MessageBox.Show("Dane nie sa uzupelnione.");
                return;
            }
            else
            {
            var lista = new List<UpdateKontrahentListItemDTO> { updateDto };

            KontrahentService.UpdateKontrahentList(lista);

            MessageBox.Show("Dane zostały zaktualizowane.");
            this.DialogResult = DialogResult.OK;
            this.Close();

            }
            
        }
    }
}
