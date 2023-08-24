
using System;
public class Khachhang
{
    public string ten;
    public int giave;
    public virtual void Nhap()
    {
        Console.Write("Nhap ten khach hang: ");
        ten = Console.ReadLine();
    }
    public virtual int Giave()
    {
        return giave;
    }
    public virtual void Xuat()
    {
         
    }
}
public class Nguoilon:Khachhang 
{
    public string cmnd;
    public static int demnl = 0;
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap so cmnd: ");
        cmnd = Console.ReadLine();
    }
    public override int Giave()
    {
        giave=250000;
        return giave;
       
    }
    public override void Xuat()
    {
        Console.WriteLine($"Ten khach hang la {ten}\nKhach hang deo the do\nGia ve la {giave}");
        demnl = demnl + giave;
    }
}
public class Treem:Khachhang
{
    public double chieucao;
    public static int demte = 0;
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap chieu khach hang: ");
        chieucao = double.Parse(Console.ReadLine());
    }
    public override int Giave()
    {
        if(chieucao>=1)
        {
            giave=130000;
        }
        else
        {
            giave=0;
        }
        return giave;
    }
    public override void Xuat()
    {
        Console.WriteLine($"Ten khach hang la {ten}\nKhach hang deo the xanh\nGia ve la {giave}");
        demte = demte + giave;
    }
}
class Bai1
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so khach hang: "); 
        int n = int.Parse(Console.ReadLine());
        int doanhthu; 
        Khachhang nl = new Nguoilon();
        Khachhang te = new Treem();
        for(int i = 0; i<n; i++)
        {
            Console.WriteLine("Doi tuong khach hang: ");
            Console.WriteLine("1.Nguoi lon");
            Console.WriteLine("2.Tre em "); 
            int menu = int.Parse(Console.ReadLine());
            switch(menu)
            {
                case 1:
                nl.Nhap();
                nl.Giave();
                nl.Xuat();
                break;
                case 2:
                te.Nhap();
                te.Giave();
                te.Xuat();
                break;
            }
        }
        doanhthu=Nguoilon.demnl+Treem.demte;
        Console.WriteLine($"Doanh thu ban hang la {doanhthu}");
    }
}
