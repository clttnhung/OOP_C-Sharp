using System;
namespace MyApp 
{
    public class SinhVien
    {
        private string MaSinhVien;
        private string HoVaTen;
        private DateTime NgaySinh;
        private string Lop;
        private double DiemTrungBinh;
        public void NhapThongTin()
        {
            Console.Write("Nhap ma sinh vien: "); this.MaSinhVien = Console.ReadLine();
        }



    }

    internal class Bai1
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
        }
    }
}