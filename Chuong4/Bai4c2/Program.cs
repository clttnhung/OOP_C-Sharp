
using System;

namespace Bai4c2
{
       public class Info
       {
            public int ID;
            public string Hoten;   
            public string Group;
            static int dem = 0;
            public Info()
            {
                Console.Write("Nhap MSV: ");
                ID = int.Parse(Console.ReadLine());
                Console.Write("Nhap Ho va Ten: ");
                Hoten = Console.ReadLine();
                Console.Write("Nhap ten lop: ");
                Group = Console.ReadLine();
                dem++;
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
                    Info SV = new Info();
                    DiemTP Diem = new DiemTP();
                    Console.WriteLine($"Tong so sinh vien da nhap la: {dem}");
                    Console.WriteLine($"Thong tin sinh vien:\n MSV:{SV.ID}\n Hoten: {SV.Hoten}\n Lop: {SV.Group}");
                    Console.WriteLine($"Diem trung binh cua sinh vien {SV.ID} la {Diem.Tinhdiemtb()}");
                    Info SV1 = new Info();
                    DiemTP Diem1 = new DiemTP();
                    Console.WriteLine($"Tong so sinh vien da nhap la: {dem}");
                    Console.WriteLine($"Thong tin sinh vien:\n MSV:{SV1.ID}\n Hoten: {SV1.Hoten}\n Lop: {SV1.Group}");
                    Console.WriteLine($"Diem trung binh cua sinh vien {SV1.ID} la {Diem1.Tinhdiemtb()}");
                    }
                }
       }
}
        