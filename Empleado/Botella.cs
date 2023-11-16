using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Botella:Vidrio
    {
        public Botella(ECalidad calidad, EColor color, EEstado estado)
        :base(calidad, color, estado)
        {
        }
    }
}
