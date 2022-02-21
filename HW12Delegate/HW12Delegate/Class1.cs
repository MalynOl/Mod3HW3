using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12Delegate
{
    internal class Class1
    {
        public Class1()
        {
            Program p = new Program();
            HandlerShow = p.Show;
        }

        public Action<bool> HandlerShow { get; set; }

        public int Pow(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
