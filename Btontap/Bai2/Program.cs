using System;
using System.IO;
using System.Text;
namespace bai2
{
    class Thangleo
    {
        public string MaThang{get;set;}
        public string LoaiThang;
        public string Chieucao;
        public string Soluong;
        public string GiaBan;
        public string [,] danhsach = new string [100,5];
        public int them()
        {
            String input = File.ReadAllText(@"C:\Users\ADMIN\Downloads\Thang.txt" );
            int i = 0, j = 0;
            foreach (var row in input.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(';'))
                {
                danhsach[i,j] = col.Trim();
                j++;
                }
                i++;
            }
            return i;
        }
    }
    class DanhsachThang
    {
        Thangleo moi = new Thangleo();
        public static int dem=0;
        bool co = true;
        public void danhsach()
        {
            dem=moi.them();
        }
        public void Nhap()
        { 
            while (true)
          { co=true;
            Console.WriteLine("Nhap ma thang:");
            moi.MaThang=Console.ReadLine();
            kiemtra(ref co);
            if (co==false)
            {Console.WriteLine("Ma da co!!!\nVui long nhap lai ma khac!!!");continue;}
            else 
            {Console.WriteLine("Nhap ma thanh thanh cong!!!");moi.danhsach[dem,0]=moi.MaThang;break;}
          } Console.WriteLine("Nhap vao loai thang:");
            moi.danhsach[dem,1]=moi.LoaiThang=Console.ReadLine();
            Console.WriteLine("Nhap chieu cao thang:");
            moi.danhsach[dem,2]=moi.Chieucao=Console.ReadLine();

            Console.WriteLine("Nhap so luong thang:");
            moi.danhsach[dem,3]=moi.Soluong=Console.ReadLine();

            Console.WriteLine("Nhap gia ban:");
            moi.danhsach[dem,4]=moi.GiaBan=Console.ReadLine();
            dem++;
        }
        public void kiemtra(ref bool co)
        {
            for (int i=0;i<dem;i++)
            {
                if (moi.MaThang==moi.danhsach[i,0])
                {
                    co=false;
                    break;
                }
            }
        }
        public void xuat()
        {
            Console.WriteLine("{0,-7} {1,-17} {2,-10} {3,-10} {4,-10}",
            "MaThang","LoaiThanh","ChieuCao","SoLuong","Giaban");
            for (int i=0;i<dem;i++)
            {
                Console.WriteLine("{0,-7} {1,-17} {2,-10} {3,-10} {4,-10}",
                moi.danhsach[i,0],moi.danhsach[i,1],moi.danhsach[i,2],moi.danhsach[i,3],moi.danhsach[i,4]);
            }
        }
        public void timtheochiucao()
        {   List<string> A =new List<string>();
            List<string> chiucao = new List<string>();
            Console.WriteLine("Nhap chieu cao (khoang 0-10):");
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<dem;i++)
            {
                if (a<=Convert.ToInt32(moi.danhsach[i,2]) & Convert.ToInt32(moi.danhsach[i,2])<=b)
                {A.Add(moi.danhsach[i,2]);}
            }
            chiucao.Add(A[0]);
            int c=0;
            while (true)
            {   int x=0;
                for (int j=0;j<chiucao.Count;j++){if (A[c]==chiucao[j])x++;}
                if (x==0){chiucao.Add(A[c]);}
                c++;
                if (c==A.Count){break;}
            }
            if (chiucao.Count==0){Console.WriteLine("Khong tim thay yeu cau!!!");}
            else
            {Console.WriteLine("{0,-7} {1,-17} {2,-10} {3,-10} {4,-10}",
                        "MaThang","LoaiThanh","ChieuCao","SoLuong","Giaban");
                for (int n=0; n<dem;n++)
                {   for(int t=0;t<chiucao.Count;t++)
                        {if (moi.danhsach[n,2]==chiucao[t])
                            {
                            Console.WriteLine("{0,-7} {1,-17} {2,-10} {3,-10} {4,-10}",
                            moi.danhsach[n,0],moi.danhsach[n,1],moi.danhsach[n,2],moi.danhsach[n,3],moi.danhsach[n,4]);
                            }
                        }
                }
            }
        }
        public void sapxep()
        {
            List<float> gia = new List<float>();
            List<float> A=new List<float>();
            for (int j=0; j<dem;j++)
            {
                A.Add(Convert.ToSingle(moi.danhsach[j,4]));
            }
            gia.Add(A[0]);
            int i=0;
            while(true)
            {
                int x=0;
                for (int c=0;c<gia.Count;c++)
                {
                    if (A[i]==gia[c]){x++;}
                }
                if (x==0){gia.Add(A[i]);}
                i++;
                if (i==A.Count){break;}
            }
            gia.Sort();
            Console.WriteLine("{0,-7} {1,-17} {2,-10} {3,-10} {4,-10}",
                        "MaThang","LoaiThanh","ChieuCao","SoLuong","Giaban");
            foreach (var a in gia)
                {   for (int x=0; x<dem;x++)
                    {if (Convert.ToSingle(moi.danhsach[x,4])==a)
                        {
                        Console.WriteLine("{0,-7} {1,-17} {2,-10} {3,-10} {4,-10}",
                        moi.danhsach[x,0],moi.danhsach[x,1],moi.danhsach[x,2],moi.danhsach[x,3],moi.danhsach[x,4]);
                        }
                    }
                }
        }
        public void kimtrasoluong()
        {   co=true;
            Console.WriteLine("Nhap vao ma thang va so luong muon mua:");
            moi.MaThang = Console.ReadLine();
            kiemtra(ref co);
            if (co==false)
            {int sl = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i<dem;i++)
            {
                if (moi.danhsach[i,0]==moi.MaThang)
                {
                    if (Convert.ToInt32(moi.danhsach[i,3])>=sl ){Console.WriteLine("OK");break;}
                    else {Console.WriteLine("CHI CON {0} THANG KHONG DU HANG",moi.danhsach[i,3]);break;}
                }
            }}
            else {Console.WriteLine("Khong co ma trong danh sach!!!");}
        }
        public void sosanh()
        {   
            List <float> gia = new List<float>();
            List<float> A = new List<float>();
            Console.WriteLine("Nhap loai thang\n(Thang rut,Thang bac, Thang ghe, Thang gap, Thang truot,Thang gac xep");
            string loai = Console.ReadLine();
            if (loai=="Thang rut"){Console.WriteLine("Chon 1 loai chieu cao [2,3,5]");}
            else if (loai=="Thang ghe"){Console.WriteLine("Chon 1 loai chieu cao [2,3]");}
            else if (loai=="Thang bac"){Console.WriteLine("Chon 1 loai chieu cao [2,3,4,5]");}
            else if (loai=="Thang gap"){Console.WriteLine("Chon 1 loai chieu cao [4,6,8]");}
            else if (loai=="Thang truot"){Console.WriteLine("Chon 1 loai chieu cao [5,6,8]");}
            else {Console.WriteLine("Chon 1 loai chieu cao [3,5]");}
            int cao=Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<dem;i++)
            {
                if (loai==moi.danhsach[i,1] && cao==Convert.ToInt32(moi.danhsach[i,2]))
                    {A.Add(Convert.ToSingle(moi.danhsach[i,4]));}
            }
            gia.Add(A[0]);
            int j=0;
            while(true)
            {
                int x =0;
                for (int i=0;i<gia.Count;i++){if(A[j]==gia[i]){x++;}}
                if (x==0){gia.Add(A[j]);}
                j++;
                if (j==A.Count){break;}
            }
            gia.Sort();
            if (gia.Count==1)Console.WriteLine("Thang {0} voi chieu cao {1} co gia la: {2}",loai,cao,gia[0]);
            else if (gia.Count>1) 
            {
                Console.WriteLine("{0,-7} {1,-17} {2,-10} {3,-10} {4,-10}",
                        "MaThang","LoaiThanh","ChieuCao","SoLuong","Giaban");
                for (int c=0;c<dem;c++)
                {
                    if (loai==moi.danhsach[c,1] && cao==Convert.ToSingle(moi.danhsach[c,2]) && gia[0]==Convert.ToSingle(moi.danhsach[c,4]))
                    {
                        Console.WriteLine("{0,-7} {1,-17} {2,-10} {3,-10} {4,-10}",
                        moi.danhsach[c,0],moi.danhsach[c,1],moi.danhsach[c,2],moi.danhsach[c,3],gia[0]);
                        break;
                    }
                }
                for (int c=0;c<dem;c++)
                {
                    if (loai==moi.danhsach[c,1] && cao==Convert.ToSingle(moi.danhsach[c,2]) && gia[(gia.Count)-1]==Convert.ToSingle(moi.danhsach[c,4]))
                    {
                        Console.WriteLine("{0,-7} {1,-17} {2,-10} {3,-10} {4,-10}",
                        moi.danhsach[c,0],moi.danhsach[c,1],moi.danhsach[c,2],moi.danhsach[c,3],gia[(gia.Count)-1]);
                        break;
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main()
        {   int tuychon;
            DanhsachThang mois = new DanhsachThang();
            mois.danhsach();
            Console.WriteLine("**************************MENU****************************");
            Console.WriteLine("*  1. Them moi danh sach                                 *");
            Console.WriteLine("*  2. Xuat danh sach                                     *");
            Console.WriteLine("*  3. Tim san pham                                       *");
            Console.WriteLine("*  4. Sap xep                                            *");
            Console.WriteLine("*  5. Kiem tra                                           *");
            Console.WriteLine("*  6. So sanh                                            *");            
            Console.WriteLine("*  0. Thoat khoi chuong trinh                            *");                                     
            Console.WriteLine("**********************************************************");
            while (true)
                {
                    Console.Write("Nhap tuy chon: ");
                    tuychon = Convert.ToInt32(Console.ReadLine());
                    switch(tuychon)
                    {
                        case 1: {mois.Nhap();break;}
                        case 2: {mois.xuat(); break;}
                        case 3: {mois.timtheochiucao(); break;}
                        case 4: {mois.sapxep(); break;}
                        case 5: {mois.kimtrasoluong(); break;}
                        case 6: {mois.sosanh(); break;}
                        case 0: {return;}
                    }
                }
        }
    }
}