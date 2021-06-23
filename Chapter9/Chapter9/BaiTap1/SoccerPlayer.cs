using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap1
{
    class SoccerPlayer
    {
        public string tenNguoiChoi;
        public int soAo;
        public int banThang;
        public int hoTro;
        public void Info()
        {
            Console.WriteLine("Ten nguoi choi: " + tenNguoiChoi + " co so ao: " + soAo + " ghi duoc " + banThang + " ban thang va co " + hoTro + " ho tro");
        }
    }
}
