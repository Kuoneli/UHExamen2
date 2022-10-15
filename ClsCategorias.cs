using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UHExamen1
{

   
    internal class ClsCategorias
    {
        static int numero;
        List<int> categorias = new List<int>()
        {
            1,
            2,
            3,
        };



        public void promocion()
        {

        }

        public void listaCategorias()
        {
            Console.WriteLine($"Lista de Categorias: ");
            foreach (var item in categorias)
            {
            Console.WriteLine($"Categoria: {item}");    
            }
            Console.WriteLine();
}


        public bool existeCategoria()
        {
            Console.WriteLine("Ingrese la categoria que desea consultar: ");
            numero = int.Parse(Console.ReadLine());

            if (categorias.Contains(numero))
            {
                Console.WriteLine($"La categoria {numero}");
                return true;
            }
            else
            return true;
        }
    }

      
   
}
