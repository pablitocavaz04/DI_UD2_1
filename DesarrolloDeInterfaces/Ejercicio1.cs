using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloDeInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La suma de los dos numeros es" + (num1 + num2));
            Console.WriteLine("La resta de los dos numeros es" + (num1 - num2));
            Console.WriteLine("La multiplicaion de los dos numeros es" + (num1 * num2));
            Console.WriteLine("La division de los dos numeros es" + (num1 / num2));
            Console.WriteLine("El modulo de los dos numeros es" + (num1 % num2));


        }
    }
}
