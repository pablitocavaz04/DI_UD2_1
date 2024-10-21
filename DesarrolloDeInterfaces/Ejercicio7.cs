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
            Console.Write("Introduce el precio del artículo: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce la cantidad que lleva el cliente: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            double costeTotal = precio * cantidad;
            Console.WriteLine($"El coste total es: {costeTotal}");
        }
    }
}
