using System;

namespace Lop_Doi_Tuong_Bai02
{
    class Program
    {
        enum menu
        {
            xuatdssv,
            slsvnam,
            slsvnu,
            dssvtheochieutanggiamdtb,
            dssvcodtbcaonhat,
            lopsvcodtbcaonhat,
            lopsvkcodtb,
            hienthitheolopvachieugiamdtb,
            xephang,
            lopcodtbcaothap,
            lopnhieuhsgioi,
            lopnhieuhsyeutbkha,
            thoatchuongtrinh=12
        }

        static void Main(string[] args)
        {
            DanhSachSinhVien IT = new DanhSachSinhVien();
            IT.NhapTuFile();
            Console.WriteLine("========== DANH SACH SINH VIEN ==========");
            while (true)
            {
                Console.Clear();
                Console.WriteLine("========== HE THONG MENU ==========");
                Console.WriteLine("Nhap {0} de xuat danh sach sinh vien.",(int)menu.xuatdssv);
                Console.WriteLine("Nhap {0} de dem so luong sinh vien nam co trong lop.",(int)menu.slsvnam);
                Console.WriteLine("Nhap {0} de xuat so luong sinh vien nu co trong lop.",(int)menu.slsvnu);
                Console.WriteLine("Nhap {0} de hi   en thi danh sach sinh vien theo chieu tang, chieu giam cua diem trung binh.",(int)menu.dssvtheochieutanggiamdtb);
                Console.WriteLine("Nhap {0} de xuat danh sach sinh vien co diem trung binh cao nhat.",(int)menu.dssvcodtbcaonhat);
                Console.WriteLine("Nhap {0} de xuat lop co sinh vien co diem trung binh cao nhat.",(int)menu.lopsvcodtbcaonhat);
                Console.WriteLine("Nhap {0} de tim lop co sinh vien khong co diem trung binh cao nhat.",(int)menu.lopsvkcodtb);
                Console.WriteLine("Nhap {0} de hien thi danh sach sinh vien theo lop va theo chieu giam cua DTB.",(int)menu.hienthitheolopvachieugiamdtb);
                Console.WriteLine("Nhap {0} de xep hang sinh vien.",(int)menu.xephang);
                Console.WriteLine("Nhap {0} de tim lop co tong diem trung binh cao nhat, thap nhat",(int)menu.lopcodtbcaothap);
                Console.WriteLine("Nhap {0} de tim lop co nhieu hoc sinh gioi nhat.",(int)menu.lopnhieuhsgioi);
                Console.WriteLine("Nhap {0} de tim lop co nhieu hoc sinh yeu, trung binh, kha.",(int)menu.lopnhieuhsyeutbkha);
                Console.WriteLine("Nhap {0} de thoat chuong trinh.",(int)menu.thoatchuongtrinh);
                menu nhap = (menu)int.Parse(Console.ReadLine());
                switch (nhap)
                {
                    case menu.xuatdssv:
                        {
                            Console.Clear();
                            Console.WriteLine("========== DANH SACH SINH VIEN HIEN HANH ==========\n"+IT);

                        }break;
                    case menu.slsvnam:
                        {
                            Console.Clear();
                            Console.WriteLine("Danh sach sinh vien hien tai: \n" + IT);
                            Console.WriteLine("So luong sinh vien nam hien tai: " + IT.DemSLSVNam());
                        }
                        break;
                    case menu.slsvnu:
                        {
                            Console.Clear();
                            Console.WriteLine("Danh sach sinh vien hien tai: \n" + IT);
                            Console.WriteLine("So luong sinh vien nu hien tai: " + IT.DemSLSVNu());
                        }
                        break;
                    case menu.dssvtheochieutanggiamdtb:
                        {
                            Console.Clear();
                            Console.WriteLine("Danh sach theo chieu tang DTB: \n"+IT.SapXepTheoDiemTrungBinhTang());
                            Console.WriteLine("Danh sach theo chieu giam DTB: \n" + IT.SapXepTheoDiemTrungBinhGiam());
                        }
                        break;
                    case menu.dssvcodtbcaonhat:
                        {
                            Console.Clear();
                            Console.WriteLine("DSSV co diem trung binh cao nhat: \n"+IT.TimDSSVCoDTBCaoNhat());

                        }
                        break;
                    case menu.lopsvcodtbcaonhat:
                        {
                            Console.Clear();
                            Console.WriteLine("Lop co diem trung binh cao nhat:\n"+ IT.LopCoSinhVienCoDiemTrungBinhCaoNhat());
                        }
                        break;
                    case menu.lopsvkcodtb:
                        {
                            Console.Clear();
                            Console.WriteLine("Lop khong co diem trung binh :\n" + IT.LopCoSinhVienKhongCoDiemTrungBinhCaoNhat());
                        }
                        break;
                    case menu.hienthitheolopvachieugiamdtb:
                        {
                            Console.Clear();
                            Console.WriteLine("Danh sach theo lop va giam DTB\n"+  IT.HienThiDanhSachSinhVienTheoLopvaDtb());
                        }
                        break;
                    case menu.xephang:
                        {
                            Console.Clear();
                        }
                        break;
                    case menu.lopcodtbcaothap:
                        {
                            Console.Clear();
                        }
                        break;
                    case menu.lopnhieuhsgioi:
                        {
                            Console.Clear();

                        }
                        break;
                    case menu.lopnhieuhsyeutbkha:
                        {
                            Console.Clear();
                        }
                        break;
                    case menu.thoatchuongtrinh:
                        Console.Clear();
                        return;
                } 
                Console.ReadLine();
            }
        }
    }
}
