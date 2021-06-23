using System;

namespace BaiTap4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            string strgx;
            Console.WriteLine("Hurricane");
            Console.Write("Nhap toc do gio: ");
            strgx = Console.ReadLine();
            int.TryParse(strgx, out x);

            if (x >= 74 && x < 96)
            {
                Console.WriteLine("Bao cap 1");
            }
            else if (x >= 96 && x < 111)
            {
                Console.WriteLine("Bao cap 2");
            }
            else if (x >= 111 && x < 130)
            {
                Console.WriteLine("Bao cap 3");
            }
            else if (x >= 130 && x < 150)
            {
                Console.WriteLine("Bao cap 4");
            }
            else if (x >= 150)
            {
                Console.WriteLine("Bao cap 5");
            }
            else
            {
                Console.WriteLine("Khong phai bao");
            }
            Console.ReadLine();
        }
    }
}
