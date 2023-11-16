using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{

    public partial class Form2 : Form
    {
        protected Fabrica fabrica = Program.fabrica;
        protected EColor color;
        protected Vidrio? vidrio;
        protected Queue<Vidrio> vidrios = new();
        protected List<Botella> botellas = new();
        protected List<Botella> botellasMalaCalidad = new();
        protected Botella? botella;
        public Form2()
        {
            InitializeComponent();
            button6.BackColor = Color.Red;
            button1.BackColor = Color.White;
            button7.BackColor = Color.Red;
            button2.BackColor = Color.White;
            button8.BackColor = Color.Red;
            button3.BackColor = Color.White;
            button9.BackColor = Color.Red;
            button4.BackColor = Color.White;
            button10.BackColor = Color.Red;
            button5.BackColor = Color.White;
            fabrica.Mezcladora.Encendido = false;
            fabrica.Fundidora.Encendido = false;
            fabrica.Inyectora.Encendido = false;
            fabrica.ControlCalidad.Encendido = false;
            fabrica.Empaquetadora.Encendido = false;
            foreach (Empleado empleado in fabrica.Empleados)
            {
                if (empleado.Logeado)
                {
                    label1.Text = $"Panel de {empleado.GetType().Name}";
                    label2.Text = $"!Hola, {empleado.Nombre}!";
                    break;
                }
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void EncenderMezcladora(object sender, EventArgs e)
        {
            fabrica.Mezcladora.Encendido = true;
            button1.BackColor = Color.Green;
            button6.BackColor = Color.White;
        }

        private void ApagarMezcladora(object sender, EventArgs e)
        {
            fabrica.Mezcladora.Encendido = false;
            button6.BackColor = Color.Red;
            button1.BackColor = Color.White;
        }

        private void EncenderFundidora(object sender, EventArgs e)
        {
            fabrica.Fundidora.Encendido = true;
            button2.BackColor = Color.Green;
            button7.BackColor = Color.White;
        }

        private void ApagarFundidora(object sender, EventArgs e)
        {
            fabrica.Fundidora.Encendido = false;
            button7.BackColor = Color.Red;
            button2.BackColor = Color.White;
        }

        private void EncenderInyectora(object sender, EventArgs e)
        {
            fabrica.Inyectora.Encendido = true;
            button3.BackColor = Color.Green;
            button8.BackColor = Color.White;
        }

        private void ApagarInyectora(object sender, EventArgs e)
        {
            fabrica.Inyectora.Encendido = false;
            button8.BackColor = Color.Red;
            button3.BackColor = Color.White;
        }

        private void EncenderControlCalidad(object sender, EventArgs e)
        {
            fabrica.ControlCalidad.Encendido = true;
            button4.BackColor = Color.Green;
            button9.BackColor = Color.White;
        }

        private void ApagarControlCalidad(object sender, EventArgs e)
        {
            fabrica.ControlCalidad.Encendido = false;
            button9.BackColor = Color.Red;
            button4.BackColor = Color.White;
        }

        private void EncenderEmpaquetadora(object sender, EventArgs e)
        {
            fabrica.Empaquetadora.Encendido = true;
            button5.BackColor = Color.Green;
            button10.BackColor = Color.White;
        }

        private void ApagarEmpaquetadora(object sender, EventArgs e)
        {
            fabrica.Empaquetadora.Encendido = false;
            button10.BackColor = Color.Red;
            button5.BackColor = Color.White;
        }

        private void ControlRpm(object sender, EventArgs e)
        {
            fabrica.Mezcladora.Rpm = (int)numericUpDown1.Value;
        }

        private void ControlTemperatura(object sender, EventArgs e)
        {
            fabrica.Fundidora.Temperatura = (int)numericUpDown2.Value;
        }

        private void ControlBares(object sender, EventArgs e)
        {
            fabrica.Inyectora.Presion = (int)numericUpDown3.Value;
        }

        private void Mezclar(object sender, EventArgs e)
        {
            if (fabrica.Mezcladora.Encendido && fabrica.Mezcladora.Rpm > 49)
            {
                bool hayStock = fabrica.Mezcladora.Mezclar(fabrica.Stock);
                if (!hayStock)
                {
                    MessageBox.Show($"Parece que no hay stock de los materiales necesarios:\n" +
                        $"Silicio: {fabrica.Stock.StockSilicio}\n" +
                        $"Cal: {fabrica.Stock.StockCal}\n" +
                        $"Sodio: {fabrica.Stock.StockSodio}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int tiempoEspera = new Random().Next(0, 3000);
                    Cursor = Cursors.WaitCursor;
                    progressBar1.Value = 0;
                    Thread.Sleep(tiempoEspera);
                    progressBar1.Value = 30;
                    Thread.Sleep(tiempoEspera);
                    progressBar1.Value = 60;
                    Thread.Sleep(tiempoEspera);
                    progressBar1.Value = 100;
                    MessageBox.Show("Materia mezclada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    progressBar1.Value = 0;
                    Cursor = Cursors.Default;
                }
            }
            else
            {
                MessageBox.Show($"La maquina no iniciará hasta que sea encendida y tenga las revoluciones adecuadas (50 o mayor)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Fundir(object sender, EventArgs e)
        {
            if (fabrica.Fundidora.Encendido)
            {
                vidrio = fabrica.Fundidora.Fundir(fabrica.Stock, color);
                if (vidrio == null)
                {

                    MessageBox.Show($"Parece que no hay stock de los materiales necesarios:\n" +
                        $"Mezcla: {fabrica.Stock.StockMezcla}\n" +
                        $"Manganeso: {fabrica.Stock.StockManganeso}\n" +
                        $"Cromo: {fabrica.Stock.StockCromo}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int tiempoEspera = new Random().Next(0, 3000);
                    Cursor = Cursors.WaitCursor;
                    vidrios.Enqueue(vidrio);
                    progressBar2.Value = 0;
                    Thread.Sleep(tiempoEspera);
                    progressBar2.Value = 30;
                    Thread.Sleep(1000);
                    progressBar2.Value = 60;
                    Thread.Sleep(tiempoEspera);
                    progressBar2.Value = 100;
                    MessageBox.Show("Vidrio fundido correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    progressBar2.Value = 0;
                    Cursor = Cursors.Default;
                    vidrio = null;
                }
            }
            else
            {
                MessageBox.Show("Encienda la máquina antes de operar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ElegirColor(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Ambar":
                    color = EColor.Ambar;
                    break;
                case "Verde":
                    color = EColor.Verde;
                    break;
                default:
                    color = EColor.Transparente;
                    break;
            }
        }

        private void Moldear(object sender, EventArgs e)
        {
            Vidrio? vidrioActual;
            if (fabrica.Inyectora.Encendido)
            {
                if (vidrios.Count > 0)
                {
                    vidrioActual = vidrios.Dequeue();
                }
                else
                {
                    vidrioActual = null;
                }
                botella = fabrica.Inyectora.InyectarAire(vidrioActual);
                if (botella == null)
                {
                    MessageBox.Show($"Parece que no hay stock de los materiales necesarios:\n" +
                        $"Vidrio: {vidrios.Count}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    botellas.Add(botella);
                    int tiempoEspera = new Random().Next(0, 3000);
                    Cursor = Cursors.WaitCursor;
                    progressBar3.Value = 0;
                    Thread.Sleep(tiempoEspera);
                    progressBar3.Value = 30;
                    Thread.Sleep(tiempoEspera);
                    progressBar3.Value = 60;
                    Thread.Sleep(tiempoEspera);
                    progressBar3.Value = 100;
                    MessageBox.Show("Vidrio moldeado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    progressBar3.Value = 0;
                    Cursor = Cursors.Default;
                    vidrioActual = null;
                }
            }
            else
            {
                MessageBox.Show("Encienda la máquina antes de operar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ControlCalidad(object sender, EventArgs e)
        {
            if (fabrica.ControlCalidad.Encendido)
            {
                Botella? botellaEnProduccion = null;
                foreach (Botella botella in botellas)
                {
                    if (botella.Estado == EEstado.Moldeado)
                    {
                        botellaEnProduccion = botella;
                        break;
                    }
                }

                if (botellaEnProduccion == null)
                {
                    MessageBox.Show($"No hay productos a revisar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool control = fabrica.ControlCalidad.ControlarCalidad(botellaEnProduccion.Calidad);
                    if (!control)
                    {
                        MessageBox.Show("El producto no pasó el estándar de calidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DialogResult respuesta = MessageBox.Show("Se ha producido una unidad de desperdicio.\n¿Desea triturar el vidrio?)", "Trituradora", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                        if (respuesta == DialogResult.OK)
                        {
                            botellaEnProduccion = fabrica.Trituradora.Triturar(botellaEnProduccion, fabrica.Stock);
                        }
                        else
                        {
                            botellasMalaCalidad.Add(botellaEnProduccion);
                        }
                    }
                    else
                    {
                        int tiempoEspera = new Random().Next(0, 2000);
                        Cursor = Cursors.WaitCursor;
                        progressBar4.Value = 0;
                        Thread.Sleep(tiempoEspera);
                        progressBar4.Value = 30;
                        Thread.Sleep(tiempoEspera);
                        progressBar4.Value = 60;
                        Thread.Sleep(tiempoEspera);
                        progressBar4.Value = 100;
                        MessageBox.Show("El producto pasó el estándar de calidad", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        progressBar4.Value = 0;
                        Cursor = Cursors.Default;
                        botellaEnProduccion.Estado = EEstado.Completo;
                    }
                }
            }
            else
            {
                MessageBox.Show("Encienda la máquina antes de operar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Empaquetar(object sender, EventArgs e)
        {
            List<Botella> botellasAEliminar = new List<Botella>();
            int cantidadBotellas = 0;
            if (fabrica.Empaquetadora.Encendido)
            {
                if (botellas.Count > 0)
                {
                    foreach (Botella botella in botellas)
                    {
                        if (botella.Estado == EEstado.Completo)
                        {
                            fabrica.Empaquetadora.Empaquetar(botella, fabrica.Stock);
                            botellasAEliminar.Add(botella);
                            cantidadBotellas++;
                        }
                    }
                    if (botellasAEliminar.Count > 0)
                    {
                        int tiempoEspera = new Random().Next(0, 2000);
                        Cursor = Cursors.WaitCursor;
                        progressBar4.Value = 0;
                        Thread.Sleep(tiempoEspera);
                        progressBar5.Value = 30;
                        Thread.Sleep(tiempoEspera);
                        progressBar5.Value = 60;
                        Thread.Sleep(tiempoEspera);
                        progressBar5.Value = 100;
                        progressBar5.Value = 0;
                        Cursor = Cursors.Default;
                        MessageBox.Show($"La/s {cantidadBotellas} botella/s han sido enviadas al depósito!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("No hay botellas a empaquetar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    foreach (Botella botellaAEliminar in botellasAEliminar)
                    {
                        botellas.Remove(botellaAEliminar);
                    }
                }
                else
                {
                    MessageBox.Show("No hay botellas a empaquetar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Encienda la máquina antes de operar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
