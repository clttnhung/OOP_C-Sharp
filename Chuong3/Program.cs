using System;

class Organization
{
    public string Name;
    public string Country;
    public string City;
    public string Address;
    public string Telephone;
    public void Nhap()
    {
        Console.Write("Name:"); Name = (Console.ReadLine());
        Console.Write("Country:"); Country = (Console.ReadLine());
        Console.Write("City:"); City = (Console.ReadLine());
        Console.Write("Address:"); Address = (Console.ReadLine());
        Console.Write("Telephone:"); Telephone = Console.ReadLine();
    }
    public void Xuat()
    {
        Console.WriteLine("Thong tin Doanh Nghiep: {0}, {1}, {2}, {3}, {4}", Name, Country, City, Address, Telephone);
    }
    public bool KiemTra()
    {
        if (Name == "" | Country == "" | City == "" | Address == "" | Telephone.Length != 10)
        {
            return false;
        }
        else
            return true;
    }
    ~Organization()
    {
        Console.WriteLine("Huy");
    }
}
class program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Organization O = new Organization();
            O.Nhap();
            if (O.KiemTra() == true)
            {
                O.Xuat();
                break;
            }
            else
            {
                Console.WriteLine("Nhap thong tin loi");
                break;
            }
        }

    }
}
