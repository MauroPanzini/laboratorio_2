using Modelos;
using Vistas;

namespace main
{
    public partial class Login : Form
    {
        Fabrica fabrica = Program.fabrica;
        public Login()
        {
            InitializeComponent();

        }

        private void IniciarSesion(object sender, EventArgs e)
        {
            bool login = false;
            foreach (Empleado empleado in fabrica.Empleados)
            {
                empleado.Logeado = false;
                if (txtUserName.Text == empleado.Legajo.ToString() && txtPassword.Text == empleado.Clave.ToString())
                {

                    login = true;
                    if (empleado is Operario)
                    {
                        empleado.Logeado = true;
                        new Form2().ShowDialog();
                    }
                    else if (empleado is Supervisor)
                    {
                        empleado.Logeado = true;
                        new Form3().ShowDialog();
                    }
                }

            }
            if (login == false)
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void AutocompletarSupervisor(object sender, EventArgs e)
        {
            txtUserName.Text = fabrica.Empleados[2].Legajo.ToString();
            txtPassword.Text = fabrica.Empleados[2].Clave.ToString();
        }

        private void AutocompletarOperario(object sender, EventArgs e)
        {
            txtUserName.Text = fabrica.Empleados[0].Legajo.ToString();
            txtPassword.Text = fabrica.Empleados[0].Clave.ToString();

        }

        private void lblIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void lblLegajo_Click(object sender, EventArgs e)
        {

        }
    }
}