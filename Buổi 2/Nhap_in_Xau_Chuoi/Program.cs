using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhap_in_Xau_Chuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;// khi nhập tiếng việt có dấu thì khi in ra cũng như vậy
            Console.OutputEncoding = Encoding.Unicode;
            string xau1, xau2;
            Console.Write("Nhap xau 1: "); xau1 = Console.ReadLine();
            Console.Write("Nhap xau 2: "); xau2 = Console.ReadLine();
            // in ra 
            //Console.WriteLine("\n\n");
            Console.WriteLine("Xau 1: {0}", xau1);
            Console.Write("Xau 2: {0}", xau2);
            Console.ReadKey();
        }
    }
}
