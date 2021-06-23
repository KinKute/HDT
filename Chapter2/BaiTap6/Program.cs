using System;

namespace BaiTap6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, kq;
            string strga;
            Console.WriteLine("InchesToCentimeterslnteractive ");
            Console.Write("Nhap so cm ban muon chuyen doi qua cm: ");
            strga = Console.ReadLine();
            a = double.Parse(strga);
            kq = (double)a * 2.54;
            Console.WriteLine("Da doi thanh cong {0}inch la {1}cm.", a, kq);
            Console.ReadKey();
        }
    }
}
