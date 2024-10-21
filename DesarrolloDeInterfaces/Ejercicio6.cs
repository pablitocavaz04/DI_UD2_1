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
            Console.WriteLine("Introduce 4 valores numéricos:");

            double suma = 0;

            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"Valor {i}: ");
                suma += Convert.ToDouble(Console.ReadLine());
            }

            double promedio = suma / 4;
            Console.WriteLine($"La suma es: {suma}");
            Console.WriteLine($"El promedio es: {promedio}");
        }
    }
}
