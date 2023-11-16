using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Mezcladora : Maquinaria
    {
        private int rpm;

        public Mezcladora(string nombreDeMaquina)
        : base(nombreDeMaquina)
        {
            rpm = 0;
            tipoDeMaquina = ETipoDeMaquina.Produccion;
        }

        public int Rpm
        {
            get { return rpm; }
            set { rpm = value; }
        }
        public string Nombre
        {
            get
            {
                return nombreDeMaquina;
            }
        }

        /// <summary>
        /// Método encargado de restar el stock de los materiales que se necesitan para crear mezcla. 
        /// Aumenta en 5 de mezcla por cada 15 de cal, 15 de sodio, y 70 de silicio.
        /// </summary>
        /// <param name="stock">se le pasa la instancia de donde sacar los materiales</param>
        /// <returns>retorna verdadero en caso de concretar la operacion, falso si no pudo por falta de materiales</returns>
        public bool Mezclar(Stock stock)
        {
            if (stock.StockSilicio > 69 && stock.StockSodio > 14 && stock.StockCal > 14)
            {
                stock.StockCal -= 15;
                stock.StockSodio -= 15;
                stock.StockSilicio -= 70;
                stock.StockMezcla += 5;

                return true;
            }

            return false;
        }
    }
}
