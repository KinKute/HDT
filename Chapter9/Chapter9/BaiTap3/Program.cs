using System;

namespace BaiTap3
{
    class SalesTransaction
    {
        private string tenNhanVien;
        private int soTienBan;
        public int hoaHong=0;
        void Info()
        {
            int kq;
            Console.WriteLine(tenNhanVien + " co so tien ban hang la " + "d va hoa hong " + hoaHong + "d");
            kq = soTienBan * hoaHong;
            Console.WriteLine("Nhan vien " + tenNhanVien + "co tong doanh thu la: " + kq + "d");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SalesTransaction nhanVien = new SalesTransaction();
            Console.WriteLine("SalesTransactionDemo");
            Console.Write("Nhap ten nhan vien: ");
            nhanVien.
        }
    }
}
