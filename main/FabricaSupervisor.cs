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
    public partial class Form3 : Form2
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void GestionEmpleados(object sender, EventArgs e)
        {
            new Form5().Show();
        }

        private void GestionStock(object sender, EventArgs e)
        {
            new Form4().Show();
        }
    }
}
