using System;

namespace HW12Delegate
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Class2 class2 = new Class2();
            var handlerResult = class2.Calc(class1.Pow, 12, 4);
            var b = handlerResult(6);
            class1.HandlerShow(b);
        }

        public void Show(bool b)
        {
            Console.WriteLine(b.ToString());
        }
    }
}
