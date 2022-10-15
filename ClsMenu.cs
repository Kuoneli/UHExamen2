using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UHExamen1
{
    
    public static class ClsMenu
    {
        static int opcion;
        static bool estadia = true;

        
        public static void menu()
        {

            do
            {
                Console.WriteLine("Menu inicial" + "\n1-Articulo. \n2-Facturacion. \n3-Reporte. \n4-Salir. " +
                 "Digite la opcion deseada");                
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Seccion de Articulos. \nDesea 1-Agregar Articulos 2-Remover Articulos 3-Consultar Articulo");
                        opcion = int.Parse(Console.ReadLine());
                        ClsArticulo articulo = new ClsArticulo();

                        switch (opcion)
                        {
                            case 1:
                                articulo.agregarArticulo();
                                break;
                            case 2:
                                articulo.removerArticulo();

                                break;
                            case 3:
                                articulo.listaArticulos();
                                break;
                            default:
                                Console.WriteLine("La opcion no existe");
                                
                                   break;
                        }
                        break;
                    case 2:
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del Sistema.");
                        Console.ReadKey();
                        break;
                   default:
                        Console.Clear();
                        Console.WriteLine("La opcion ingresada no es valida. \nIntente de nuevo.\n");
                        
                        break;


                }
            } while (opcion != 4);
            Console.Write("Gracias por su estadia. \nVuelva pronto");

         
            

        }
    }
}
