// BAI 4
class Khachsan
{
    public virtual void Nhap()
    {
        Console.WriteLine("Nhap thong tin...");
    }
    public virtual void xuat()
    {
        Console.WriteLine("Xuat thong tin...");
    }
    public virtual void tienphong()
    {
        Console.WriteLine("Tien phong: ");
    }
    public virtual void tp()
    {
        Console.WriteLine("Tien phong luxury: ");
    }
}
class Standard:Khachsan
{
    private string [] ten=new string [100];
    private string [] cmnd=new string [100];
    private int [] songay=new int [100];
    private double [] gia= new double [100];
    private int n;
    private double tong;
    public override void Nhap()
    {
        Console.Write("So Khach hang muon thue: ");
        n=int.Parse(Console.ReadLine());
        for (int i=0;i<n;i++)
        {
            Console.WriteLine("Nhap thong tin khach hang thu {0}: ",i+1);
            Console.Write("Ten KH: ");
            ten[i]=Console.ReadLine();
            Console.Write("CMND KH: ");
            cmnd[i]=Console.ReadLine();
            Console.Write("So ngay thue: ");
            songay[i]=int.Parse(Console.ReadLine());
            if (songay[i]<=5)
            {
                gia[i]=500*songay[i];
            }
            else if(songay[i]>5)
            {
                gia[i]=400*songay[i];
            }
        }
    }
    public override void tienphong()
    {
        for (int i=0;i<n;i++)
        {
            tong=tong+gia[i];
        }
        Console.Write("TONG TIEN PHONG VIP: {0}",tong);
    }
    public override void xuat()
    {
        Console.WriteLine("THONG TIN KHACH HANG PHONG STANDARD:");
        for (int i=0;i<n;i++)
        {
            Console.WriteLine("KH: {0} - CMND: {1} - THUE: {2} - TIEN PHONG: {3}/{4} ngay thue",ten[i],cmnd[i],songay[i],gia[i],songay[i]);
        }
    }
}
class VIP:Khachsan
{
    private string [] name=new string [100];
    private string [] cm=new string [100];
    private int [] snt=new int [100];
    private double [] g1= new double [100];
    private double [] g2= new double [100];
    private string [] p= new string [100];
    private int m;
    private double s1,s2;
    public override void Nhap()
    {
        Console.Write("So Khach hang muon thue: ");
        m=int.Parse(Console.ReadLine());
        for (int i=0;i<m;i++)
        {
            Console.WriteLine("Nhap thong tin khach hang thu {0}: ",i+1);
            Console.Write("Ten KH: ");
            name[i]=Console.ReadLine();
            Console.Write("CMND KH: ");
            cm[i]=Console.ReadLine();
            Console.Write("So ngay thue: ");
            snt[i]=int.Parse(Console.ReadLine());
            Console.WriteLine("Ban chon(1 or 2): 1- Phong Luxury, 2- Phong President");
            Console.Write("Loai phong: ");
            p[i]=Console.ReadLine();
            if (p[i]=="1")
            {
                if (snt[i]<=5)
                {
                    g1[i]=1100;
                }
                if (snt[i]>5)
                {
                    g1[i]=100;
                }
            }
            if (p[i]=="2")
            {
                if (snt[i]<=5)
                {
                    g2[i]=1300;
                }
                if (snt[i]<=5)
                {
                    g2[i]=1000;
                }
            }
        }
    }
    public override void tienphong()
    {
        for (int i=0;i<m;i++)
        {
            if (p[i]=="1")
            {
                s1=s1+g1[i];
            }
            if (p[i]=="2")
            {
                s2=s2+g2[i];
            }
        }
        Console.WriteLine("TONG TIEN PHONG VIP: {0}",s1+s2);
    }
    public override void tp()
    {
        for (int i=0;i<m;i++)
        {
            if (p[i]=="1")
            {
                s1=s1+g1[i];
            }
        }
        Console.WriteLine("TONG TIEN PHONG LUXURY: {0}",s1);
    }
    public override void xuat()
    {
        Console.WriteLine("THONG TIN KHACH HANG PHONG VIP:");
        for (int i=0;i<m;i++)
        {
            if (p[i]=="1")
            {
                Console.WriteLine("KH: {0} - CMND: {1} - PHONG LUXURY - THUE: {2} - TIEN PHONG: {3}/{4} ngay thue",name[i],cm[i],snt[i],g1[i],snt[i]);
            }
            if (p[i]=="2")
            {
                Console.WriteLine("KH: {0} - CMND: {1} - PHONG PRESIDENT - THUE: {2} - TIEN PHONG: {3}/{4} ngay thue",name[i],cm[i],snt[i],g2[i],snt[i]);
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Khachsan s = new Standard();
        Khachsan v = new VIP();
        Console.WriteLine("MENU: ");
        Console.WriteLine("1. Standard ");
        Console.WriteLine("2. VIP");
        Console.WriteLine("0. Thoat");
        while (true)
        {
            Console.Write("Ban chon: ");
            string menu=Console.ReadLine();
            if (menu=="1")
            {
                s.Nhap();
                s.xuat();
            }
            if (menu=="2")
            {
                v.Nhap();
                v.xuat();
            }
            if (menu=="0")
            {
                Console.WriteLine("CAM ON QUY KHACH!!!");
                break;
            }
            Console.WriteLine("Ban co muon tiep tuc khong?");
        }
        Console.WriteLine("********TONG TIEN PHONG STANDARD VA VIP********");
        s.tienphong();
        v.tienphong();
        Console.WriteLine("********TAT CA THONG TIN PHONG STANDARD********");                                                                               `
        s.xuat();
        v.tp();
    }
}