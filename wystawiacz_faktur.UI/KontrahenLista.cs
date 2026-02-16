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
    public partial class KontrahenLista : UserControl
    {
        public KontrahentService KontrahentService = new KontrahentService();

        public KontrahenLista()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.DataSource = KontrahentService.PobierzKontrahentList();           
        }

        private void buttonPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dodawanie nowego kontrahenta");
            
            var okno = new OknoDodawania();
            okno.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Czy na pewno chcesz usunąc wybranego kontrahenta?", "Usuwanie", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            
            if (dialog == DialogResult.Yes)
            {
                MessageBox.Show("Skasowano kontrahenta", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                var selectedObject = selectedRow.DataBoundItem as KontrahentListItemDTO;
                
                String id = selectedObject.id_nabywca.ToString();
                var service = new KontrahentService();
                var result = new List<DropKontrahentListItemDTO>();
                result.Add(new DropKontrahentListItemDTO
                {
                    id_nabywca = id
                });
                service.UsunKontrahentList(result);
                


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
            var selectedObject = selectedRow.DataBoundItem as KontrahentListItemDTO;

            int id = selectedObject.id_nabywca;
            var service = new KontrahentService();
            
            MessageBox.Show(id.ToString());
            MessageBox.Show(service.UpdateKontrahentList(service.DownloadForUpdateKontrahentList(id)).FirstOrDefault().adres);
            var okno = new OknoAktualizowania(id);
            okno.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = KontrahentService.PobierzKontrahentList();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            var selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
            var selectedObject = selectedRow.DataBoundItem as KontrahentListItemDTO;
        }
    }
}
