using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Trituradora:Maquinaria
    {
        public Trituradora(string nombreDeMaquina)
        :base(nombreDeMaquina)
        {
            this.tipoDeMaquina = ETipoDeMaquina.Produccion;
        }

        /// <summary>
        /// Método encargado de procesar las botellas de mala calidad y transformarlas en polvo de vidrio.
        /// </summary>
        /// <param name="botella">recibe la botella de mala calidad</param>
        /// <param name="stock">recibe la instancia donde realizará los cambios de stock</param>
        /// <returns>retorna la botella recibida pero con valor null, para que sea descartada por el programa</returns>
        public Botella? Triturar(Botella? botella, Stock stock)
        {
            botella = null;
            stock.StockVidrioTriturado = 1;
            return botella;
        }
    }
}
