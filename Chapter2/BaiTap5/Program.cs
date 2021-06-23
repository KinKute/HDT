using System;

namespace BaiTap5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            double kq;
            Console.WriteLine("InchesToCentmeters ");
            kq = (double)a * 2.54;
            Console.WriteLine("{0}inch la {1}cm.", a, kq);
            Console.ReadKey();
        }
    }
}
