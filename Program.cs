using System;

namespace Simple_calculator
{
    class Program
    {
        

        static void Main(string[] args)
        {
            double firstNumber;
            double secondNumber;
            string op;
            double result;

            #region firstNumber
            Console.WriteLine("First number");
            firstNumber = Double.Parse(Console.ReadLine());
            #endregion

            #region operator
            Console.WriteLine("Operator");
            op = Console.ReadLine();
            #endregion

            #region secondNumber
            Console.WriteLine("Second number");
            secondNumber = Double.Parse(Console.ReadLine());
            #endregion

            #region result
            if(op == "+")
            {
                result = firstNumber + secondNumber;
                Console.WriteLine(result);
            }
            else if (op == "-")
            {
                result = firstNumber - secondNumber;
                Console.WriteLine(result);
            }
            else if (op == "*")
            {
                result = firstNumber * secondNumber;
                Console.WriteLine(result);
            }

            else if (op == "/")
            {
                result = firstNumber / secondNumber;
                Console.WriteLine(result);
            }
            #endregion

            Console.ReadKey();

        }
    }
}
