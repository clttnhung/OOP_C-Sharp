using System;
namespace Chương_3
{
   internal class Bai4
   {
       class Triangle
       {
           public int menu;
           public int a;
           public int b;
           public int c;   
           public double d;
           public double S;
           public double n;
           
           public int Menu()
           {
               menu = int.Parse(Console.ReadLine());
               return menu;
           }
           public void Nhap()
           {
               Console.WriteLine("Nhap canh a: ");
               a = int.Parse(Console.ReadLine());
               Console.WriteLine("Nhap canh b");
               b = int.Parse(Console.ReadLine());
               Console.WriteLine("Nhap canh c");
               c = int.Parse(Console.ReadLine());
           }
           public void Xuat()
           {
               Console.WriteLine("Hinh tam giac: a = {0}, b = {1}, c = {2}", a, b, c);
           }
           public int Chuvi()
           {
               return (a + b + c);
           }
           public double Dientich()
           {
               d = (a + b + c)/2;
               S= Math.Sqrt(d * (d - a) * (d - b) * (d - c));
               return S;

           }
           bool Kiemtra()
           {
               if (a + b == c)
               {
                   return false;
               }
               if (a + c == b)
               {
                   return false;
               }
               if ((c + b) == a)
               {
                   return false;
               }
               return true;
           }

           class Program
           {
               static void Main(string[] args)
               {
                    
                    
                   Triangle n = new Triangle();
                   do
                   {
                       n.Menu();
                       if (n.Menu() == 1)
                       {
                           n.Nhap();
                       }
                       else if (n.Menu() == 2)
                       {
                           if (n.Kiemtra())
                           {
                               n.Xuat();
                               Console.WriteLine("Chu vi HCN: {0}, Dien tich HCN: {1}", n.Chuvi(), n.Dientich());
                               Console.ReadLine();
                           }
                           else
                           {
                               Console.WriteLine("Khong hop le");
                           }
                       }
                       else if (n.Menu() == 3)
                       {
                           n.Xuat();
                       }

                   } while (n.Menu()!=0);
               }
           }
       }
   }
}