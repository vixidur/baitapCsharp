using System.Text;

namespace doicho2songuyen
{
    internal class Program
    {
        static void doiCho (ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhập a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập b: ");
            int b = int.Parse(Console.ReadLine());
            doiCho(ref a, ref b);
            Console.WriteLine($"Ket qua: {a} va {b} da duoc doi cho");
        }
    }
}
