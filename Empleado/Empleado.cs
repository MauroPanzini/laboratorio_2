using System.Globalization;
using System.Reflection.Metadata;
using System.Text;
using System.Transactions;

namespace Modelos
{
    public abstract class Empleado
    {
        protected string nombre;
        protected string apellido;
        protected DateTime fechaNacimiento;
        protected int edad;
        protected int legajo;
        protected int clave;
        protected bool logeado;

        public Empleado(int legajo, int clave)
        {
            nombre = string.Empty;
            apellido = string.Empty;
            fechaNacimiento = DateTime.MinValue;
            this.legajo = legajo;
            this.clave = clave;

        }
        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, int legajo, int clave)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.legajo = legajo;
            this.clave = clave;
            logeado = false;
            this.edad = CalcularEdad();
        }
        /// <summary>
        /// Método encargado de calcular la edad utilizando la fecha de nacimiento.
        /// </summary>
        /// <returns>retorna la edad como entero</returns>
        private int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            if (this.fechaNacimiento.Date > fechaActual.AddYears(-edad))
            {
                edad--;
            }
            return edad;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }
        public string Apellido
        {
            get
            {
                return apellido;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }
        }

        public int Legajo
        {
            get
            {
                return legajo;
            }
        }

        public int Clave
        {
            get { return clave; }
        }
        public bool Logeado
        {
            get { return logeado; }
            set { logeado = value; }

        }
    }

}