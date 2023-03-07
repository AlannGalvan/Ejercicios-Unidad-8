using System;

namespace p2
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es.
            // Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

            int n, conPar= 0;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un nro: ");
                n = int.Parse(Console.ReadLine());

                //bool esPar = par(n);
                //if(esPar == true)
                if(par(n)) //o (par(n) == true)
                  conPar++;

                // if(par(n) == 1)
                //   conPar++;

            }
            Console.WriteLine("El total de números pares son: " + conPar);
        }



        static bool par(int n){
            if(n % 2 == 0)
              return true;
            else
               return false;
        
                
        }

        // static int par(int n){
        //     if(n % 2 == 0)
        //       return 1;
        //     else
        //        return 0;
        
                
        // }
    }
}
