 using System;
 

namespace MyApp 
{
   public class Hinhhoc
   {
    public virtual void Nhap()
    {

    }
    public virtual void ChuVi()
    {

    }
    public virtual void Dientich()
    {

    }
   }
   class HinhChuNhat:Hinhhoc
   {
    public double chieudai ,chieurong;
    public override void Nhap()
    {
        Console.Write("Nhap chieu dai hinh chu nhat: ");
         chieudai = double.Parse(Console.ReadLine());
        Console.Write("Nhap chieu rong hinh chu nhat: ");
         chieurong = double.Parse(Console.ReadLine());
    }
    public override void ChuVi()
    {
        double chuvi = (chieudai+chieurong)*2;
        Console.WriteLine($"Chu vi hinh chu nhat la: {chuvi}");
    }
    public override void Dientich()
    {
        double dientich = chieudai*chieurong;
        Console.WriteLine($"Dien tich hinh chu nhat la: {dientich}");
    }
   }
   class HinhTron:Hinhhoc
   {
    public double bankinh;
    public double pi=3.14;
    public override void Nhap()
    {
        Console.Write("Nhap ban kinh hinh tron: ");
        bankinh= double.Parse(Console.ReadLine());
        
    }
    public override void ChuVi()
    {
        double chuvi = 2*pi*bankinh;
        Console.WriteLine($"Chu vi hinh tron la: {chuvi}");
    }
    public override void Dientich()
    {
        double dientich = 2*pi*bankinh*bankinh;
        Console.WriteLine($"Dien tich hinh tron la: {dientich}");
    }
   }
   class Hinhtamgiac:Hinhhoc
   {
    public double canhab, canhbc, canhca, chieucaodinha;
    public override void Nhap()
    {
        Console.Write("Nhap chieu dai canh AB: ");
        canhab = double.Parse(Console.ReadLine());
        Console.Write("Nhap chieu dai canh BC: ");
        canhbc = double.Parse(Console.ReadLine());
        Console.Write("Nhap chieu dai canh CA: ");
        canhca = double.Parse(Console.ReadLine());
        Console.Write("Nhap chieu cao dinh A: ");
        chieucaodinha = double.Parse(Console.ReadLine());
    }
    public override void ChuVi()
    {
        double chuvi = canhab+canhbc+canhca;
        Console.WriteLine($"Chu vi hinh tam giac la: {chuvi}");
    }
    public override void Dientich()
    {
        double dientich = 1/2*canhbc*chieucaodinha;
        Console.WriteLine($"Dien tich hinh tam giac la: {dientich}");
    }
   }
   class Hinhvuong:Hinhhoc
   {
    public double canh;
    public override void Nhap()
    {
        Console.Write("Nhap chieu dai canh hinh vuong: ");
        canh = double.Parse(Console.ReadLine());
        
    }
    public override void ChuVi()
    {
        double chuvi = 4*canh;
        Console.WriteLine($"Chu vi hinh vuong la: {chuvi}");
    }
    public override void Dientich()
    {
        double dientich = canh*canh;
        Console.WriteLine($"Dien tich hinh chu nhat la: {dientich}");
    }
   }
    internal class Bai1
    {
        static void Main(string[] args)
        {
           HinhChuNhat hcn = new HinhChuNhat();
           hcn.Nhap(); hcn.ChuVi(); hcn.Dientich();
           HinhTron ht = new HinhTron();
           ht.Nhap(); ht.ChuVi(); ht.Dientich();
           Hinhtamgiac htg = new Hinhtamgiac();
           htg.Nhap(); htg.ChuVi(); htg.Dientich();
           Hinhvuong hv = new Hinhvuong();
           hv.Nhap(); hv.ChuVi(); hv.Dientich();
        }
    }
}