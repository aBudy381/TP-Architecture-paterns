using System;
using Calculatrice;

namespace Calculatrice
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine(CalculBasic.Addition(2, 4));
            Console.WriteLine(CalculBasic.Substract(2, 4));
            Console.WriteLine(CalculBasic.Multiply(2, 4));
            Console.WriteLine(CalculBasic.Devide(2, 4));
        }
    }
   
}
