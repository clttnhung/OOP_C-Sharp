
using System;

namespace Shape 
{
    interface Shape
    {

        double TinhCV();
        double TinhDT();
    }
    public class Circle:Shape
    {
        public double Bankinh;
        public double TinhCV()
        {
            Console.Write("Nhap ban kinh: ");
            Bankinh = Double.Parse(Console.ReadLine());
            return 2*Bankinh*3.14;
        }
        public double TinhDT()
        {
            return 3.14*Bankinh*Bankinh;
        }
    }
    public class Redangle:Shape
    {
        public double ChieuDai;
        public double ChieuRong;
        public double TinhCV()
        {
            Console.Write("Nhap chieu dai: ");
            ChieuDai = Double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            ChieuRong = Double.Parse(Console.ReadLine());
            return 2*(ChieuDai+ChieuRong) ;
        }
        public double TinhDT()
        {
            return ChieuDai*ChieuRong;
        }
    }
    public class Triangle:Shape
    {
        public double CanhA = 3;
        public double CanhB = 3;
        public double CanhC = 3;
        public double TinhCV()
        {
            Console.Write("Nhap do dai canh A: ");
            CanhA = Double.Parse(Console.ReadLine());
            Console.Write("Nhap do dai canh B: ");
            CanhB = Double.Parse(Console.ReadLine());
            Console.Write("Nhap do dai canh C: ");
            CanhC = Double.Parse(Console.ReadLine());
            return CanhA+CanhB+CanhC ;
        }
        public double TinhDT()
        {
            double p = (CanhA+CanhB+CanhC)/2;
            return Math.Sqrt(p*(p-CanhA)*(p-CanhB)*(p-CanhC)) ;
        } 
    }
    public class Tinh
    {
        public static void Main(string[] args)
        {
            Shape a1 = new Circle();
            Shape a2 = new Redangle();
            Shape a3 = new Triangle();
            Console.WriteLine("**Hinh tron**");
            Console.WriteLine($"Chu vi hinh tron la: {a1.TinhCV()}");
            Console.WriteLine($"Dien tinh hinh tron la: {a1.TinhDT()}");
            Console.WriteLine("**Hinh chu nhat**");
            Console.WriteLine($"Chu vi hinh chu nhat la: {a2.TinhCV()}");
            Console.WriteLine($"Dien tinh hinh chu nhat la: {a2.TinhDT()}");
            Console.WriteLine("**Hinh tam giac**");
            Console.WriteLine($"Chu vi hinh tam giac la: {a3.TinhCV()}");
            Console.WriteLine($"Dien tinh hinh tam giac la: {a3.TinhDT()}");
        }
    }
}

