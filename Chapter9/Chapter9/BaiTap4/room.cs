using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap4
{
    class Room
    {
        public int rong;
        public int dai;
        public int cao;
        public int dtxq;

        public Room(int d, int r, int c)
        {
            dai = d;
            rong = r;
            cao = c;
            dtxq = 2 * cao * (dai + rong);
        }
        public void Nhap()
        {
            Console.WriteLine("nhap chieu dai phong: ");
            int.TryParse(Console.ReadLine(), out dai);
            Console.WriteLine("nhap chieu rong cua phong: ");
            int.TryParse(Console.ReadLine(), out rong);
            Console.WriteLine("nhap chieu cao cua phong: ");
            int.TryParse(Console.ReadLine(), out cao);
        }
        public override string ToString()
        {

            return string.Format("dai: {0}, rong: {1}, cao: {2}", dai, rong, cao);
        }

    }
}