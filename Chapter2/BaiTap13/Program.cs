using System;

namespace BaiTap13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MakeChange");
            int dollar,twenty,ten,five;
            int kq1, kq2, kq3,kq4;
            string strgdollar;
            Console.Write("Nhap so dollar ban can chuyen doi: ");
            strgdollar = Console.ReadLine();
            int.TryParse(strgdollar, out dollar);
            kq1 = dollar / 20;
            kq2=(dollar-(kq1*20))/ 10;
            kq3 = (dollar - (kq1*20 +10* kq2))/5;
            kq4 = (dollar - (kq1 * 20 + 10 * kq2 + 5 * kq3));
            Console.WriteLine(kq1 + " twenties");
            Console.WriteLine(kq2 + " tens");
            Console.WriteLine(kq3+ " fives");
            Console.WriteLine(kq4 + " ones");
            Console.ReadKey();

        }
    }
}
