using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Fabrica
    {
        private List<Empleado> empleados = new();
        private Operario op2;
        private Operario op1;
        private Supervisor sup1;
        private Supervisor sup2;
        private Stock stock;
        private Mezcladora mezcladora;
        private Fundidora fundidora;
        private Inyectora inyectora;
        private ControlCalidad controlCalidad;
        private Empaquetadora empaquetadora;
        private Trituradora trituradora;

        public Fabrica()
        {
            op1 = new("Juan","Perez",new DateTime(1990,10,10),110,1234);
            op2 = new("Horacio", "Picana", new DateTime(1970, 05, 27), 111, 1234);
            sup1 = new("Emanuela", "Montana", new DateTime(1981, 06, 21), 115, 1234);
            sup2 = new("Julio", "Roca", new DateTime(1968, 11, 09), 117, 1234);

            stock = Stock.GetInstance(100,100,100,0,100,100);

            mezcladora = new("MixGlass2000 - 90RPM");
            fundidora = new("Fundetron1500");
            inyectora = new("Soplamatic2000");
            controlCalidad = new("Controlato2.0");
            empaquetadora = new("EmpaqueneticPlus");
            trituradora = new("DestrozaGlass5000");

            empleados.Add(op1);
            empleados.Add(op2);
            empleados.Add(sup1);
            empleados.Add(sup2);
        }

        public List<Empleado> Empleados
        {
            get { return empleados; }
        }
        public Stock Stock
        {
            get { return stock; }
        }

        public Mezcladora Mezcladora { get => mezcladora; }
        public Fundidora Fundidora { get => fundidora; }
        public Inyectora Inyectora { get => inyectora; }
        public ControlCalidad ControlCalidad { get => controlCalidad; }
        public Empaquetadora Empaquetadora { get => empaquetadora;}
        public Trituradora Trituradora { get => trituradora;}
        
        /// <summary>
        /// Método encargado de agregar la cantidad deseada de stock a la lista correspondiente.
        /// </summary>
        /// <param name="materiaPrima">se le pasa la instancia donde tiene que agregarse el stocl</param>
        /// <param name="material">se le pasa el nombre del material, proveniente de un combobox</param>
        /// <param name="cantidad">se le pasa la cantidad a agregar</param>
        public void AgregarInventario(Stock materiaPrima, string material, int cantidad)
        {
            switch (material)
            {
                case "Silicio":
                    materiaPrima.StockSilicio += cantidad;
                    break;
                case "Sodio":
                    materiaPrima.StockSodio += cantidad;
                    break;
                case "Cal":
                    materiaPrima.StockCal += cantidad;
                    break;
                case "Cromo":
                    materiaPrima.StockCromo += cantidad;
                    break;
                case "Manganeso":
                    materiaPrima.StockManganeso += cantidad;
                    break;
            }
        }
    }

}
