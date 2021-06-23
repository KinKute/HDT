using System;

namespace BaiTap3
{
    class Program
    {
        static void Main(string[] args)
        {
            double dtb, dkt;
            string strg1, strg2;
            Console.WriteLine("Admission for a college’s admissions office");
            Console.Write("Nhap diem trung binh: ");
            strg1 = Console.ReadLine();
            Console.Write("Nhap diem kiem tra: ");
            strg2 = Console.ReadLine();
            double.TryParse(strg1, out dtb);
            double.TryParse(strg2, out dkt);
            if (dtb >= 3.0 && dkt > 60 || dtb < 3.0 && dkt > 80)
            {
                Console.Write("Accept");
            }
            else
            {
                Console.Write("Reject");
            }
            Console.ReadLine();
        }
    }
}
