using Microsoft.Win32.SafeHandles;
using System;

namespace BaiTap5_b_
{
    class Program
    {
        static void Main(string[] args)
        {
            int thang, ngay;
            string x="", y;
            Console.WriteLine("CheckMonth2");
            Console.Write("Nhap thang sinh cua ban: ");
            y = Console.ReadLine();
            Console.Write("Nhap nay sinh cua ban: ");
            x = Console.ReadLine();

            int.TryParse(x, out ngay);
            int.TryParse(y, out thang);

           if (thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12)
            {
                if (ngay < 1 || ngay > 31)
                {
                    Console.WriteLine("ERROR!");
                }
                else
                {
                    Console.Write(ngay + "-" + thang);
                }
            }
            else if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
            {
                if (ngay < 1 || ngay > 31)
                {
                    Console.WriteLine("ERROR!");
                }
                else
                {
                    Console.Write(ngay + "-" + thang);
                }
            }
            else if (thang == 2)
            {
                if (ngay < 1 || ngay > 29)
                {
                    Console.WriteLine("ERROR!");
                }
                else
                {
                    Console.WriteLine(ngay + "-" + thang);
                }
            }
            else
            {
                Console.WriteLine("ERROR!");
            }
            Console.ReadLine();
        }
    }
}
