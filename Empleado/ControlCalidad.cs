using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ControlCalidad : Maquinaria
    {
        public ControlCalidad(string nombreDeMaquina)
        : base(nombreDeMaquina)
        {

        }
        /// <summary>
        /// Función que controla qué valor tiene el atributo calidad, dando el visto bueno o no del producto.
        /// </summary>
        /// <param name="calidad">Se le pasa el valor del atributo calidad</param>
        /// <returns>retorna verdadero en caso de que el producto pase el control (valor de atributo regular o bueno)
        /// o falso en caso de que no lo pase (valor de atributo malo)</returns>
        public bool ControlarCalidad(ECalidad calidad)
        {
            bool result = false;

            if (calidad == ECalidad.Bueno || calidad == ECalidad.Regular)
            {
                result = true;
            }
            return result;
        }
    }
}
