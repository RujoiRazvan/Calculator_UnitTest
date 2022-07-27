using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
 
        public static void Main(string[] args)
        {
            int firstNumber = 0, secondNumber = 0;
            double result = -1.5;
            string op, exitCommand;
            bool exit = false;
            Console.WriteLine("Simple Calculator. Insert only integer numbers (example: 4, 15, -51)");
            while (exit == false)
            {
                Console.Write("Insert first number: ");
                try
                {
                    firstNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error...");
                }

                Console.Write("Insert second number: ");
                try
                {
                    secondNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error...");
                }


                Console.Write("Insert your operator (+, -, *, /): ");
                op = Console.ReadLine();


                switch (op)
                {
                    case "+":
                        result = add(firstNumber, secondNumber);
                        Console.WriteLine("Result of addition is: " + result);
                        break;
                    case "-":
                        result = sub(firstNumber, secondNumber);
                        Console.WriteLine("Result of substraction is: " + result);
                        break;
                    case "*":
                        result = multiplication(firstNumber, secondNumber);
                        Console.WriteLine("Result of multiplication is: " + result);
                        break;
                    case "/":
                        result = division(firstNumber, secondNumber);
                        Console.WriteLine("Result of division is: " + result);
                        break;
                    default: break;
                }
                Console.WriteLine("Do you want to continue ? (y/n)");
                exitCommand = Console.ReadLine();
                if (exitCommand.Equals("y"))
                    exit = false;
                else if(exitCommand.Equals("n")) exit = true;
            }
        }
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int sub(int a, int b)
        {
            return a - b;
        }
        public static int multiplication(int a, int b)
        {
            return a * b;
        }
        public static double division(int a, int b)
        {
            return (double)a / (double)b;
        }
    }
}
