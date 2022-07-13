using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1dejorgeojeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Double dolares;

            Console.Write("colocar la cantidad de dolares que desea convertir  ");
            dolares = double.Parse(Console.ReadLine());

             if (dolares > 0)
                Console.WriteLine($"la cantidad de pesos en dolar oficial es {dolares * 230} pesos");
             else
            {
                Console.Write("ingrese un numero valido..");
            }



            if (dolares > 0)
                Console.WriteLine($"la cantidad de pesos en dolar Paralelo es {dolares * 280} pesos");
            else
            {
                Console.Write("ingrese un numero valido..");
            }

            if (dolares > 0)
                Console.WriteLine($"la cantidad de dolares es {dolares * 1.17} Euros");
            else
            {
                Console.Write("ingrese un numero valido..");
            }

            Console.ReadKey();
        
        }
    }
}
