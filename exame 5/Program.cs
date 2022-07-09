using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exame_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i;
            Console.WriteLine(" Números pares de 0 á 100 :");
            for (i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}
