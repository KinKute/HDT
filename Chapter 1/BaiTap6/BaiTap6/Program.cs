using System;
using System.Text;

namespace BaiTap6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //lệnh xuất được tiếng việt có dấu
            Console.WriteLine("****** COMMENTS ******");
            Console.WriteLine("Hello World!");
            //xuất ra màn hình dòng chữ Hello World!
            Console.Write("Nhập tên của bạn vào: ");
            Console.WriteLine("Tên của bạn là: " + Console.ReadLine());
            /*
             -viết ra màn hình dòng chữ "Nhập tên của bạn vào:" sau đó cho người dùng nhập vào
            - xuất ra màn hình "Tên của bạn là:" kèm theo tên mà người dùng nhập
             */
            Console.ReadKey();
            //lệnh dừng màn hình, chờ ấn 1 phím để thoát chương trình
        }
    }
}
