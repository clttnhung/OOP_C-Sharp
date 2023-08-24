
public class PHONG
{
    public string tenkh;
    public string cmnd;
    public int ngaythue;
    public int tienthue;
    public int tongtienLu ;
    public virtual void Nhap()
    {
        Console.Write("Nhap ten khach hang: ");
        tenkh = Console.ReadLine();
        Console.Write("Nhap so cmnd: ");
        cmnd = Console.ReadLine();
        Console.Write("Nhap ngay thue: ");
        ngaythue = int.Parse(Console.ReadLine());
    }
    public virtual int Tinh()
    {
        return 0;
    }
    public virtual int TinhtienLu()
    {
        return tongtienLu;       
    }
    public virtual void Xuat()
    {
        Console.WriteLine($"Ten khach hang la {tenkh}");
        Console.WriteLine($"So cmnd khach hang la {cmnd}");
        Console.WriteLine($"Ngay khach hang thue la {ngaythue}");
        Console.WriteLine($"Tong tien khach hang phai tra la {tienthue}");
    }
}
public class STANDARD:PHONG
{
    public override void Nhap()
    {
        base.Nhap();
    }
    public override int Tinh()
    {
        if(ngaythue<5)
        {
            tienthue=500*ngaythue;
        }
        else if(ngaythue>=5)
        {
            tienthue=400*ngaythue;
        }
        return tienthue;
    }
    public override int TinhtienLu()
    {
        return tongtienLu;
    }
    public override void Xuat()
    {
        base.Xuat();
    }
}
public class Vip:PHONG
{
    public string loaiphong;
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap ten loai phong: ");
        loaiphong=Console.ReadLine();
    }
    public override int Tinh()
    {
        if (ngaythue<5)
        {
            if (loaiphong=="Luxury")
            {
                tienthue=1100*ngaythue;
            }
            else
            {
                tienthue=1300*ngaythue;
            }
        }
        else
        {
            tienthue=1000*ngaythue;
        }
               
        return tienthue;
    }
    public override int TinhtienLu()
    {
        if (loaiphong=="Luxury")
            {
                tongtienLu=tongtienLu+tienthue;   
            }
        else
        {
            tongtienLu=tongtienLu+0;
        }
            return tongtienLu;
    }
    public override void Xuat()
    {
        base.Xuat();
    }
}
class Bai4c6
{
    static void Main(string[] args)
    {
        int tongtienphong = 0;
        int tongtienLuxyry = 0;
        int m = 0;
        PHONG[] phong = new PHONG[100];
       Console.Write("Nhap so khach hang: ");
       int n = int.Parse(Console.ReadLine());
       for(int i = 0; i<n; i++)
       {
            Console.WriteLine("Hay nhap tuy chon sau: "); 
            Console.WriteLine("1. Nhap thong tin phong Standard");
            Console.WriteLine("2. Nhap thong tin phong Vip");
            int menu = int.Parse(Console.ReadLine());
            switch(menu)
            {
                case 1:
                m = m + 1;
                PHONG st = new STANDARD();
                st.Nhap();
                st.Tinh();
                st.Xuat();
                phong[m-1] = st;
                tongtienphong=tongtienphong+st.Tinh();
                break;
                case 2:
                PHONG vip = new Vip();
                vip.Nhap();
                vip.Tinh();
                vip.Xuat();
                tongtienphong=tongtienphong+vip.Tinh();
                tongtienLuxyry=tongtienLuxyry+vip.TinhtienLu();
                break;
            } 
       }
        Console.WriteLine($"Tong tien phong la: {tongtienphong}");
        Console.WriteLine($"Tong tien phong Luxury la: {tongtienLuxyry}");
        
        Console.WriteLine("Thong tin phong loai Standard la:");  
        for(int j=0; j<m; j++)
            {
                phong[j].Xuat();
            }
    }
}

