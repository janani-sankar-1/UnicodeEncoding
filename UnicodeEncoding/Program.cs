using System;
using System.Collections.Generic;

namespace UnicodeEncoding
{
     class Program
    {
        static void Main(string[] args)
        {
            string mytext = "\u0543";
            Console.WriteLine(mytext);
            string mytext2 = "Ɏ";
            Console.WriteLine(mytext2);
            Console.ReadKey();

        }
    }
}
