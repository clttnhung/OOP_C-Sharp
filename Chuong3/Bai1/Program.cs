using System;

namespace Chuong3
{
   internal class Bai1
   {
       class Sach
       {
           public string Tensach;
           public string Tacgia;
           public float NamNB;
           public float Soluong;
           public Sach()
           {
               Tensach = "Sach";
               Tacgia = "Tacgia";
               NamNB = 2022;
               Soluong = 1;
           }
           public void Nhap()
           {
               Console.Write("Nhap ten sach: ");
               Tensach = Console.ReadLine();
               Console.Write("Nhap ten tac gia: ");
               Tacgia = Console.ReadLine();
               Console.Write("Nhap nam xuat ban: ");
               NamNB = float.Parse(Console.ReadLine());
               Console.Write("Nhap so luong: ");
               Soluong = float.Parse(Console.ReadLine());

           }

           public void Xuat()
           {
               Console.WriteLine("Ten sach: {0}, Tac gia:{1}, Nam xuat ban:{2}, So luong:{3}", Tensach, Tacgia, NamNB, Soluong);

           }
           ~Sach()
           {
               Console.WriteLine("Huy");
           }
           class Program
           {
               private static void Main(string[] args)
               {
                   Sach n = new Sach();
                   n.Nhap();
                   n.Xuat();
                   Sach n1 = new Sach();
                   n1.Xuat();
                   Console.ReadLine();
               }
           }
       }
   }

}