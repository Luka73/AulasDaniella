using Aula01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculos c1 = new Calculos();
            Console.WriteLine("Resultado da Soma: " + c1.Soma(7, 8));
            Console.WriteLine("Resultado da Soma: " + c1.Soma(7, 8, 9));

            Console.WriteLine("Daniela");
            Console.WriteLine(3);
            Console.WriteLine(4.5);
            Console.WriteLine(true);
            Console.WriteLine(c1);

            Console.ReadKey();
        }
    }
}
