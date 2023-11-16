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
    public partial class Form4 : Form
    {
        private Fabrica fabrica = Program.fabrica;
        private List<string> list = new();
        private Dictionary<string, int> materiales = new();
        private BindingList<KeyValuePair<string, int>> materialesBindingList = new();
        public Form4()
        {
            InitializeComponent();
            materiales.Add("Silicio", fabrica.Stock.StockSilicio);
            materiales.Add("Sodio", fabrica.Stock.StockSodio);
            materiales.Add("Cal", fabrica.Stock.StockCal);
            materiales.Add("Cromo", fabrica.Stock.StockCromo);
            materiales.Add("Manganeso", fabrica.Stock.StockManganeso);
            materiales.Add("Mezcla", fabrica.Stock.StockMezcla);
            materiales.Add("Polvo de vidrio", fabrica.Stock.StockVidrioTriturado);
            RellenarGrilla();
            comboBox1.DataSource = list;
        }

        private void RellenarGrilla()
        {
            foreach (KeyValuePair<string, int> par in materiales)
            {
                materialesBindingList.Add(par);
                list.Add(par.Key);
            }
            dataGridView1.DataSource = materialesBindingList;
            dataGridView1.Columns["Key"].HeaderText = "Material";
            dataGridView1.Columns["Value"].HeaderText = "Cantidad";
            list.Remove("Mezcla");
            list.Remove("Polvo de vidrio");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void SelectorMaterial(object sender, EventArgs e)
        {

        }

        private void ControlCantidad(object sender, EventArgs e)
        {
        }

        private void AgregarStock(object sender, EventArgs e)
        {
            fabrica.AgregarInventario(fabrica.Stock, comboBox1.Text, (int)numericUpDown1.Value);
            ActualizarDatos(comboBox1.Text, (int)numericUpDown1.Value);
        }
        private void ActualizarDatos(string clave, int valorIngresado)
        {
            foreach (var par in materialesBindingList)
            {
                int nuevoValor = valorIngresado + par.Value;
                if (par.Key == clave)
                {
                    var nuevoPar = new KeyValuePair<string, int>(par.Key, nuevoValor);
                    var index = materialesBindingList.IndexOf(par);
                    materialesBindingList[index] = nuevoPar;
                    break;
                }
            }
        }

        private void VerStockBotellas(object sender, EventArgs e)
        {
            new VerBotellas().Show();
        }
    }
}