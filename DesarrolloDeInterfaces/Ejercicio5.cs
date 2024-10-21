using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloDeInterfaces
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduce 4 números:");

            Console.Write("Número 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 4: ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            int suma = num1 + num2;
            int producto = num3 * num4;

            Console.WriteLine($"La suma de los dos primeros es: {suma}");
            Console.WriteLine($"El producto del tercero y cuarto es: {producto}");
        }
    }
}
