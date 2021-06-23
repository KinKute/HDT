using System;

namespace BaiTap2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.Write("Twitter\n");
            Console.Write("Nhap tin nhan cua ban: ");
            str = Console.ReadLine();
            if (str.Length > 140)
            {
                Console.Write("ERROR!");
            }
            else
                Console.Write('\n'+str);

            Console.ReadLine();
        }

    }
}
