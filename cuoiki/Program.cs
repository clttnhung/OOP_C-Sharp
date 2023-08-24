
using System;
public class NHANViEN
{
    public string manhanvien;
    public string hotennhanvien;
    public double hesoluong;
    public double luongcoban;
    public double tinhluong;
    public virtual void Nhap()
    {
        Console.Write("Nhap ma nhan vien: ");
        manhanvien = Console.ReadLine();
        Console.Write("Nhap ho ten nhan vien: ");
        hotennhanvien = Console.ReadLine();
        Console.Write("Nhap ma he so luong: ");
        hesoluong = double.Parse(Console.ReadLine());
        Console.Write("Nhap luong co ban nhan vien: ");
        luongcoban = double.Parse(Console.ReadLine());
        
    }
    public virtual double Tinhluong()
    {
        return tinhluong;
    }
    public virtual void Xuat()
    {
        Console.WriteLine($"Ma nhan vien la {manhanvien}");
        Console.WriteLine($"Ho ten nhan vien la {hotennhanvien}");
        Console.WriteLine($"He so luong nhan vien la {hesoluong}");
        Console.WriteLine($"Luong co ban la{luongcoban}");
    }
}
public class Congtacvien:NHANViEN
{
    public double phucap;
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap phu cap nhan vien ");
        phucap = double.Parse(Console.ReadLine());
    }
    public override double Tinhluong()
    {
        tinhluong = hesoluong*luongcoban*0.75+phucap;
        return tinhluong;
    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"Tien luong nhan vien la {tinhluong}");
    }
}
public class Nhanvienchinhthuc:NHANViEN
{
    public double KPI;
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap KPI nhan vien ");
        KPI = double.Parse(Console.ReadLine());
    }
    public override double Tinhluong()
    {
        tinhluong=(hesoluong*luongcoban)*(1+KPI);
        return tinhluong;
    }
    public override void Xuat()
    {
        base.Xuat();
        Console.Write($"Tien luong nhan vien la {tinhluong}");
    }
}
public class Quanly:NHANViEN
{
    public double phucapquanli;
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap phu cap quan li: ");
        phucapquanli = double.Parse(Console.ReadLine());
    }
    public override double Tinhluong()
    {
        tinhluong = hesoluong*luongcoban*2+phucapquanli;
        return tinhluong;
    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"Tien luong nhan vien la {tinhluong}");

    }
}
class cuoiki
{
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong nhan vien: ");
            int n = int.Parse(Console.ReadLine());
            NHANViEN[] nv = new NHANViEN[n];
            for(int i = 0; i<n; i++)
            {
                Console.WriteLine("Hay nhap tuy chon sau: "); 
                Console.WriteLine("1. Nhap cong tac vien  ");
                Console.WriteLine("2. Nhap nhan vien chinh thuc");
                Console.WriteLine("3. Nhap nhan quan li");

                    int Menu = Convert.ToInt32(Console.ReadLine());
                    switch (Menu)
                    {
                        case 1:
                        {
                            NHANViEN ctv = new Congtacvien();
                            ctv.Nhap();
                            ctv.Tinhluong();
                            ctv.Xuat();
                            nv[i]=ctv;
                            break;
                        }
                        case 2:
                        {
                            NHANViEN nvct = new Nhanvienchinhthuc();
                            nvct.Nhap();
                            nvct.Tinhluong();
                            nvct.Xuat();
                            nv[i]=nvct;
                            break;
                        }
                        case 3:
                        {
                            NHANViEN ql = new Quanly();
                            ql.Nhap();
                            ql.Tinhluong();
                            ql.Xuat();
                            nv[i]=ql;
                            break;
                        }
                    }
                }
                double max = nv[0].Tinhluong();
                    for(int j = 0; j<n; j++)
                    {
                        if (nv[j].Tinhluong()>max)
                        {
                        max = nv[j].Tinhluong();
                        }
                    }
                    Console.WriteLine($"Nhanvien luong cao nhat la: {max}");
                double min = nv[0].Tinhluong();
                for(int j = 0; j<n; j++)
                {
                    if (nv[j].Tinhluong()<min)
                    {
                    min = nv[j].Tinhluong();
                    }
                }
                Console.WriteLine($"Nhanvien luong cao nhat la: {min}");
            
        }
}
