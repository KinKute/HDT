using System;
using System.Text;
using System.Text.Unicode;

namespace BaiTap5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("***************** MY FAVORITE SONG! *****************\n" +
                "   ***************** LYRICS *****************\n" +
                "  ** Khi đôi môi em còn đỏ mọng\n+" +
                " ** Em muốn nói em yêu anh\n"+
                "  ** Khi men còn trong hơi thở\n"+
                "  ** Lại gần hôn anh đi");
            Console.ReadKey();
        }
    }
}
