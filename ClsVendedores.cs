using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UHExamen1
{
    internal class ClsVendedores
    {
        public string nombre { get; set; }

        public ClsVendedores() { }


        private static Dictionary<int, string> listaVendedores = new Dictionary<int, string>()
        {
            {1, "Pedro"},
            {2, "Marco"}
        };

        public void listadoVendedores()
        { 
            foreach (var item in listaVendedores)
            {
                Console.WriteLine($"Codigo Vendedor {item.Key} nombre {item.Value}");
            }
        }

        public static string consultaVendedor(int codVendedor)
        {                
            if (listaVendedores.TryGetValue(codVendedor, out string resultado))
            {
                return "nombre del vendedor es" + resultado;
            }
            else
            {
                return "No existe el venderor";
            }
            
        }
    }
}
