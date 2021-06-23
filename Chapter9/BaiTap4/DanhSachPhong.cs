using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaiTap4
{
    class DanhSachPhong
    {
        List<Room> ds = new List<Room>();
        public void Them(Room rm)
        {
            ds.Add(rm);
        }

        public void NhapTuFile()
        {
            var fileName = "data.txt";
            StreamReader sr = new StreamReader(fileName);
            var line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] str = line.Split(',');
                ds.Add(new Room(int.Parse(str[0]), int.Parse(str[1]), int.Parse(str[2])));
            }

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var rm in ds)
            {
                sb.Append(rm + "\n");
            }
            return sb.ToString();

        }
        public DanhSachPhong DienTichPhong()
        {
            Console.WriteLine("-------------------------------------------");
            DanhSachPhong kq = new DanhSachPhong();
            foreach (var item in ds)
            {

                int dt = item.cao * 2 * (item.rong + item.dai);
                Console.WriteLine("Dien tich cua phong la: " + item.cao * 2 * (item.rong + item.dai) + " square feet!");
                if ((dt) % 350 == 0)
                {
                    Console.WriteLine(" Phong can {0} gallon son! ", (dt) / 350);
                }
                else
                {
                    Console.WriteLine(" Phong can {0} gallon son! ", ((dt) / 350) + 1);
                    Console.WriteLine("-------------------------------------");
                }
            }
            return kq;
        }
    }
}
