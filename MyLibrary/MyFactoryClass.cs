using System;

namespace MyLibrary
{
    public interface IMathOperation
    {
        int PerformMathAction(int oper1, int oper2);

    }

    public enum MathOperationType
    {
        Add = 0,
        Multiply = 1

    }

    public class MathFactory
    {

        public IMathOperation GetMathOperation(MathOperationType MathOperType)
        {
            if (MathOperType == 0)
            {
                return new Adder();
            }


            return new Multiplier();
        }


        class Adder : IMathOperation
        {


            public int PerformMathAction(int oper1, int oper2)
            {
                return oper1 + oper2;
            }
        }


        class Multiplier : IMathOperation
        {
            public int PerformMathAction(int oper1, int oper2)
            {
                return oper1 * oper2;
            }
        }

    }

}
