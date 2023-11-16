using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Stock
    {
        private int stockSilicio;
        private int stockSodio;
        private int stockCal;
        private int stockMezcla;
        private int stockCromo;
        private int stockManganeso;
        private int stockVidrioTriturado;


        private List<Botella> stockBotellas = new();
        private Dictionary<string, int> materiales = new();


        private static Stock? instance;

        private Stock(int stockSilicio, int stockSodio, int stockCal, int stockMezcla, int stockCromo, int stockManganeso)
        {
            this.stockSilicio = stockSilicio;
            this.stockSodio = stockSodio;
            this.stockCal = stockCal;
            this.stockMezcla = stockMezcla;
            this.stockCromo = stockCromo;
            this.stockManganeso = stockManganeso;

            materiales.Add("Silicio", stockSilicio);
            materiales.Add("Sodio", stockSodio);
            materiales.Add("Cal", stockCal);
            materiales.Add("Cromo", stockCromo);
            materiales.Add("Manganeso", stockManganeso);
            materiales.Add("Mezcla", stockMezcla);
        }
        /// <summary>
        /// Implementación del patron de diseño Singleton, para que solamente exista una instancia de esta clase. En caso de no existir instancia la
        /// crea; en caso de existir instancia se salta el paso de crearla y solamente la retorna.
        /// </summary>
        /// <param name="stockSilicio"></param>
        /// <param name="stockSodio"></param>
        /// <param name="stockCal"></param>
        /// <param name="stockMezcla"></param>
        /// <param name="stockCromo"></param>
        /// <param name="stockManganeso"></param>
        /// <returns>retorna la instancia existente de la clase</returns>
        public static Stock GetInstance(int stockSilicio, int stockSodio, int stockCal, int stockMezcla, int stockCromo, int stockManganeso)
        {
            instance ??= new Stock(stockSilicio, stockSodio, stockCal, stockMezcla, stockCromo, stockManganeso);
            return instance;
        }

        /// <summary>
        /// Método encargado de consultar el stock de determinado material.
        /// </summary>
        /// <param name="material">Se le pasa el valor asociado al material(la cantidad existente)</param>
        /// <param name="cantidad">Se le pasa la cantidad necesaria para trabajar con ese material</param>
        /// <returns>retorna verdadero o falso en caso de que haya o no stock suficiente del material</returns>
        public bool ConsultarStockMaterial(int material, int cantidad)
        {
            bool result = false;

            if (material >= cantidad)
            {
                result = true;
            }
            return result;
        }


        public Dictionary<string, int> Materiales
        {
            get { return materiales; }
        }
        public int StockSilicio
        {
            get { return stockSilicio; }
            set { stockSilicio = value; }
        }
        public int StockSodio
        {
            get { return stockSodio; }
            set { stockSodio = value; }
        }
        public int StockCal
        {
            get { return stockCal; }
            set { stockCal = value; }
        }
        public int StockCromo
        {
            get { return stockCromo; }
            set { stockCromo = value; }
        }

        public int StockManganeso
        {
            get { return stockManganeso; }
            set { stockManganeso = value; }
        }

        public int StockMezcla
        {
            get { return stockMezcla; }
            set { stockMezcla = value; }
        }

        public List<Botella> StockBotellas
        {
            get { return stockBotellas; }
        }

        public int StockVidrioTriturado
        {
            get { return stockVidrioTriturado; }
            set { stockVidrioTriturado += value; }
        }
    }
}
