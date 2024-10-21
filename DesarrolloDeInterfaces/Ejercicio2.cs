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
            double precio_ham = 6.5;
            double precio_papas = 3;
            double precio_bebidad = 3;
            int hamburguesas = 8;
            int papas = 3;
            int bebidas = 10;
            Console.WriteLine("Cantidad a pagar = " + (hamburguesas * precio_ham) + (papas * precio_papas) + (bebidas * precio_bebidad) + "€");
        }
    }
}
