using System;

namespace UHExamen1
{
    public class ClsArticulo
    {
        static private int i, opcion, x;
        protected int[] codigo { get; set; } = new int[5];
        protected string[] nombre { get; set; } = new string[5];
        protected int[] precio { get; set; } = new int[5];
        public ClsArticulo(int[] codigo, string[] nombre, int[] precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
        }

        public ClsArticulo()
        {

        }



        ClsArticulo producto = new ClsArticulo();
        
        public void agregarArticulo()
        {
            int num = 1;
            for (i = 0; i < 1; i++)
            {
                Console.WriteLine($"Ingrese el codigo del Articulo numero {num}");
                codigo[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el nombre del Articulo");
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el precio del Articulo");
                precio[i] = int.Parse(Console.ReadLine());
                num++;

            }
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadKey();

        }

        public void removerArticulo() {

            listaArticulos();

            Console.WriteLine("Ingrese el Numero del articulo que desea borrar");
            opcion = int.Parse(Console.ReadLine());
            for (x = 0; x < 1; x++)
            {
                if (codigo[i] == opcion)
                {
                    codigo[i] = 0;
                    nombre[i] = "";
                    precio[i] = 0;
                }
            }
            Console.WriteLine("El elemento ha sido borrado");


        }

        public void listaArticulos() {
            for ( x = 0; x < 1; x++)
            {
                Console.WriteLine($"Codigo {codigo[x]} Nombre {nombre[x]} Precio {precio[x]}");

            }


        }
    } 
}
