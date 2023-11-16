using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Fundidora : Maquinaria
    {
        protected int temperatura;
        public Fundidora(string nombreDeMaquina)
        : base(nombreDeMaquina)
        {
            temperatura = 0;
            tipoDeMaquina = ETipoDeMaquina.Produccion;
        }

        public int Temperatura
        {
            get { return temperatura; }
            set { temperatura = value; }
        }

        /// <summary>
        /// Método encargado de transformar la mezcla en vidrio. Acá se agrega el color y se cambia el estado del producto.
        /// También se implementa la calidad del vidrio por medio de la temperatura. Solamente funciona si hay mezlca disponible.
        /// </summary>
        /// <param name="stock">instancia donde consulta el stock, y resta en caso de utilizar color</param>
        /// <param name="color">color que será el vidrio</param>
        /// <returns>retorna un objeto de tipo Vidrio, que admite ser null si no se cumplen los requisitos de stock</returns>
        public Vidrio? Fundir(Stock stock, EColor color)
        {
            if (stock.StockMezcla > 0)
            {
                Vidrio vidrio = new(ECalidad.NoDefinido, color, EEstado.Fundido);
                stock.StockMezcla--;

                if (temperatura > 1299)
                {
                    vidrio.Calidad = ECalidad.Bueno;
                }
                else
                {
                    vidrio.Calidad = ECalidad.Regular;
                }

                switch (color)
                {
                    case EColor.Ambar:
                        if (stock.ConsultarStockMaterial(stock.StockManganeso, 1))
                        {
                            vidrio.Color = color;
                            stock.StockManganeso--;
                        }
                        else { return null; }
                        break;
                    case EColor.Verde:
                        if (stock.ConsultarStockMaterial(stock.StockCromo, 1))
                        {
                            vidrio.Color = color;
                            stock.StockCromo--;
                        }
                        else { return null; }
                        break;
                    default:
                        break;
                }
                return vidrio;
            }
            return null;
        }



    }
}
