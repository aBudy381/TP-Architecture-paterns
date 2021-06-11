using System;
using Icalculatrice;

namespace Calculatrice
{
    public class Calcule
    {
        calculeBasic cb;
        //CalculAvance ca;



    }
     public class calculeBasic: IcalculeBasic
    {
        
       
        static int number1;
        static int number2;
       


    static public int Addition(int number1, int number2)
        {
            return number1 + number2;
        }
        static public int Substract(int number1, int number2)
        {
            return number1 - number2;
        }
        static public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static public int Devide(int number1, int number2)
        {
            return number1 / number2;
        }




    }
    /*public class CalculAvance : IcalculeAvance
    {
        static public int Addition(int number1, int number2)
        {
            return number1 + number2;
        }
    }*/
   
}
