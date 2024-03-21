using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; // đây là thư viện có thể gọi ra những kiểu viết dấu như Unicode, UTF8 các hàm OutputEncoding
using System.Threading.Tasks;

namespace ProjectFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.OutputEncoding = Encoding.Unicode; // để có thể  in ra Tiếng Việt có dấu
            Console.WriteLine("Van Chien");
            Console.WriteLine("Xin chào! Van Chien");
            // test có dấu 
            Console.WriteLine("Xin chào test Trần Văn Chiến");
            //Console.ReadLine();
            // Có thể dùng ReadKey(); để ngắt chương trình 
            Console.ReadKey(); // dùng để ngắt chương trình  
            */
            Console.OutputEncoding = Encoding.Unicode;
            int a;
            int b;

            Console.WriteLine("Nhap a = "); a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b = "); b = int.Parse(Console.ReadLine());
            double x = -b / a;
            Console.WriteLine("In ra x = {0}", x);
            Console.WriteLine("In ra a, b, x: {0} {1} {2}", a, b, x);
            Console.ReadKey ();
            //if (a == 0)
            //{
            //    Console.WriteLine("Vô số nghiệm!\n");
            //}
        }
    }
}
