﻿using System;
using System.Linq;

class PrintSequence
{
    static void Main()
    {
        for (int i = 2, j = -3; i <= 10; i += 2, j -= 2)
        {
            Console.WriteLine(i);
            Console.WriteLine(j);
        }
    }
}