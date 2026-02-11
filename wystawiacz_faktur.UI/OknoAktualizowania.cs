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
        public OknoAktualizowania(int idNab) : this()
        {
            dataGridView1.AutoGenerateColumns = false;
            var service = new KontrahentService();
            var result = new List<UpdateKontrahentListItemDTO>();
            dataGridView1.DataSource = service.DownloadForUpdateKontrahentList(idNab);
        }
    }
}
