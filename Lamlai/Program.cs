class Vinhome
{
    public int ID;
    public int Area;
    public int Floor;
    public virtual void Nhap()
    {
        Console.WriteLine("ID: ");
        ID=int.Parse(Console.ReadLine());
        Console.WriteLine("Area: ");
        Area=int.Parse(Console.ReadLine());
        Console.WriteLine("Floor: ");
        Floor=int.Parse(Console.ReadLine());
    }
    public virtual double Tinhgia()
    {
        return 0;

    }
    
    public virtual void Xuat()
    {
        Console.WriteLine("ID: {0}, Area: {1}, Floor: {2}", ID, Area, Floor);
    }
}
class Basicc : Vinhome
{
    public double Giasancb, Gia;
    public override void Nhap()
    {
        base.Nhap();
        Console.WriteLine("Gia san co ban: ");
        Giasancb=double.Parse(Console.ReadLine());
    }
    public override double Tinhgia()
    {
        Gia= Giasancb* Area;
        Console.WriteLine($"Gia: {Gia}");
        return Gia;
    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine("Gia: ",Gia); 
    }
    
}
class Caocap : Vinhome
{
    public double Giasancc, Gia;
    public string View;
    public double Hesohuong;
    public override void Nhap()
    {
        base.Nhap();
        Console.WriteLine("Gia san cao cap la: ");
        Giasancc=double.Parse(Console.ReadLine());
        Console.WriteLine("View: ");
        View=Console.ReadLine();
        if (View=="Bien") 
        {Hesohuong=1.4;}
        else if (View=="Ho boi")
        {Hesohuong=1.1;}
        else if (View=="Thanh pho")
        {Hesohuong=1.2;}
        else{Hesohuong=1.0;}

    }
    public override double Tinhgia()
    {
        Gia=Hesohuong*Giasancc*Area;
        return Gia;
    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine("Gia: ",Gia);
    }
    class Program
    {
       static void Main (string[] args)
       {
        Vinhome[] vh;
        int n;
        double maxGia = 0.0;
        int canHoGaCaoNhat = 0;
        Console.Write("Nhap so luong Canho: ");
        n=int.Parse(Console.ReadLine());
        vh = new Vinhome[n];
        for (int i=0;i<n;i++)
        {
            Console.WriteLine("Hay nhap tuy chon sau: "); 
            Console.WriteLine("1.Can ho co ban");
            Console.WriteLine("2. Can ho cao cap");
            int option = int.Parse(Console.ReadLine());
            if(option == 1){
                Console.WriteLine("Can ho co ban: ");
                Vinhome vh1 = new Basicc();
                vh1.Nhap();
                var gia = vh1.Tinhgia();
                if(gia >  maxGia) {
                    canHoGaCaoNhat = i;
                    maxGia = gia;
                };
                vh[i]=vh1;
                Console.WriteLine($"canHoGaCaoNhat: {canHoGaCaoNhat}");
            }
            else {
                Console.WriteLine("Can ho cao cap: ");
                Vinhome vh2 = new Caocap();
                vh2.Nhap();
                var gia =  vh2.Tinhgia();
                if(gia >  maxGia) {
                    canHoGaCaoNhat = i;
                    maxGia = gia;
                };
                vh[i]=vh2;
            }
           
            
            
        }
        Console.WriteLine("Danh sach da nhap la: ");
        {
            for (int i=0; i<n; i++)
            {
                vh[i].Xuat();

            }
        }
        Console.WriteLine("CAN HO CO GIA CAO NHAT LA: ");
        vh[canHoGaCaoNhat].Xuat();
        Console.ReadLine();


       }
    }
}