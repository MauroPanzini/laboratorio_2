using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public abstract class Maquinaria
    {
        protected string nombreDeMaquina;
        protected ETipoDeMaquina tipoDeMaquina;
        protected bool encendido;
        protected bool enProduccion;
        public Maquinaria(string nombreDeMaquina)
        {
            this.nombreDeMaquina = nombreDeMaquina;
            this.encendido = false;
            this.enProduccion = false;
        }
        public bool Encendido
        {
            get { return encendido; }
            set { encendido = value; }
        }

        public bool EnProduccion
        {
            get { return enProduccion; }
            set { enProduccion = value; }
        }
    }
}
