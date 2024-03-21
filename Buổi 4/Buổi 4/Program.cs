using System;
using System.Text;
namespace Buổi_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a = 16;
            int b = 28;
            int ans = tong(a, b);
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("Tong la: " + ans);
            // hoặc có thể khai báo 
            //Console.WriteLine($"Tong la: {ans}"); dấu $ đến sử dụng {}
            Console.ReadKey();
        }
        static int tong(int a, int b)
        {
            return a + b;
        }
    }
}
