class Customer
{
    string ten;
    public double gia;
    public Customer()
    {

    }
    public Customer(string name,double price)
    {
        ten=name;
        gia=price;
    }
    public virtual void Nhap()
    {
        Console.Write("Ten: ");
        ten=Console.ReadLine();
    }
    public virtual void Deothe()
    {

    }

}
class Adult:Customer
{
    public static int d=0;
    string cmnd;
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("CMND: ");
        cmnd=Console.ReadLine();
        gia=250000;
        Console.WriteLine("Gia: 250000 "+gia);
        d++;
    }
    public override void Deothe()
    {
        Console.WriteLine("The do");
    }
}
class Children:Customer
{
    public static int dem=0;
    float chieucao;
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Chieu cao: ");
        chieucao=float.Parse(Console.ReadLine());
        if (chieucao>100)
        {
            gia=130000;
            Console.WriteLine("Gia: 130000 ");
            dem++;
        }
        else
        {
            gia=0;
            Console.WriteLine("Mien phi");
        }
        
        
    }
    public override void Deothe()
    {
        Console.WriteLine("The xanh");
    }
}
class Program
{
    static void Main()
    {
        int menu;
        Adult a=new Adult();
        Children c=new Children();
        Console.WriteLine("1. Nhap nguoi lon ");
        Console.WriteLine("2. Nhap tre em ");
        Console.WriteLine("3. Tinh doanh thu");
        Console.WriteLine("0. Thoat");
        while (true)
        {
            Console.WriteLine("Nhap tuy chon: ");
            menu=int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1: 
                {   
                    a.Nhap();
                    a.Deothe();
                    break;
                }

                case 2:  
                {
                    c.Nhap();
                    c.Deothe();
                    break;
                }
                case 3:
                {

                    Console.WriteLine("Doanh thu: {0}",Adult.d*250000+Children.dem*130000);
                    break;
                    
                }
                case 0:
                {
                    return;
                }
            }
        }
    }
}