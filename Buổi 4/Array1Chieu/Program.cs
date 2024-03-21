using System;
using System.Text;
namespace Array1Chieu
{
    internal class Program
    {
        static void timKiemGiaTri(int[] a, int n)
        {
            int []t = a;
            int phan_tu_can_tim;
            phan_tu_can_tim = n;
            bool tim_thay = false;
            Console.Write("\nNhap so can tim: ");
            phan_tu_can_tim = int.Parse(Console.ReadLine());
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == phan_tu_can_tim)
                {
                    Console.WriteLine("\nPhần tử {0} được tìm thấy tại chỉ số {1}", phan_tu_can_tim, (i + 1));
                    tim_thay = true;
                    break;
                }
            }

            if (!tim_thay)
            {
                Console.WriteLine("\nPhần tử {0} không tồn tại trong mảng", phan_tu_can_tim);
            }
        }

        static void thayGiaTriPhanTu(int[] a, int n)
        {
            Console.WriteLine("\n-------------------------------------");
            Console.Write("\nNhập số thứ tự phần tử sẽ được thay giá trị mới: ");
            int stt = Convert.ToInt16(Console.ReadLine());
            Console.Write("\nNhập vi tri thay thế: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int k = stt - 1;
            a[k] = x;
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("Mảng sau khi thay giá trị là: ");
            inMang(a, n);
        }
        static void inMang(int[] a, int n)
        {
            Console.WriteLine("HIEN THI KET QUA");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void nhapMang(int[]a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu " + (i + 1) + " : ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void xoaPhanTu(int[]a, int n)
        {
            Console.WriteLine("\n-------------------------------------");
            Console.Write("\nNhap vi tri so can xoa: ");
            int index = int.Parse(Console.ReadLine());
            int k = index - 1; 
            for(int i = k; i < n - 1; i++)
            {
                a[i] = a[i + 1];
            }
            n--;
            Console.WriteLine("\nMảng sau khi xoá là: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void sapXepPhanTu(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n - i - 1; j++)
                {
                    if (a[j] < a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j+ 1] = temp;
                    }
                }    
            }   
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("Mảng sau khi sắp xếp là: ");
            inMang(a, n);
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhap n = ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            nhapMang(a, n);
            inMang(a, n);
            timKiemGiaTri(a, n);
            xoaPhanTu(a, n);
            thayGiaTriPhanTu(a, n);
            sapXepPhanTu(a, n);
            Console.ReadKey();
        }
    }
}
