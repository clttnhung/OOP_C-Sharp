
using System;

namespace Bai4
{
    public class Info
       {
            public int ID;
            public string Hoten ;   
            public string Group ;
            public int dem = 0;
            public Info()
            {
                Console.Write("Nhap MSV: ");
                ID = int.Parse(Console.ReadLine());
                Console.Write("Nhap Ho va Ten: ");
                Hoten = Console.ReadLine();
                Console.Write("Nhap ten lop: ");
                Group = Console.ReadLine();
            }
        }
    public class DiemTP
        {
            public int TP1;
            public int TP2;
            public int TP3;
            public DiemTP()
            {
                Console.Write("Nhap diem tp1: ");
                TP1 = int.Parse(Console.ReadLine());
                Console.Write("Nhap diem tp2: ");
                TP2 = int.Parse(Console.ReadLine());
                Console.Write("Nhap diem tp3: ");
                TP3 = int.Parse(Console.ReadLine());
            }
            public double Tinhdiemtb()
            {
                double dtb;
                dtb = TP1*0.1+TP2*0.3+TP3*0.6;
                return(dtb);
            }
        }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so luong sinh vien: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Info[] info = new Info[n];
            DiemTP[] diem = new DiemTP[n];
            for ( int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap thong tin sinh vien thu {i+1}");
                info[i] = new Info();
                diem[i] = new DiemTP();
            }
            for ( int i = 0; i < n; i++)
            {
                Console.WriteLine($"Thong tin sinh vien thu {i+1} la::\n MSV:{info[i].ID}\n Hoten: {info[i].Hoten}\n Lop: {info[i].Group}");
                Console.WriteLine($"Diem trung binh cua sinh vien {info[i].Hoten} la {diem[i].Tinhdiemtb()}");   
            }
        }
    }
}
