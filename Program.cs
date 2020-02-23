using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Operation (+ - * /) = ");
            string new_operator = Console.ReadLine();
            Console.Write("y = ");
            double y = Convert.ToDouble(Console.ReadLine());
            switch (new_operator)
             {
                 case "+":
                     Console.WriteLine("Result = {0}", x + y);
                     break;
                case "-":
                    Console.WriteLine("Result = {0}", x - y);
                    break;
                case "*":
                    Console.WriteLine("Result = {0}", x * y);
                    break;
                case "/":
                    Console.WriteLine("Result = {0}", x / y);
                    break;
             }
            
        }
    }
}
