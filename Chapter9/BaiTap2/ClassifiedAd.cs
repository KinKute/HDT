using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace BaiTap2
{
    class ClassifiedAd
    {
        private double gia;
        public string QuangCao1;
        public string QuangCao2;
        private int soTu;

        public double Gia
        {
            get
            {
                gia=sotu * 0.09;
                return gia;
            }
            
        }
        public int sotu
        {
            get
            {
                return soTu;
            }
            set
            {
                soTu = value;
            }
        }
        
    }
}
