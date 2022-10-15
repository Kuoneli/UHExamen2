using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UHExamen1
{

   
    internal class ClsCategorias
    {

        List<int> categorias = new List<int>();
        
        public void listadoCategorioas()
        {
            categorias.Add(1);
            categorias.Add(2);
            categorias.Add(3);

        }



        public void promocion()
        {

        }
        public void listadoCategorias()
        {

        }
        public bool existeCategoria(int numero)
        {
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
