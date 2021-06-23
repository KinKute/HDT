using System;

namespace CaseProblems1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GreenvilleRevenue");
            int a, b;
            Console.WriteLine("Nhap so luong thi sinh nam ngoai : ");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Nhap so luong thi sinh nam nay : ");
            int.TryParse(Console.ReadLine(), out b);
            if (b > a)
            {
                if (b / 2 == a)
                    Console.WriteLine("Cuoc thi nam nay lon hon gap doi!");
                else
                    Console.WriteLine("Cuoc thi lon hon bao gio het!");
            }
            else
                Console.WriteLine("Mot cuoc dua chat che hon trong nam nay! Hay di ra va bo phieu cua ban!");
            Console.ReadLine();
        }
    }
}
