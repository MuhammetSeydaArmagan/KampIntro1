﻿using System;

namespace DegerveReferansTıpler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
        }
    }
}
