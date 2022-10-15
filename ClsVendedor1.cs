using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UHExamen1
{
    internal class ClsVendedor1 : ClsVendedores, ClsInterfaces.Ivendedor1
    {
        public ClsVendedor1(string nombre)
        {
            nombre = "Pedro"; 
        }

        public void ventasContado()
        {
            Console.WriteLine($"Con {nombre}, puede comprar de Contado");
        }
    }
}
