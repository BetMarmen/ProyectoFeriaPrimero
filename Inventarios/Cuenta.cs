using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventarios
{
    public class Cuenta
    {
        public string NombreCuenta { get; set; }
        public Double Monto { get; set; }
        public Cuenta(string nombreCuenta, Double monto)
        {
            NombreCuenta = nombreCuenta;
            Monto = monto;
        }
    }
}
