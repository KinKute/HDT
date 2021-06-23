using System;

namespace CaseProblems_BaiTap2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,kq1,kq2,kq3;
            string strga,strgb;
            Console.WriteLine("MarshallsRevenue");
            Console.Write("Nhap so luong buc tranh noi that: ");
            strga = Console.ReadLine();
            int.TryParse(strga, out a);
            Console.Write("Nhap so luong buc tranh tuong ben ngoai: ");
            strgb = Console.ReadLine();
            int.TryParse(strgb, out b);
            kq1 = a * 500;
            kq2 = b * 750;
            kq3 = kq1 + kq2;
            Console.WriteLine("So luong buc tranh noi that {0} co tong chi phi la: {1}", a, kq1);
            Console.WriteLine("So luong buc tranh tuong ben ngoai {0} co tong chi phi la: {1}", b, kq2);
            Console.WriteLine("Tong chi phi cua 2 buc tranh tren la: " + kq3);
            Console.ReadKey();
        }
    }
}
