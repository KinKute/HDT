using System;

namespace BaiTap18
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b, strgkq, d,c;
            Console.WriteLine("PigLatin");
            Console.Write("Nhap ham ban muon chuyen doi: ");
            a = Console.ReadLine();
            c = a;
            b = a.Substring(1);
            d = c.Substring(0, 1);
            strgkq = b + d + "ay";
            Console.WriteLine("Ket qua chuyen doi la: "+strgkq);
            Console.ReadKey();
        }
    }
}
