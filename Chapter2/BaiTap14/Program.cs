using System;

namespace BaiTap14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TestsInteractive");
            double a, b, c, d, e, f, g, h,kq,kq1;
            string strga, strgb, strgc, strgd, strge, strgf, strgg, strgh;
            Console.Write("Nhap diem thu nhat: ");
            strga = Console.ReadLine();
            Console.Write("Nhap diem thu hai: ");
            strgb = Console.ReadLine();
            Console.Write("Nhap diem thu ba: ");
            strgc=Console.ReadLine();
            Console.Write("Nhap diem thu tu: ");
            strgd = Console.ReadLine();
            Console.Write("Nhap diem thu nam: ");
            strge = Console.ReadLine();
            Console.Write("Nhap diem thu sau: ");
            strgf = Console.ReadLine();
            Console.Write("Nhap diem thu bay: ");
            strgg = Console.ReadLine();
            Console.Write("Nhap diem thu tam: ");
            strgh=Console.ReadLine();
            double.TryParse(strga, out a);
            double.TryParse(strgb, out b);
            double.TryParse(strgc, out c);
            double.TryParse(strgd, out d);
            double.TryParse(strge, out e);
            double.TryParse(strgf, out f);
            double.TryParse(strgg, out g);
            double.TryParse(strgh, out h);
            kq =(a + b + c + d + e + f + g + h) / 8;
            kq1 = Math.Round(kq, 2);
            Console.Write("Diem trung binh la: "+ kq1);
            Console.ReadKey();
        }
    }
}
