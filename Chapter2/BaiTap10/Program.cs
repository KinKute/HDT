using System;

namespace BaiTap10
{
    class Program
    {
        static void Main(string[] args)
        {
            int gio, phut, n;
            const int SIXTY = 60;
            string strgN;
            Console.WriteLine("HoursAndMinutes");
            Console.Write("Nhap n de doi thoi gian: ");
            strgN = Console.ReadLine();
            int.TryParse(strgN, out n);
            gio = n / SIXTY;
            phut = (n % SIXTY) % SIXTY;
            Console.Write("Ban nhap n = {0} co gio la {1}:{2}", n, gio, phut);
            Console.ReadKey();
        }
    }
}
