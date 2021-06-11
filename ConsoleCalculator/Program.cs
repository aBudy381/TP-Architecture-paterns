using System;


namespace ConsoleCalculator { 

    class Program 
    {
        delegate int OperationDelegate(int number1, int number2);
        static OperationDelegate operation;
        static double FirstNumber;
        static double SecondNumber;
        static double selectedOperation;
        static double continueOperating;
       

        public static double Addition()
        {
            return FirstNumber + SecondNumber;
            
        }
        public static double Substraction()
        {
            return FirstNumber - SecondNumber;
        }
        public static double Multiplication()
        {
            return FirstNumber * SecondNumber;
        }
        public static double Division()
        {
            return FirstNumber / SecondNumber;
        }
        public static void operatingResult()
        {
            Console.WriteLine("\t\t\tWelcome to the C# Calculator\n");
            Console.WriteLine("\t\t\t****************************\n");
            Console.WriteLine("\t\t\tSelect an action before starting\n");
            Console.WriteLine("\t\t\t**1-Add**\n");
            Console.WriteLine("\t\t\t**2-Substract**\n");
            Console.WriteLine("\t\t\t**3-Multiply**\n");
            Console.WriteLine("\t\t\t**4-Devide**\n");

            selectedOperation = double.Parse(Console.ReadLine());
            if (selectedOperation != 0 && selectedOperation <= 4)
            {
                Console.WriteLine("you have have selected : " + operation);
                
            }
            else
            {
                Console.WriteLine("Invalid Entry, Please try again");
                
            }

            Console.WriteLine("\t\t\tPlease enter the first number\n");
            FirstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("\t\t\tPlease enter the second number\n");
            SecondNumber = double.Parse(Console.ReadLine());
            if (selectedOperation == 1)
            {
                Console.WriteLine("The operation result is : " + Addition());
            }
            else if (selectedOperation == 2)
            {
                Console.WriteLine(Substraction());
            }
            else if (selectedOperation == 3)
            {
                Console.WriteLine(Multiplication());
            }
            else if ( selectedOperation == 4)
            {
                Console.WriteLine(Division());
            }
            else Console.WriteLine("Invalid Entry!");

        }
        static void Main(string[] args)
        {
            operatingResult();
            Console.WriteLine("Do you want to continue operating?\n0-Yes\n1-No");
            continueOperating = double.Parse(Console.ReadLine());

            switch (continueOperating){
                case 0:
                    operatingResult();
                    break;
                case 1:
                    Console.WriteLine("Exiting...");
                    Environment.Exit(0);
                    break;
                default:
                    break;

            }


           
            //while (continueOperating ==true)
            //{
              //  operatingResult();
            //}
        
           

        }

        //Methods
       
    }
}
