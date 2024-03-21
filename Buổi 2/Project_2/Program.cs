using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            float x, y;
            Console.Write("Nhap x = "); x = float.Parse(Console.ReadLine());
            Console.Write("Nhap y = "); y = float.Parse(Console.ReadLine());
            float Sum = x/y;
            Console.WriteLine("Tong la: {0}", Sum);
            Console.ReadKey(); 
        }
    }
}
