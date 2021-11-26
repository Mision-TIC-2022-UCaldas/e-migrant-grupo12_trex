using System;
using System.Threading;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables Globales
            float altura, peso, imc;


            Console.WriteLine("Por favor ingrese su altura en CM!");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese su peso en KG!");
            peso = float.Parse(Console.ReadLine());

            imc = peso / ((altura/100) * (altura/100));

            if(imc<16)
                Console.WriteLine("Delgadez severa");
            else if(imc < 16.99)
                Console.WriteLine("Delgadez Moderada");
            else if(imc < 18.49)
                Console.WriteLine("Delgadez Aceptable");
            else if(imc < 24.99)
                Console.WriteLine("Peso Normal");
            else if(imc < 29.99)
                Console.WriteLine("Sobrepeso");
            else if(imc < 34.99)
                Console.WriteLine("Obesidad Tipo I");
            else if(imc < 39.99)
                Console.WriteLine("Obesidad Tipo II");
            else if(imc < 49.99)
                Console.WriteLine("Obesidad Tipo III o  mórbida");
            else
                Console.WriteLine("Obesidad Extrema");

            Thread.Sleep(1000);
            Console.WriteLine("Hasta Luego");
        }
    }
}
