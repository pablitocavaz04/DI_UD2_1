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
            Console.Write("Introduce la cantidad que aporta el socio 1: ");
            double socio1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce la cantidad que aporta el socio 2: ");
            double socio2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce la cantidad que aporta el socio 3: ");
            double socio3 = Convert.ToDouble(Console.ReadLine());

            double total = socio1 + socio2 + socio3;

            double porcentaje1 = (socio1 / total) * 100;
            double porcentaje2 = (socio2 / total) * 100;
            double porcentaje3 = (socio3 / total) * 100;

            Console.WriteLine($"El porcentaje del socio 1 es: {porcentaje1:F2}%, del socio 2 es: {porcentaje2:F2}%, y del socio 3 es: {porcentaje3:F2}%");
        }
    }
}
