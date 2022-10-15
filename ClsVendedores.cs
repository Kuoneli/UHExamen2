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
        static int codVendedor;
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
            Console.WriteLine("\n");    
        }

        public string consultaVendedor()
        {
            
                Console.WriteLine("Ingrese el codigo del Vendedor");
                codVendedor = int.Parse(Console.ReadLine());
                if (listaVendedores.TryGetValue(codVendedor, out string resultado))
                {
                    return "El bombre del vendedor es " + resultado + "\n";
                }
                else
                {
                    return "No existe el venderor \n";
                }
            
        }
        
    }
}
