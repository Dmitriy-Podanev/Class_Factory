using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiLibrary;
namespace Factory_Class
{

   



    class Program
    {
        static void Main(string[] args)
        {
            MathFactory factory = new MathFactory();



            Console.WriteLine(factory.GetMathOperation(MathOperationType.Add).PerformMathAction(1, 4));
            Console.WriteLine(factory.GetMathOperation(MathOperationType.Multiply).PerformMathAction(2, 4));

        }
    }
}
