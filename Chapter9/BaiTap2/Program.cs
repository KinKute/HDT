using System;
using System.Net.Sockets;

namespace BaiTap2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("TestClassifiedAd");
            ClassifiedAd ad = new ClassifiedAd();
            Console.Write("Nhap so tu quang cao 1: ");
            int.TryParse(Console.ReadLine(), out x);
            ad.sotu = x;
            Console.Write("So tien cho quang cao 1: {0}",ad.Gia);
            Console.Write("\nNhap so tu quang cao 2: ");
            int.TryParse(Console.ReadLine(), out x);
            ad.sotu = x;
            Console.Write("So tien cho quang cao 2: {0}", ad.Gia);
            Console.ReadLine();
        }
    }
}
