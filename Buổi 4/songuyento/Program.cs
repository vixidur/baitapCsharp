using System;
using System.Text;
namespace songuyento
{
    internal class Program
    {
        public static bool soNguyenTo(int n)
        {
            if (n <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhập một số nguyên dương: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (soNguyenTo(a))
            {
                Console.WriteLine("{0} là số nguyên tố.", a);
            }
            else
            {
                Console.WriteLine("{0} không là số nguyên tố.", a);
            }
        }
    }
}
