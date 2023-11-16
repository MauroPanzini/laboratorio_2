using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Vidrio
    {
        protected ECalidad calidad;
        protected EColor color;
        protected EEstado estado;

        public Vidrio(ECalidad calidad, EColor color, EEstado estado)
        {
            this.calidad = calidad;
            this.color = color;
            this.estado = estado;
        }

        public ECalidad Calidad
        {
            get { return calidad; }
            set { calidad = value; }
        }
        public EColor Color
        {
            get { return color; }
            set { color = value; }
        }
        public EEstado Estado
        {
            get { return estado; }
            set { estado = value; }

        }
    }
}
