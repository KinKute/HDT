using System;

namespace BaiTap4
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachPhong phong = new DanhSachPhong();
            phong.NhapTuFile();
            Console.WriteLine(phong);
            Console.WriteLine(phong.DienTichPhong());
            Console.ReadLine();
        }
    }
}
