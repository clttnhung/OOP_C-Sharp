using System;
 

namespace MyApp 
{
    public class HinhTron
    {
        public double Bankinh;
        public double Duongkinh;
        public double Dientich;
        public static double Pi=3.14;
        public HinhTron()
        {
            Bankinh = 3;
            Duongkinh = 4 ;
        }
        public void Tinhdientich()
        {
            Dientich = Bankinh*Bankinh*Pi;
            Console.WriteLine($"Dien tich hinh tron la: {Dientich}");

        }
    }
    class HinhCau:HinhTron
    {
        public double Thetich;

        public HinhCau()
        {
        }

        public new void Tinhdientich()
        {
            Dientich = Bankinh*Bankinh*Pi*4;
            Console.WriteLine($"Dien tich hinh cau la {Dientich}");
        }
        public void Tinhthetich()
        {
            Thetich = 4/3*Bankinh*Bankinh*Bankinh;
            Console.WriteLine($"The tich hinh cau la: {Thetich}");
        }
    }
    class HinhTruTron:HinhTron
    {
        public double Cvmd;
        public double Dtmd;
        public double Dtxq;
        public double Dttp;
        public double Ttht;
        public double Chieucao;
        public void Tinh()
        {
            Console.WriteLine("Nhap chieu cao:");
            Chieucao = int.Parse(Console.ReadLine());
            Cvmd = 2*Pi*Bankinh*Chieucao;
            Dtmd = Pi*Bankinh*Bankinh;
            Dtxq = 2*Pi*Bankinh*Chieucao;
            Dttp = Dtxq + Dtmd + Dtmd;
            Ttht = Pi*Bankinh*Bankinh*Chieucao;
            Console.WriteLine($"Chu vi mat day: {Cvmd}\n Dien tich mat day: {Dtmd}\n Dien tich xung quanh: {Dtxq}\n Dien tich toan phan: {Dttp}\n The tich:{Ttht}");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            HinhTron hinhtron = new HinhTron();
            hinhtron.Tinhdientich();

            HinhCau hinhcau = new HinhCau();
            hinhcau.Tinhdientich();
            hinhcau.Tinhthetich();

            HinhTruTron hinhtrutron = new HinhTruTron();
            hinhtrutron.Tinh();


        }
    }
}
