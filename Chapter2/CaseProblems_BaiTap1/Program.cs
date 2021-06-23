using System;

namespace CaseProblems_BaiTap1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int kq1, kq2,kq3,kq4;
            string strga, strgb;
            Console.WriteLine("GreenvilleRevenue");
            Console.Write("Nhap so luong thi sinh tham gia cuoc thi vao nam ngoai: ");
            strga = Console.ReadLine();
            Console.Write("Nhap so luong thi sinh tham gia cuoc thi vao nam nay: ");
            strgb = Console.ReadLine();
            int.TryParse(strga, out a);
            int.TryParse(strgb, out b);
            kq1 = a * 25;
            kq2 = b * 25;
            kq3 = b - a;
            kq4 = kq2 - kq1;
            Console.WriteLine("So luong thi sinh tham gia cuoc thi nam ngoai la {0} co tong so phi la: {1}", a, kq1);
            Console.WriteLine("So luong thi sinh tham gia cuoc thi nam nay la {0} co tong so phi la: {1}", b, kq2);
            if(b>a)
            {
                Console.WriteLine("So luong thi sinh tham gia nhieu hon nam ngoai {0} thi sinh", b - a);
            }
            else if(b<a)
            {
                Console.Write("So luong thi sinh tham gia it hon nam ngoai {0} thi sinh", a - b);
            }
            else
            {
                Console.WriteLine("So luong thi sinh tham gia bang voi thi sinh nam ngoai");
            }
            Console.WriteLine("Tong so chi phi cho cuoc thi la: {0}", kq1 + kq2);
            Console.ReadKey();
        }
    }
}
