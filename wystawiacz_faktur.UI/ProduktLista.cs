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
using System.Net.Http;
using System.Net.Http.Json;


namespace wystawiacz_faktur.UI
{
    public partial class ProduktLista : UserControl
    {
        public FakturaService FakturaService = new FakturaService();
        public ProduktLista()
        {
            InitializeComponent();
            this.Load += ProduktLista_Load;

        }
        private async void ProduktLista_Load(object sender, EventArgs e)
        {
            var http = new HttpClient();

            var faktury = await http.GetFromJsonAsync<IList<FakturaListItemDTO>>("https://localhost:7174/api/faktura/lista");

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = faktury;
        }
        private void buttonPanel_Paint(object sender, PaintEventArgs e)
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
            DialogResult dialog = MessageBox.Show("Czy na pewno chcesz usunąc wybranego kontrahenta?", "Usuwanie", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);


            if (dialog == DialogResult.Yes)
            {
                MessageBox.Show("Skasowano kontrahenta", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                var selectedObject = selectedRow.DataBoundItem as FakturaListItemDTO;

                String id = selectedObject.id_faktura_poz.ToString();
                var service = new FakturaService();
                var result = new List<DropProduktListItemDTO>();
                result.Add(new DropProduktListItemDTO
                {
                    id_faktura_poz = id
                });
                service.UsunProduktList(result);



            }
            else if (dialog == DialogResult.No)
            {
                MessageBox.Show("Anulowano usuwanie kontrahenta z bazy", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Usuwanie anulowane", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aktualizowanie kontrahenta");
            var selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
            var selectedObject = selectedRow.DataBoundItem as FakturaListItemDTO;

            int id = selectedObject.id_faktura_poz;
            var service = new FakturaService();

            
            var okno = new Aktualizuj_prod(id);
            okno.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FakturaService.PobierzFakturaList();
        }
    }
}
