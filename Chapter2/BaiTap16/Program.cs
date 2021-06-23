using System;

namespace BaiTap16
{
    class Program
    {
        enum thang:byte
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            may = 5,
            June = 6,
            July = 7,
            August = 8,
            Seaptember = 9,
            October = 10,
            November = 11,
            December = 12
        }
        static void Main(string[] args)

        {
            Console.WriteLine("MonthNames");
            int month;
            string strgm;
            Console.Write("Nhap thang : ");
            strgm = Console.ReadLine();
            int.TryParse(strgm, out month);
            switch(month)
            {
                case  (byte)thang.January:
                    {
                        Console.WriteLine("Thang 1: January");
                        break;
                    };
            }
            switch (month)
            {
                case (byte)thang.February:
                    {
                        Console.WriteLine("Thang 2: February");
                        break;
                    };
            }
            switch (month)
            {
                case (byte)thang.March:
                    {
                        Console.WriteLine("Thang 3: March");
                        break;
                    };
            }
            switch (month)
            {
                case (byte)thang.April:
                    {
                        Console.WriteLine("Thang 4: April");
                        break;
                    };
            }
            switch (month)
            {
                case (byte)thang.may:
                    {
                        Console.WriteLine("Thang 5: May");
                        break;
                    };
            }
            switch (month)
            {
                case (byte)thang.June:
                    {
                        Console.WriteLine("Thang 6: June");
                        break;
                    };
            }
            switch (month)
            {
                case (byte)thang.July:
                    {
                        Console.WriteLine("Thang 7: July");
                        break;
                    };
            }
            switch (month)
            {
                case (byte)thang.August:
                    {
                        Console.WriteLine("Thang 8: August");
                        break;
                    };
            }
            switch (month)
            {
                case (byte)thang.Seaptember:
                    {
                        Console.WriteLine("Thang 9: Seaptember");
                        break;
                    };
            }
            switch (month)
            {
                case (byte)thang.October:
                    {
                        Console.WriteLine("Thang 10: October");
                        break;
                    };
            }
            switch (month)
            {
                case (byte)thang.November:
                    {
                        Console.WriteLine("Thang 11: November");
                        break;
                    };
            }
            switch (month)
            {
                case (byte)thang.December:
                    {
                        Console.WriteLine("Thang 12: December");
                        break;
                    };
            }
        }
     }       
}
