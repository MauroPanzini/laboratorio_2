using Modelos;
using main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace Vistas
{
    public partial class Form5 : Form
    {
        protected Fabrica fabrica = Program.fabrica;
        List<Operario> operarios = new();
        public Form5()
        {
            InitializeComponent();
            try
            {
                foreach (Operario operario in fabrica.Empleados)
                {
                    operarios.Add(operario);
                }
            }
            catch (InvalidCastException) { }
            dataGridView1.DataSource = operarios;
            dataGridView1.Columns[5].Visible = false;
        }

        private void ListaEmpleados(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
