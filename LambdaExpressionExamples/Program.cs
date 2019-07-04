using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int,int,int> addMethodHandler = (x,y) =>
            {
                int r =  x + y;
                return r;
            };

            Action<string> method = (message) =>
            {
                Console.WriteLine(message);
            };





            int result = addMethodHandler(4, 10);
            method(result.ToString());
            Console.ReadKey();

        }

        static int Add(int firstNumber, int secondNumber)
        {

            return firstNumber + secondNumber;
        }

        static int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
