using System;

namespace BaiTap1
{

    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("TestSoccerPlayer");

            SoccerPlayer soccer = new SoccerPlayer();
            Console.Write("Nhap ten nguoi choi: ");
            soccer.tenNguoiChoi=Console.ReadLine();
            Console.Write("Nhap so ao: ");
            int.TryParse(Console.ReadLine(), out soccer.soAo);
            Console.Write("Nhap ban thang: ");
            int.TryParse(Console.ReadLine(), out soccer.banThang);
            Console.Write("Nhap diem ho tro: ");
            int.TryParse(Console.ReadLine(), out soccer.hoTro);
            soccer.Info();
            Console.ReadLine();
        }
    }

}
