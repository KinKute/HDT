using System;

namespace BaiTap2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = 5 > 4,
                b = 3 <= 3,
                c = 2 + 4 > 5,
                d = 6 == 7,
                e = 2 + 4 <= 6,
                f = 3 + 4 == 4 + 3,
                g = 1 != 2,
                h = 2 != 2,
                i = -5 == 7 - 2,
                j = 3 + 9 <= 0;
            Console.WriteLine("a) 5 > 4: " + a);
            Console.WriteLine("b) 3 <= 3: " + b);
            Console.WriteLine("c) 2 + 4 > 5: " + c);
            Console.WriteLine("d) 6 == 7: " + d);
            Console.WriteLine("e) 2 + 4 <= 6: " + e);
            Console.WriteLine(" f) 3 + 4 == 4 + 3: " + f);
            Console.WriteLine("g) 1 != 2: " + g);
            Console.WriteLine("h) 2 != 2: " + h);
            Console.WriteLine("i) -5 == 7 - 2: " + i);
            Console.WriteLine("j) 3 + 9 <= 0: " + j);
            Console.ReadKey();
        }
    }
}

        }
    }
}
