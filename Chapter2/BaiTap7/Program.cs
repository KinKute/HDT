using System;

namespace BaiTap7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 3000000, b = 5000000, c = 7000000;
            double kq1,kq2,kq3;
            Console.WriteLine("ProjectedRaises");
            Console.WriteLine("Muc luong co ban cua 3 nhan vien la: NV1:{0}\tNV2:{1}\tNV3:{2}", a, b, c);
            kq1 = (a * 4 / 100) + a;
            kq2 = (b * 4 / 100) + b;
            kq3 = (c * 4 / 100) + c;
            Console.WriteLine("Muc luong sau 1 nam cua 3 nhan vien lan luot la\nNV!:{0}\nNV2:{1}\nNV3:{2}", kq1, kq2, kq3);
            Console.ReadKey();
        }
    }
}
