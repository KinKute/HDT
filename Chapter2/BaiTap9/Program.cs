using System;

namespace BaiTap9
{
    class Program
    {
        static void Main(string[] args)
        {
            int diChuyen, gio, dam;
            string strgdiChuyen, strggio, strgdam;
            double kq1,kq2,kq3;
            Console.WriteLine("MoveEstimator");
            Console.Write("Nhap so lan di chuyen cua ban: ");
            strgdiChuyen = Console.ReadLine();
            Console.Write("Nhap so gio ban da di: ");
            strggio = Console.ReadLine();
            Console.Write("Nhap so dam ban da di: ");
            strgdam = Console.ReadLine();
            int.TryParse(strgdiChuyen,out diChuyen);
            int.TryParse(strggio, out gio);
            int.TryParse(strgdam, out dam);
            kq1 = diChuyen * 200;
            kq2 = gio * 150;
            kq3 = dam * 2;
            Console.WriteLine("{0} lan di chuyen, {1} gio va {2} dam voi tong so tien la : ${3}", diChuyen, gio, dam, kq1 + kq2 + kq3);
            Console.ReadKey();
        }
    }
}
