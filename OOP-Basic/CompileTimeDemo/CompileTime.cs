using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileTimeDemo
{
    class CompileTime
    {
        static void Main(string[] args)
        {
            MathOperations operations = new MathOperations();
            int firstResult = operations.Add(4, 4);
            int secondResult = operations.Add(4, 5, 5);
            Console.WriteLine(firstResult);
            Console.WriteLine(secondResult);
        }
    }
}
