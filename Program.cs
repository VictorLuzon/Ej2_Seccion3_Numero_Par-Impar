using System;

namespace Ej_2_Sección_3
{
    //Hacer un programa que le pida al usuario un número y decirle si éste es par o impar.
    class Program
    {
        static void Main(string[] args)
        {
            //Pide al usuario que escriba un numero.
            Console.WriteLine("Escribe un número para decirte si es par o impar:");
            int numero = Int32.Parse(Console.ReadLine());

            //Creamos condición en la que la variable número entra en un if 
            //y si el resto de número es 0 entonces será un numero par, 
            //sino, será impar.
            if(numero % 2 == 0){
                Console.WriteLine($"El número {numero} es par");
            }
            else{
                Console.WriteLine($"El número {numero} es impar.");
            }
        }
    }
}
