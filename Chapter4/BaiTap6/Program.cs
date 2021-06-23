using System;

namespace BaiTap6
{
    class Program
    {
        static void Main(string[] args)
        {
            int SoTK, SoTkb, SoTkc;
            string strg,str1,str2;
            Console.WriteLine("CheckDigit");
            Console.Write("Nhap so tai khoan: ");
            strg = Console.ReadLine();
            str1 = strg.Substring(0, 3);
            str2= strg.Substring(3);
            if (strg.Length > 4)
            {
                Console.WriteLine("Qua 4 chu so, Xin moi nhap lai!");
            }
            else
            {
                int.TryParse(strg, out SoTK);

                int.TryParse(str1, out SoTkb);
                int.TryParse(str2, out SoTkc);
                if (SoTkb % 7 == SoTkc)
                {
                    Console.WriteLine("Tai khoan hop le!");
                }
                else
                    Console.WriteLine("Tai khoan khong hop le!");
            }


            Console.ReadLine();
        }
    }
}
