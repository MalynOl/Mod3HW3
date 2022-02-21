using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12Delegate
{
    internal class Class2
    {
        public int ResultPow { get; set; }

        public Predicate<int> Calc(Func<int, int, int> func, int number1, int number2)
        {
            Class1 class1 = new Class1();
            func = class1.Pow;
            ResultPow = func(number1, number2);
            Predicate<int> handlerResult = Result;

            return handlerResult;
        }

        public bool Result(int number)
        {
            int ostdelen = ResultPow % number;

            if (ostdelen == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
