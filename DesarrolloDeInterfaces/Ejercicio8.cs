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
            Console.Write("Introduce la primera calificación parcial: ");
            double calificacion1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce la segunda calificación parcial: ");
            double calificacion2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce la calificación del examen: ");
            double examen = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce la calificación del trabajo final: ");
            double trabajoFinal = Convert.ToDouble(Console.ReadLine());

            double notaFinal = (calificacion1 + calificacion2) / 2 * 0.5 + examen * 0.3 + trabajoFinal * 0.2;
            Console.WriteLine($"Tu nota final es: {notaFinal}");
        }
    }
}
