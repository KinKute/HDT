using System;

namespace BaiTap1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string strga;
            Console.WriteLine("CheckCredit");
            Console.Write("Nhap gia tri cho mat hang: ");
            strga = Console.ReadLine();
            int.TryParse(strga, out a);
            string kq = (a < 8000) ? ("Approved!") : ("Error, please try again!!!");
            Console.WriteLine(kq);
            Console.ReadLine();
        }
    }
}
