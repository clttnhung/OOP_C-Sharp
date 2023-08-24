/*using System;
namespace baitap3
{
    class Organization
    {
        static string Name;
        static string Country;
        static string City;
        static string Address;
        static string Telephone;
        public void Nhap()
        {
            Console.WriteLine("Nhap Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Nhap Country :");
            Country = Console.ReadLine();
            Console.WriteLine("Nhap  City :");
            City = Console.ReadLine();
            Console.WriteLine("Nhap Address  :");
            Address = Console.ReadLine();
            Console.WriteLine("Nhap Telephone :");
            Telephone = Console.ReadLine();

        }
        public void Xuat()
        {
                Console.WriteLine("{0},{1},{2},{3},{4}", Name, Country, City, Address, Telephone);
        }
        class Program
        {
            static void Main(string[] args)
            {
                Organization a = new Organization();
                while (true)
                {
                    try
                    {
                        int c = Convert.ToInt32(Telephone);
                        a.Nhap();
                        if ((Name != "") && (Country != "") && (City != "") && (Address != "") && (Telephone != "") && (Telephone.Length == 10))
                            a.Xuat();
                        else
                        {
                            Console.WriteLine("Thong tin khong hop le");
                            Console.ReadKey();
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Thong tin khong hop le");
                        Console.ReadKey();
                        break;
                    }

                }
            }
        }
    }
}*/


