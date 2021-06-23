using System;

namespace BaiTap12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            string strga, strgb, strgc, strd;
            int kq, kq1;
            Console.WriteLine("EggsInteractive");
            Console.Write("Nhap so trung cua ga so 1: ");
            strga = Console.ReadLine();
            Console.Write("Nhap so trung cua ga so 2: ");
            strgb = Console.ReadLine();
            Console.Write("Nhap so trung cua ga so 3: ");
            strgc = Console.ReadLine();
            Console.Write("Nhap so trung cua ga so 4: ");
            strd = Console.ReadLine();
            int.TryParse(strga, out a);
            int.TryParse(strgb, out b);
            int.TryParse(strgc, out c);
            int.TryParse(strd, out d);
            Console.Write("Tong so qua trung cua 4 con ga la: ", a + b + c + d);
            kq = (a + b + c + d) / 12;
            kq1 = (a + b + c + d) % 12;
            Console.Write("{0} qua trung co {1} chuc va {2} qua", a + b + c + d, kq, kq1);
            Console.ReadKey();
        }
    }
}
