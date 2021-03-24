using System;
using System.Collections.Generic;
using System.Text;

namespace Exec
{
    class Program
    {
        static void Main(string[] args)
        {
            MathsOperations.MathsOperationsClient calculator = new MathsOperations.MathsOperationsClient();
            Console.WriteLine(calculator.Add(3, 5));
        }
    }
}
