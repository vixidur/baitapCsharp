using System;
using System.Text;
namespace sochinhphuong
{
    internal class Program
    {
        public static bool soChinhPhuong(int a)
        {
            int sqrt = (int)Math.Sqrt(a);
            return (sqrt * sqrt == a); 
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhập một số nguyên dương: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (soChinhPhuong(n))
            {
                Console.WriteLine("{0} là số chính phương.", n);
                Console.WriteLine($"{n} là số chính phương.");
            }
            else
            {
                Console.WriteLine("{0} không là số chính phương.", n);
            }
        }
    }
}
