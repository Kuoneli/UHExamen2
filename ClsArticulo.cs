using System;

namespace UHExamen1
{
    public class ClsArticulo
    {
        static private int i, opcion, x, num = 0, total;
        protected int codigo { get; set; }
        protected string nombre { get; set; }
        protected int precio { get; set; }

        public ClsArticulo(int codigo, string nombre, int precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
        }

        public ClsArticulo()
        {

        }


       static ClsArticulo[] listaArticulos = new ClsArticulo[5];
        public void agregarArticulo()
        {
            
            for (i = 0; i < listaArticulos.Length; i++)
            {
                Console.WriteLine($"Ingrese el codigo del Articulo numero {num+1}");
                codigo= int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el nombre del Articulo");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el precio del Articulo");
                precio = int.Parse(Console.ReadLine());

               listaArticulos[i] = new ClsArticulo(codigo, nombre, precio);
               num++;
            }
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadKey();

        }

        public void removerArticulo() {

            verArticulos();

            Console.WriteLine("Ingrese el Codigo del articulo que desea borrar");
            opcion = int.Parse(Console.ReadLine());
            for (x = 0; x < listaArticulos.Length; x++)
            {
                if (listaArticulos[x].codigo == opcion)
                {
                    listaArticulos[x].codigo = 0;
                    listaArticulos[x].nombre = "";
                    listaArticulos[x].precio = 0;
                    Console.WriteLine("El elemento ha sido borrado\n");
                }
                else
                {
                    Console.WriteLine("El articulo no existe");
                }
            }


        }

        public void verArticulos()
        {
            Console.WriteLine("Detalles de los articulos:\n");
            for (x = 0; x < num; x++)
            {
                Console.WriteLine($"Codigo: {listaArticulos[x].codigo} Precio: {listaArticulos[x].precio} Nombre: {listaArticulos[x].nombre}");
            }
            Console.WriteLine("\nFin de los detalles\n");
        }

        public void venta()
        {
            Console.WriteLine("Consultar existencia. \nIngrese el Codigo del articulo:");
            opcion = int.Parse(Console.ReadLine());
            for (x = 0; x < listaArticulos.Length; x++)
            {
                if (listaArticulos[x].codigo == opcion)
                {
                    Console.WriteLine($"Detalles del producto. \nPrecio: {listaArticulos[x].precio} \nNombre: {listaArticulos[x].nombre}");
                    Console.WriteLine("\nCuantos deses adquirir");
                    opcion = int.Parse(Console.ReadLine());
                    total = opcion * listaArticulos[x].precio;
                    Console.WriteLine($"\nEl total a cancelar es {total}");
                    
                }
                else
                {
                    Console.WriteLine("El producto no existe");
                }

            }
        }

        public void existenciaArticulo()
        {
            Console.WriteLine("Consultar existencia. \nIngrese el Codigo del articulo:");
            opcion = int.Parse(Console.ReadLine());
            for(x = 0; x < listaArticulos.Length; x++)
            {
                if (listaArticulos[x].codigo == opcion) { 
                    Console.WriteLine($"Detalles del producto. \nPrecio: {listaArticulos[x].precio} \nNombre: {listaArticulos[x].nombre}");
                }
                else
            {
                Console.WriteLine("El producto no existe");
            }

            }
        
        }
    } 
}
