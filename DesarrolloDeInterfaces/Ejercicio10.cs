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
            Console.Write("Introduce un string: ");
            string input = Console.ReadLine();

            bool empiezaConWWW = input.StartsWith("www");
            Console.WriteLine($"¿El string comienza con 'www'? {empiezaConWWW}");
        }
    }
}
