
using System.Runtime.Intrinsics.X86;
using System.Collections.Specialized;
using System;
using System.Collections.Generic;

namespace Bai1c2
{
private class Khenthuong
{
    public string MaBDS {get;set;}
    public string TenBDS {get;set;}
    public string Huong {get;set;}
    public string DiaChi {get;set;}
    public double Dientich{get;set;}
    public double GiaBan {get;set;}

    public Batdongsan(string mabds, string tenbds, string huong, string diachi, double dientich, double giaban)
    {
        this.MaBDS = mabds;
        this.TenBDS = tenbds;
        this.Huong = huong;
        this.DiaChi = diachi;
        this.Dientich = dientich;
        this.GiaBan = giaban;
    }
    public Batdongsan()
    {
    }
    public void Nhap()
    {
        Console.Write("Nhap ma BDS: ");
        MaBDS = Console.ReadLine();
        Console.Write("Nhap ten BDS: ");
        TenBDS = Console.ReadLine();
        Console.Write("Nhap huong:");
        Huong = Console.ReadLine();
        Console.Write("Nhap dia chi: ");
        DiaChi = Console.ReadLine();
        Console.Write("Nhap dien tich: ");
        Dientich = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap gia ban: ");
        GiaBan = Convert.ToDouble(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine($"Ma BDS la: {MaBDS}");
        Console.WriteLine($"Ten BDS la: {TenBDS}");
        Console.WriteLine($"Huong la: {Huong}");
        Console.WriteLine($"Dia chi la: {DiaChi}");
        Console.WriteLine($"Dien tich la: {Dientich}");
        Console.WriteLine($"Gia ban la: {GiaBan}");
        Console.WriteLine("------------");
    }
}
    
    internal class DanhsachBDS
    {
        static void Main(string[] args)
        {
            List<Batdongsan> batdongsan = new List<Batdongsan>();
            int choose;
            do
            {
                Menu();
                choose = Int32.Parse(Console.ReadLine());
                switch(choose)
                {
                    case 1:
                    Nhap(batdongsan);
                    break;
                    case 2:
                    
                    break;
                    case 3:
                    Xoa(batdongsan);
                    break;
                    case 4:
                    Xuat(batdongsan);
                    break;
                    case 5:
                    Timten(batdongsan);
                    break;
                    case 6:
                    break;
                    case 7:
                    Timtheogia(batdongsan);
                    break;
                    case 0:
                    Console.WriteLine("Ket thuc chuong trinh");
                    break;
                    default:
                    Console.WriteLine("Nhap sai!!");
                    break;

                }

            }  while(choose != 0);
        }
        static void Nhap(List<Batdongsan> batdongsan)
        {
            Console.WriteLine("Nhap so BDS can them: ");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i <n; i++)
            {
                Batdongsan bds = new Batdongsan();
                bds.Nhap();
                batdongsan.Add(bds);
            }
        }
        static void Xuat(List<Batdongsan> batdongsan)
        {
            for (int i = 0; i< batdongsan.Count; i++)
            {
                batdongsan[i].Xuat();
            }
        }
        static void Xoa(List<Batdongsan> batdongsan)
        {
            Console.WriteLine("Nhap MaBDS can xoa: ");
            string mabds = Console.ReadLine();
            for (int i = 0; i< batdongsan.Count; i++)
            {
                if(mabds==batdongsan[i].MaBDS)
                {
                    batdongsan.RemoveAt(i);
                }
            }
            Console.WriteLine("Xoa thanh cong");
        }
        static void Timten(List<Batdongsan> batdongsan)
        {
            Console.WriteLine("Nhap ten BDS can tim: ");
            string tenbds = Console.ReadLine();
            for (int i = 0; i<batdongsan.Count; i++)
            {
                if(tenbds==batdongsan[i].TenBDS)
                {
                    batdongsan[i].Xuat();
                }
            }
        }
        static void Xapxep(List<Batdongsan> batdongsan)
        {
         batdongsan.Sort((Batdongsan o1, Batdongsan o2)=>
         {
            return string.Compare(01.cc), StringComparison.OrdinalIgnoreCase)
         }
         )
        }
        static void Timtheogia(List<Batdongsan> batdongsan)
        {
            Console.WriteLine("Nhap khoang gia can tim: ");
            double gia1 = Convert.ToDouble(Console.ReadLine());
            double gia2 = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i<batdongsan.Count; i++)
            {
                if(gia1<batdongsan[i].GiaBan && batdongsan[i].GiaBan<gia2)
                {
                    batdongsan[i].Xuat();
                }
            }
        }
        static void Menu()
        {
            Console.WriteLine("+----------MENU----------+");
            Console.WriteLine("|-1.Them 1 BDS           |");
            Console.WriteLine("|-2.Sua 1 BDS            |");
            Console.WriteLine("|-3.Xoa 1 BDS            |");
            Console.WriteLine("|-4.Xuat 1 BDS           |");
            Console.WriteLine("|-5.Tim theo ten 1 BDS   |");
            Console.WriteLine("|-6.Tim theo huong BDS   |");
            Console.WriteLine("|-7.Tim theo gia 1 BDS   |");
            Console.WriteLine("|-0.Thoat chuong trinh   |");
            Console.WriteLine("+------------------------+");
        }
    }
}
