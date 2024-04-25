using System;
using System.Text;


namespace Buổi_5
{

    class CongDan
    {
        // Thuộc tính của lớp cha
        public string CCCD { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public CongDan()
        {
            CCCD = "";
            HoTen = "";
            Tuoi = 0;
        }

        // Constructor có tham số
        public CongDan(string cccd, string hoTen, int tuoi)
        {
            CCCD = cccd;
            HoTen = hoTen;
            Tuoi = tuoi;
        }
        // Phương thức in thông tin của công dân
        public void inThongTin()
        {
            Console.WriteLine("CCCD: " + CCCD);
            Console.WriteLine("Họ và tên: " + HoTen);
            Console.WriteLine("Tuổi: " + Tuoi);
        }

        // Phương thức nhập thông tin của công dân
        public void nhapThongTin()
        {
            Console.Write("Nhập CCCD: ");
            CCCD = Console.ReadLine();

            Console.Write("Nhập họ và tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập tuổi: ");
            Tuoi = int.Parse(Console.ReadLine());
        }
    }

    // Lớp con kế thừa từ lớp cha
    class SinhVien : CongDan
    {
        // Thuộc tính của lớp con
        public double DiemToan { get; set; }
        public double DiemVan { get; set; }
        public double DiemAnh { get; set; }
        // Constructor không tham số
        public SinhVien() : base()
        {
            DiemToan = 0;
            DiemVan = 0;
            DiemAnh = 0;
        }

        // Constructor có tham số
        public SinhVien(string cccd, string hoTen, int tuoi, double diemToan, double diemVan, double diemAnh) : base(cccd, hoTen, tuoi)
        {
            DiemToan = diemToan;
            DiemVan = diemVan;
            DiemAnh = diemAnh;
        }
        // Phương thức in thông tin của sinh viên
        public new void inThongTin()
        {
            base.inThongTin(); // Gọi phương thức inThongTin của lớp cha
            Console.WriteLine("Điểm toán: " + DiemToan);
            Console.WriteLine("Điểm văn: " + DiemVan);
            Console.WriteLine("Điểm anh: " + DiemAnh);
        }

        // Phương thức nhập thông tin của sinh viên
        public new void nhapThongTin()
        {
            base.nhapThongTin(); // Gọi phương thức nhapThongTin của lớp cha

            Console.Write("Nhập điểm toán: ");
            DiemToan = double.Parse(Console.ReadLine());

            Console.Write("Nhập điểm văn: ");
            DiemVan = double.Parse(Console.ReadLine());

            Console.Write("Nhập điểm anh: ");
            DiemAnh = double.Parse(Console.ReadLine());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Nhập số lượng sinh viên: ");
            int soLuong = int.Parse(Console.ReadLine());

            SinhVien[] danhSachSinhVien = new SinhVien[soLuong];

            // Nhập thông tin của từng sinh viên
            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine("THÔNG TIN SINH VIÊN THỨ " + (i + 1) + " ");
                danhSachSinhVien[i] = new SinhVien();
                danhSachSinhVien[i].nhapThongTin();
            }

            // Hiển thị thông tin của từng sinh viên
            Console.WriteLine("\nTHÔNG TIN CÁC SINH VIÊN");
            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine("\nThông tin sinh viên thứ " + (i + 1) + "");
                danhSachSinhVien[i].inThongTin();
            }
            Console.ReadKey();
        }
    }
}
