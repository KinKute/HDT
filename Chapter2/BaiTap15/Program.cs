using System;

namespace BaiTap15
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x, kq;
            string strgx;
            Console.WriteLine("FahrenheitToCelsius");
            Console.Write("Nhap do F ban muon doi sang do C: ");
            strgx = Console.ReadLine();
            decimal.TryParse(strgx, out x);
            kq = (decimal)5 / 9 * (x - 32);
            kq = Math.Round(kq, 1);
            Console.WriteLine("{0}F = {1}C.", x, kq);
            Console.ReadKey();
        }
    }
 }
