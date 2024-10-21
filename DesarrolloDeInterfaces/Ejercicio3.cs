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
            Console.Write("Introduce el valor de un lado del cuadrado: ");
            double lado = Convert.ToDouble(Console.ReadLine());
            double perimetro = 4 * lado;
            Console.WriteLine($"El perímetro del cuadrado es: {perimetro}");
        }
    }
}
