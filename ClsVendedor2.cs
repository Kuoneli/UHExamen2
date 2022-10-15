using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UHExamen1
{
    internal class ClsVendedor2 : ClsVendedores, ClsInterfaces.Ivendedor2
    {
        public ClsVendedor2(string nombre)
        {
            nombre = "Marco";
        }

        public string ventasCredito()
        {
            return $"Con {nombre}, puede comprar a credito";

        }
    }
}
