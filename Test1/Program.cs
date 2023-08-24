
class People 
{
    public string [] id;
    public string [] hoten;
    public string [] diachi;
    public double [] tuoi;
    public int m;
    // public People()
    // {

    // }
    // public People(int m,string [] id, string [] hoten, string [] diachi, double [] tuoi)
    // {
    //     this.m=m;
    //     this.id=id;
    //     this.hoten=hoten;
    //     this.diachi=diachi;
    //     this.tuoi=tuoi;
    // }
    public void Nhap()
    {
        Console.Write("So lan nhap: ");
        m=int.Parse(Console.ReadLine());
        id=new string [m];
        hoten=new string [m];
        diachi=new string [m];
        tuoi=new double [m];
        for (int i=0;i<m;i++)
        {
            Console.WriteLine("Nhap thong tin thu "+(i+1));
            Console.Write("Nhap ID: ");
            id[i]=Console.ReadLine();
            Console.Write("Nhap Ho ten: ");
            hoten[i]=Console.ReadLine();
            Console.Write("Tuoi: ");
            tuoi[i]=double.Parse(Console.ReadLine());
            Console.Write("Nhap dia chi: ");
            diachi[i]=Console.ReadLine();
        }
    }
    public void Xuat()
    {
        for (int i=0;i<m;i++)
        {
            Console.WriteLine("ID: {0} - Ho Ten: {1} - Tuoi: {2} - Dia chi: {3} ",id[i],hoten[i],tuoi[i],diachi[i]);
        }
    }
}
class Students:People
{
    public string [] term;
    public double [] tp1;
    public double [] tp2;
    public double [] tp3;
    // public Students()
    // {

    // }
    // public Students(int m,string [] id, string [] hoten, string [] diachi, double [] tuoi,string [] term, double [] tp1, double [] tp2, double [] tp3):base(m,id,hoten,diachi,tuoi)
    // {
    //     this.term=term;
    //     this.tp1=tp1;
    //     this.tp2=tp2;
    //     this.tp3=tp3;
    // }
    public void Nhaptt()
    {
        term=new string [m];
        tp1=new double [m];
        tp2=new double [m];
        tp3=new double [m];
        for (int i=0;i<m;i++)
        {
            Console.WriteLine("Nhap thong tin sv co id: "+id[i]);
            Console.Write("Term: ");
            term[i]= Console.ReadLine();
            Console.Write("TP1: ");
            tp1[i]=double.Parse(Console.ReadLine());
            Console.Write("TP2: ");
            tp2[i]=double.Parse(Console.ReadLine());
            Console.Write("TP3: ");
            tp3[i]=double.Parse(Console.ReadLine());
        }
    }
    public void GPA()
    {
        string xeploai="";
        for (int i=0;i<m;i++)
        {
            double dtb=(tp1[i]*0.1+tp2[i]*0.3+tp3[i]*0.6);
            if (dtb>=8.5 && dtb<=10)
            {
                xeploai="Gioi";
            }
            else if (dtb>=7.0 && dtb<=8.4)
            {
                xeploai="Kha";
            }
            else if (dtb>=5.5 && dtb<=6.9)
            {
                xeploai="Trung Binh";
            }
            else if (dtb>=4.0 && dtb<=5.4)
            {
                xeploai="Trung Binh Yeu";
            }
            else if (dtb>=0 && dtb<=4.0)
            {
                xeploai="Yeu";
            }
            Console.WriteLine(" Hoc phan: {0} - TP1 = {1} - TP2 = {2} - TP3 = {3} - DTB= {4} - Xep loai: {5} ",term[i],tp1[i],tp2[i],tp3[i],dtb,xeploai);
        }
    }
}
class Lecture:People
{
    public double [] kn;
    public string [] hv;
    public string [] cv;
    // public Lecture()
    // {

    // }
    // public Lecture(int m,string [] id, string [] hoten, string [] diachi, double [] tuoi,double [] kn,string [] hv, string [] cv):base(m,id,hoten,diachi,tuoi)
    // {
    //     this.kn=kn;
    //     this.hv=hv;
    //     this.kn=kn;
    // }
    public void Nhaptt()
    {
        kn=new double [m];
        hv=new string [m];
        cv=new string [m];
        for (int i=0;i<m;i++)
        {
            Console.WriteLine("Thong tin cua gia vien co id: ",id[i]);
            Console.Write("Nhap so nam kinh nghiem: ");
            kn[i]=double.Parse(Console.ReadLine());
            Console.Write("Nhap hoc vi: ");
            hv[i]=Console.ReadLine();
            Console.Write("Nhap chuc vu: ");
            cv[i]=Console.ReadLine();
        }
    }
    public void Xuattt()
    {
        for (int i=0;i<m;i++)
        {
            for (int j=i+1;j<m;j++)
            {
                if (kn[i]<kn[j])
                {
                    double tmp=kn[i];
                    string a=id[i];
                    string b=hoten[i];
                    double c=tuoi[i];
                    string d=diachi[i];
                    string e=hv[i];
                    string f=cv[i];
                    kn[i]=kn[j];
                    id[i]=id[j];
                    hoten[i]=hoten[j];
                    tuoi[i]=tuoi[j];
                    diachi[i]=diachi[j];
                    hv[i]=hv[j];
                    cv[i]=cv[j];
                    kn[j]=tmp;
                    id[j]=a;
                    hoten[j]=b;
                    tuoi[j]=c;
                    diachi[j]=d;
                    hv[j]=e;
                    cv[j]=f;
                }
            }
        }
        for (int i=0;i<m;i++)
        {
            Console.WriteLine("ID: {0} | Ho ten: {1} | Tuoi: {2} | Dia chi: {3} | Kinh nghiem: {4} | Hoc vi: {5} | Chuc vu: {6} |",id[i],hoten[i],tuoi[i],diachi[i],kn[i],hv[i],cv[i]);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("BAI TAP 2a");
        Students k = new Students();
        k.Nhap();
        k.Nhaptt();
        k.Xuat();
        k.GPA();
        Console.WriteLine("BAI TAP 2b");
        Lecture h = new Lecture();
        Console.WriteLine("NHAP THONG TIN CUA GIANG VIEN");
        h.Nhap();
        h.Nhaptt();
        Console.WriteLine("XUAT THONG TIN");
        h.Xuattt();
    }
}
// // // =====================================================================================
