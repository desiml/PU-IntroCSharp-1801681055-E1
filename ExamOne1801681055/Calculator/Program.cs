using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = 20.78;
            Console.WriteLine("Enter opeation:");
            string operator= Console.ReadLine();

            switch (operator)
            {
                case "+;"
                double sum = a + b;
                double withPercentage = sum + (sum * (10 / 100));
                Console.WriteLine($"Result is:{withPercentage}");
                break;

              case "-";
                break;
              case "*";
                break;
              case "/"
                break;


            default:
                Console.WriteLine("No such operator");
               break;
            }
        }
    }
}
