using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UHExamen1
{
    internal class ClsVendedor2 : ClsVendedores, ClsInterfaces.Ivendedor2
    {
        private string nombre { get; set; }

        public ClsVendedor2(string nombre)
        {
            this.nombre = "Marco";
        }


        public string ventasCredito()
        {
            return $"Con {nombre}, puede comprar a credito";

        }
    }
}
