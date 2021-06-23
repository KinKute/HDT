using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Lop_Doi_Tuong_Bai02
{
    class SinhVien
    {
        public string maSV;
        public string hoTen;
        public float dTB;
        public string lop;
        public string gioiTinh;
        public string Lop
        {
            get { return lop; }
            set { lop = value.Trim(); }
        }
        //
        public SinhVien()
        {
            maSV = "1";
            hoTen = "a";
        }
        public SinhVien(string ma,string ho,float dtb,string lop,string gt)
        {
            maSV = ma;
            hoTen = ho;
            dTB = dtb;
            this.lop = lop;
            gioiTinh = gt;
        }
        public SinhVien(string line)
        {
            string[] str = line.Split(',');
            maSV = str[0];
            hoTen = str[1];
            dTB = float.Parse(str[2]);
            lop = str[3];
            gioiTinh = str[4];
        }   
        public void Nhap()
        {
            Console.WriteLine("Nhap ma so sinh vien: ");
            maSV = Console.ReadLine();
            Console.WriteLine("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhap diem trung binh: "); ;
            float.TryParse(Console.ReadLine(), out dTB);
            Console.WriteLine("Nhap lop: ");
            lop = Console.ReadLine();
        }
        public override string ToString()
        {
            return string.Format("{0, 2} {1, 10} {2,5} {3, 6} {4, 10}", maSV, hoTen, dTB, gioiTinh , lop);
        }
    }
    
}
