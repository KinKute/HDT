using System;

namespace BaiTap5
{
    class Program
    {
        static void Main(string[] args)
        {
            string strgstt;
            int stt;
            Console.WriteLine("CheckMonth");
            Console.Write("Nhap thang: ");
            strgstt = Console.ReadLine();
            int.TryParse(strgstt, out stt);
            if (stt <= 12 && stt >= 1)
            {
                Console.WriteLine("Thang " + stt+" la thang hop le!");
            }
            else
            {
                Console.WriteLine("error,for example: Thang hop le la thang 3");
            }
            Console.ReadLine();
        }
    }
}
