using System;

namespace BaiTap11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 127, b = 20, c = 20, d = 50;
            int kq, kq1;
            Console.WriteLine("Eggs");
            kq = (a + b + c + d) / 12;
            kq1 = (a + b + c + d) % 12;
            Console.Write("tong so qua trung la {0} co {1}chuc va {2}qua", a + b + c + d, kq, kq1);
            Console.ReadKey();
        }
    }
}
