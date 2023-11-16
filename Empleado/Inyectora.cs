using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Inyectora : Maquinaria
    {
        private float presion;

        public Inyectora(string nombreDeMaquina)
        : base(nombreDeMaquina)
        {
            presion = 0;
            tipoDeMaquina = ETipoDeMaquina.Produccion;
        }

        public float Presion
        {
            get { return presion; }
            set { presion = value; }
        }

        /// <summary>
        /// Método encargado de crear una botella. El método lee los valores de la máquina y en base
        /// a eso determina la calidad de la botella que está creando.
        /// </summary>
        /// <param name="vidrio">Recibe un objeto de tipo vidrio, del cual se toman los datos que serán enviados a la botella. 
        /// Puede ser null si no hay existencias de vidrio para trabajar</param>
        /// <returns>retorna un objeto del tipo botella, que puede ser null en caso de que la máquina no pueda cumplir su responsabilidad</returns>
        public Botella? InyectarAire(Vidrio? vidrio)
        {
            if (vidrio != null)
            {
                Botella botella = new(vidrio.Calidad, vidrio.Color, EEstado.Moldeado);
                if (presion > 699)
                {
                    botella.Calidad = ECalidad.Bueno;
                }
                else if (presion < 500)
                {
                    botella.Calidad = ECalidad.Malo;
                }
                else
                {
                    botella.Calidad = ECalidad.Regular;
                }
                return botella;
            }
            return null;
        }
    }

}
