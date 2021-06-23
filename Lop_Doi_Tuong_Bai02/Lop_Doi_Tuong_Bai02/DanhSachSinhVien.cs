using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Lop_Doi_Tuong_Bai02
{
    class DanhSachSinhVien
    {
        List<SinhVien> ds = new List<SinhVien>();
        public void Them(SinhVien sv)
        {
            ds.Add(sv);
        }
        public void NhapTuFile()
        {
            var filename = "data.txt";
            StreamReader sr = new StreamReader(filename);
            var line = "";
            while ((line = sr.ReadLine()) != null)
            {
                Them(new SinhVien(line));
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var sv in ds)
            {
                sb.Append(sv + "\n");
            }
            return sb.ToString();
        }
        private int DemSLSVTheoGTVaLop(string GT, string lop)
        {
            int dem = 0;
            foreach (var sv in ds)
            {
                if (sv.gioiTinh == GT)
                    dem++;
            }
            return dem;
        }
        public int DemSLSVNam()
        {
            int dem = 0;
            foreach (var item in ds)
            {
                if (item.gioiTinh.Trim().CompareTo("NAM".Trim()) == 0)
                    dem++;
            }
            return dem;
        }
        public int DemSLSVNu()
        {
            int dem = 0;
            foreach (var item in ds)
            {
                if (item.gioiTinh.Trim().CompareTo("NU".Trim()) == 0)
                    dem++;
            }
            return dem;
        }
        public enum KieuSapXep
        {
            tangDTB,
            giamDTB
        }
        public DanhSachSinhVien SapXepTheoDiemTrungBinhTang()
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            SinhVien tam;
            for (int i = 0; i < ds.Count; i++)
            {
                for (int j = i + 1; j < ds.Count; j++)
                    if (ds[i].dTB >= ds[j].dTB)
                    {
                        tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;

                    }
                kq.Them(ds[i]);
            }
            return kq;
        }
        public DanhSachSinhVien SapXepTheoDiemTrungBinhGiam()
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            SinhVien tam;
            for (int i = 0; i < ds.Count; i++)
            {
                for (int j = i + 1; j < ds.Count; j++)
                    if (ds[i].dTB <= ds[j].dTB)
                    {
                        tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;

                    }
                kq.Them(ds[i]);
            }
            return kq;
        }
        public double TimDTBCaoNhat()
        {
            return ds.Max(x => x.dTB);
        }
        public DanhSachSinhVien TimDSSVCoDTBCaoNhat()
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            double max = TimDTBCaoNhat();
            foreach (var item in ds)
            {
                if (item.dTB == max)
                    kq.Them(item);
            }
            return kq;
        }
        public DanhSachSinhVien LopCoSinhVienCoDiemTrungBinhCaoNhat()
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            double max = TimDTBCaoNhat();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].dTB == max)
                {
                    Console.WriteLine("Sinh vien co diem trung binh cao nhat thuoc lop: {0} ", ds[i].lop);
                    kq.Them(ds[i]);
                }
            }
            return kq;
        }

        public double TimDTBThapNhat()
        {
            return ds.Min(x => x.dTB);
        }
        public DanhSachSinhVien LopCoSinhVienKhongCoDiemTrungBinhCaoNhat()
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            double max = TimDTBThapNhat();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].dTB == max)
                {
                    Console.WriteLine("Sinh vien khong co diem trung binh cao nhat thuoc lop: {0} ", ds[i].lop);
                    kq.Them(ds[i]);
                }
            }
            return kq;
        }
        public DanhSachSinhVien HienThiDanhSachSinhVienTheoLopvaDtb()
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            SinhVien tam;
            for (int i = 0; i < ds.Count; i++)
            {
                for (int j = i + 1; j < ds.Count; j++)
                {
                    if (ds[i].lop.CompareTo(ds[j].lop) > 0)
                    {
                        tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }
                }
                kq.Them(ds[i]);
            }
            return kq;
        }
    }
}
