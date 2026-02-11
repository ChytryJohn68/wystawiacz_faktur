using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wystawiacz_faktur.service;

namespace wystawiacz_faktur.UI
{
    public partial class ProduktLista : UserControl
    {
        public FakturaService FakturaService = new FakturaService();
        public ProduktLista()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.DataSource = FakturaService.PobierzFakturaList();
        }

        private void buttonPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void ProduktLista_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dodawanie nowego produktu");
            var okno = new Dodawanie_prod();
            okno.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 2");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 3");

        }
    }
}
