using System;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos.
            // Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el
            // monto total a pagar. Usar la función.

            int precio = 0, cantidad = 0, montoPagar;

            pedirDatos(ref precio, ref cantidad);

            montoPagar = producto(precio, cantidad);

            Console.WriteLine("El monto a pagar es de: $" + montoPagar);

           
           
        }






        static int producto(int a, int b){
            int resultado;
            resultado = a * b;
            return resultado;
        }

        static void pedirDatos(ref int precio, ref int cantidad){
            Console.WriteLine("Ingrese el precio del articulo: ");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad: ");
            cantidad = int.Parse(Console.ReadLine());
        }
             

    }
}
