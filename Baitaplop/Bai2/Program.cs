 
using System.Xml.Serialization;
using System;
 

namespace MyApp 
{

    public class Canho
    {
        public string ID;
        public double Area;
        public string Floor;
        public double Price;
        public double Max=0;
        public virtual void Nhap()
        {
            Console.Write("Nhap ma: ");
            ID = Console.ReadLine();
            Console.Write("Nhap dien tich: ");
            Area = double.Parse(Console.ReadLine());
            Console.Write("Nhap so tang:");
            Floor = Console.ReadLine();
        } 
        public virtual double Tinh()
        {
            return 0;
        }
        public virtual void Xuat()
        {
            Console.WriteLine($"Gia cua can ho la {Price}");
        }
    }
    public class Basic:Canho
    {
        public double Sancb;
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap gia san co ban: ");
            Sancb = double.Parse(Console.ReadLine());
        }
        public override double Tinh()
        {
            Price = Sancb*Area;
            return Price;
        }
        public override void Xuat()
        {
            base.Xuat();
        }
    }
    public class Condo:Canho
    {
        public double Sancc;
        public string Huong;
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap gia san cao cap: ");
            Sancc = double.Parse(Console.ReadLine());
            Console.Write("Nhap huong: ");
            Huong = Console.ReadLine();
        }
        public override double Tinh()
        {
              if(Huong=="Bien")
            {
               Price = Sancc*Area*1.4;
            }
            if(Huong=="Hoboi")
            {
               Price = Sancc*Area*1.1;
            }
            if(Huong=="Thanhpho")
            {
               Price = Sancc*Area*1.2;
            }
            if(Huong=="Khac")
            {
                Price = Sancc*Area*1.0;
            }
            return Price;
        }
        public override void Xuat()
        {
            base.Xuat();
        }
    }
    internal class Bai2
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so can ho can nhap: ");
            int n = int.Parse(Console.ReadLine());
            Canho[] canho = new Canho[n];
            for(int i = 0; i<n; i++)
            {
                Console.WriteLine("Hay nhap tuy chon sau: "); 
                Console.WriteLine("1. Nhap thong tin can ho co ban ");
                Console.WriteLine("2. Nhap thong tin can ho cao cap");
                //Console.WriteLine("0. Thoat khoi chuong trinh");
                    int Menu = Convert.ToInt32(Console.ReadLine());
                    switch (Menu)
                    {
                        case 1:
                        {
                            Canho basic = new Basic();
                            basic.Nhap();
                            basic.Tinh();
                            basic.Xuat();
                            canho[i]=basic;
                            break;
                        }
                        case 2:
                        {
                            Canho condo = new Condo();
                            condo.Nhap();
                            condo.Tinh();
                            condo.Xuat();
                            canho[i]=condo;
                            break;
                        }
                        // case 3:
                        // {
                            
                        //     return;
                        // }
                        // case 0:
                        // {
                        //     return;
                        // }
                    }
                    // double max = canho[0].Tinh();
                    // for(int j = 0; j<n; j++)
                    // {
                    //     if (canho[i].Tinh()>max)
                    //     {
                    //     max = canho[i].Tinh();
                    //     }
                    // }
                    // Console.WriteLine($"Can ho co gia cao nhat la: {max}");
                    // for (int j =0; j<n; j++)
                    // {
                    //     if(canho[i].Tinh()==max)
                    //     {
                    //         Console.WriteLine($"Can ho co gia cao nhat la: {max}");
                    //         break;
                    //     }                        
                    // }
                    
                }
                double max = canho[0].Tinh();
                    for(int j = 0; j<n; j++)
                    {
                        if (canho[j].Tinh()>max)
                        {
                        max = canho[j].Tinh();
                        }
                    }
                    Console.WriteLine($"Can ho co gia cao nhat la: {max}");
        //   while(true)
        //     {
        //     Console.WriteLine("Hay nhap tuy chon sau: "); 
        //     Console.WriteLine("1. Nhap thong tin can ho co ban: ");
        //     Console.WriteLine("2. Nhap thong tin can ho cao cap");
        //     Console.WriteLine("0. Thoat khoi chuong trinh");
        //         int Menu = Convert.ToInt32(Console.ReadLine());
        //         switch (Menu)
        //         {
        //             case 1:
        //             {
        //                 basic.Nhap();
        //                 basic.Xuat();
        //                 break;
        //             }
        //             case 2:
        //             {
        //                 condo.Nhap();
        //                 basic.Xuat();
        //                 break;
        //             }
        //             case 0:
        //             {
        //                 return;
        //             }
        //         }
        //     }
        }
    }
}