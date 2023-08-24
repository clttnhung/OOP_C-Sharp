/*Xây dựng lớp Phanso (Phân số) gồm:
 Thuộc tính: Tuso, Mauso (Tử số, Mẫu số)
 Phương thức:
• Hàm Khởi tạo không Tham số, Hàm hủy
• Hàm Nhập, xuất
• Hàm Cong(), Tru(), Nhan(),Chia()
Tính Tổng, Hiệu, Tích, Thương 2 phân số A và B rồi in ra kết
quả trên màn hình*/

using System;
namespace Chuong4
{

    class Phanso
    {
        public int TusoA;
        public int MausoA;
        public int TusoB;
        public int MausoB;

        public Phanso()
        {
            Console.WriteLine("Khoi tao");
        }

        ~Phanso()
        {
            Console.WriteLine("Huy tinh toan");
        }

        public void Nhap()
        {
            Console.Write("Nhap Tu so A: ");
            TusoA=int.Parse(Console.ReadLine());
            Console.Write("Nhap Mau so A: ");
            MausoA=int.Parse(Console.ReadLine());
            Console.Write("Nhap Tu so B: ");
            TusoB=int.Parse(Console.ReadLine());
            Console.Write("Nhap Mau so B: ");
            MausoB=int.Parse(Console.ReadLine());
        }
        
        public void Xuat()
        {
            Console.WriteLine($"Phan so A la: {TusoA}/{MausoA}");
            Console.WriteLine($"Phan so B la: {TusoB}/{MausoB}");

        }
        public void Cong()
        {
            int ts = TusoA*MausoB + TusoB*MausoA;
            int ms = MausoA*MausoB;
            Console.WriteLine($"Ket qua phep cong la: {ts}/{ms}");
        }
        public void Tru()
        {
            int ts = TusoA*MausoB - TusoB*MausoA;
            int ms = MausoA*MausoB;
            Console.WriteLine($"Ket qua phep cong la: {ts}/{ms}");
        }
        public void Nhan()
        {
            int ts = TusoA*TusoB;
            int ms = MausoA*MausoB;
            Console.WriteLine($"Ket qua phep cong la: {ts}/{ms}");
        }
        public void Chia()
        {
            int ts = TusoA*MausoB;
            int ms = MausoA*TusoB;
            Console.WriteLine($"Ket qua phep cong la: {ts}/{ms}");
        }
    }
    internal class Bai1
    {
        static void Main(string[] args)
        { 
           Phanso ps = new Phanso();
           ps.Nhap();
           if(ps.MausoA == 0 || ps.MausoB == 0)
           {
            Console.WriteLine("Nhap sai phan so");
           }
           else
           {
            ps.Xuat();
            ps.Cong();
            ps.Tru();
            ps.Nhan();
            ps.Chia();
           }
       
        }
    }
}