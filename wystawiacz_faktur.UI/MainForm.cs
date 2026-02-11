using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wystawiacz_faktur.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {

            InitializeComponent();

            panel2.Controls.Add(new KontrahenLista()
            {
                Name = "KontrahenLista"
            });
            panel2.Controls.Add(new ProduktLista()
            {
                Name = "ProduktLista"
            });

            

            
        }

        

        private void kontrahentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control item in panel2.Controls)
            {
                if (item.Name == "KontrahenLista")
                {
                    item.BringToFront();
                }
            }
        }

        private void fakturaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Control item in panel2.Controls)
            {
                if (item.Name == "ProduktLista")
                {
                    item.BringToFront();
                }
            }
        }

        
    }
}
