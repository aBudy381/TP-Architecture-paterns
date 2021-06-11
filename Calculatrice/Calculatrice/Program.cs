using System;
using Calculatrice;

namespace Calculatrice
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine(calculeBasic.Addition(2, 4));
            Console.WriteLine(calculeBasic.Substract(2, 4));
            Console.WriteLine(calculeBasic.Multiply(2, 4));
            Console.WriteLine(calculeBasic.Devide(2, 4));
        }
    }
   
}
