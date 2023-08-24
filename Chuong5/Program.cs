using System.Security.Cryptography.X509Certificates;
using System;

namespace MyApp 
{
    class HinhTron
    {
        public double pi = 3.14;
        public double BanKinh;
        public double DuongKinh;
        public double DienTich;
        public void Nhap()
        {
            Console.Write("Nhap ban kinh: ");
            BanKinh = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("Nhap duong kinh: ");
            DuongKinh = Convert.ToDouble(Console.ReadLine()); 
        }
        public HinhTron(double bk, double dk, double dt )
        {
            BanKinh = bk; DuongKinh = dk; DienTich = dt;
        }

    }
    class HinhCau:HinhTron
    {
        double TheTich;
        public HinhCau(double bk, double dk, double dt, double tt ):base(bk, dk,dt)
        {
            BanKinh = bk; DuongKinh = dk; DienTich = dt; TheTich =tt;
        }
        public new void Xuat()
        {
            double dthc = 4*pi*BanKinh*BanKinh;
            Console.Write($"Dien tich hinh cau: {dthc}");
            double tthc = 4/3*pi*BanKinh*BanKinh*BanKinh;
            Console.Write($"The tich hinh cau: {tthc}");
        }
    }
    class HinhTru:HinhTron
    {
        double ChuViMatDay;
        double DienTichMatDay;
        double DienTichXungquanh;
        double DienTichToanPhan;
        double TheTich;
        public HinhTru(double bk, double dk, double dt, double cvmd, double dtmd, double dtxq, double dttp, double tt ):base(bk, dk,dt)
        {
            BanKinh = bk; DuongKinh = dk; DienTich = dt; ChuViMatDay = cvmd; DienTichMatDay = dtmd; DienTichXungquanh = dtxq; DienTichToanPhan = dttp; TheTich = tt;
        }
        public new void Xuat()
        {
            double cvmd = 2*pi*BanKinh;
            Console.Write($"Chu vi mat day: {cvmd}");
            double dtmd = 2*pi*BanKinh*BanKinh;
            Console.Write($"The tich hinh cau: {dtmd}");
            double dtxq = 2*pi*;
            Console.Write($"Dien tich hinh cau: {dthc}");
            double dttp  = 4/3*pi*BanKinh*BanKinh*BanKinh;
            Console.Write($"The tich hinh cau: {tthc}");
            double tt = 4*pi*BanKinh*BanKinh;
            Console.Write($"Dien tich hinh cau: {dthc}");
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
