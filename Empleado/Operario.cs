using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Operario:Empleado
    {
        public Operario(string nombre, string apellido, DateTime fechaNacimiento, int legajo, int contraseña)
        :base(nombre, apellido, fechaNacimiento, legajo, contraseña)
        {

        }

    }
}
