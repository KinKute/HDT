using System;

namespace BaiTap8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string strga;
            Console.WriteLine("ProjectedRaisesInteractive");
            Console.Write("Nhap muc luong hien tai cua ban: ");
            strga = Console.ReadLine();
            int.TryParse(strga, out a);
            b = (a * 4 / 100) + a;
            Console.WriteLine("Muc luong cua ban vao nam sau la: {0}", b);
            Console.ReadKey();
        }
    }
}
