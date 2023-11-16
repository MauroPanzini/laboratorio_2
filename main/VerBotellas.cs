using main;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class VerBotellas : Form
    {
        protected Fabrica fabrica = Program.fabrica;
        private List<Botella> productos = new();
        public VerBotellas()
        {
            InitializeComponent();
            productos = fabrica.Stock.StockBotellas;
            RellenarGrilla();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RellenarGrilla()
        {
            dataGridView1.DataSource = productos;
            dataGridView1.Columns[2].Visible = false;

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
