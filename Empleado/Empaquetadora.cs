using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Empaquetadora:Maquinaria
    {
        public Empaquetadora(string nombreDeMaquina) 
        :base(nombreDeMaquina)
        {
            tipoDeMaquina = ETipoDeMaquina.Embalado;    
        }

        /// <summary>
        /// Método encargado de agregar las botellas que recibe al stock de botellas.
        /// </summary>
        /// <param name="botella">botella que pasó el control de calidad y está lista para ser enviada a depósito.</param>
        /// <param name="stock">la instancia de stock donde se almacena la botella.</param>
        public void Empaquetar(Botella botella, Stock stock)
        {
            stock.StockBotellas.Add(botella);
        }
    }
}
