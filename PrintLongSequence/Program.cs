using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintLongSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2, j = -3; i <= 1000; i += 2, j -= 2)
            {
                Console.WriteLine(i);
                Console.WriteLine(j);
            }
        }
    }
}
