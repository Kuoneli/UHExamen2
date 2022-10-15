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

        static ClsArticulo articulo = new ClsArticulo();
        static ClsVendedores vendedor = new ClsVendedores();
        static ClsCategorias categorias = new ClsCategorias();

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
                        Console.Clear();
                        Console.WriteLine("Seccion de Articulos. \nDesea 1-Agregar Articulos \n2-Remover Articulos \n3-Consultar Articulo");
                        opcion = int.Parse(Console.ReadLine());

                        switch (opcion)
                        {
                            case 1:
                                articulo.agregarArticulo();
                                break;
                            case 2:
                                articulo.removerArticulo();
                                break;
                            case 3:
                                articulo.existenciaArticulo();
                                break;
                            default:
                                Console.WriteLine("La opcion no existe");
                                   break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Seccion de Facturacion.");
                        articulo.venta();
                        Console.WriteLine(vendedor.consultaVendedor());

                        break;
                    case 3:
                        articulo.verArticulos();                        
                        vendedor.listadoVendedores();
                        categorias.listaCategorias(); 

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
