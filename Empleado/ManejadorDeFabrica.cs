using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public static class ManejadorDeFabrica
    {
        private static Fabrica fabricaComun = new();

        public static Fabrica ObtenerInstancia()
        {
            return fabricaComun;
        }
    }
}
