using System;

namespace p4
{
    class Program
    {
        static void Main(string[] args)
        {   
            /*Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba 
            un número por valor y una variable por referencia. Que analice el número y escriba variable recibida
            por referencia con:

            a. 1 si el número es positivo.
            b. -1 si el número es negativo.
            c. 0 si el número es cero.*/
            
            int n, ban = 0;

                            
            Console.WriteLine("Ingrese un nro: ");
            n = int.Parse(Console.ReadLine());

            positivoNegativoCero(n, ref ban);

            
           Console.WriteLine("El estado del valor: " + n + " es: " + ban);


        }

        static void positivoNegativoCero(int a, ref int j){
            if(a == 0)
             j = 0;
            else if(a > 0)
              j = 1;
            else 
              j = -1;
        }
    }
}
