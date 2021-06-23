using System;

namespace BaiTap17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Planets");
            int stt;
            string strg;
            Console.Write("Nhap so thu tu cua hanh tinh: ");
            strg = Console.ReadLine();
            int.TryParse(strg, out stt);
            if(stt==1)
            {
                Console.WriteLine("Sao Thuy (Mercury)");
            }
            else if(stt==2)
            {
                Console.WriteLine("Sao Kim (Venus)");
            }
            else if(stt==3)
            {
                Console.WriteLine("Trai Dat (Earth)");
            }
            else if(stt==4)
            {
                Console.WriteLine("Sao Hoa (Mars)");
            }
            else if(stt==5)
            {
                Console.WriteLine("Sao Moc (Jupiter)");
            }
            else if(stt==6)
            {
                Console.WriteLine("Sao Tho (Saturn)");
            }
            else if(stt==7)
            {
                Console.WriteLine("Sao Thien Vuong (Uranus)");
            }
            else if(stt==8)
            {
                Console.WriteLine("Sao Hai Vuong (Neptune)");
            }
            else
            {
                Console.WriteLine("So thu tu ban nhap khong dung!");
                return;
            }
            Console.ReadKey();
        }
    }
}
