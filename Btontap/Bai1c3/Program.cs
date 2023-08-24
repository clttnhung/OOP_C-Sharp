using System.Collections;
using System;
namespace HelloWorld
{
    class bai1c3
    {
        private string MABDS, TenBDS, Huong, DiaChi;
        private float DienTich, GiaBan;

        private int dat = 200;
        private int re = 100;

        public String dinhgia(){
            if (this.getGiaBan()>dat) return "dat";
            if (this.getGiaBan()>re) return "re";
            return "revailon";
        }

        public BDS()
        {
            this.MABDS = "";
            this.TenBDS = "";
            this.Huong = "";
            this.DiaChi = "";
            this.DienTich = 0;
            this.GiaBan = 0;
        }

        public BDS(string MABDS, string TenBDS, string Huong, string DiaChi, float DienTich, float GiaBan)
        {
            this.MABDS = MABDS;
            this.TenBDS = TenBDS;
            this.Huong = Huong;
            this.DiaChi = DiaChi;
            this.DienTich = DienTich;
            this.GiaBan = GiaBan;
        }

        public String toString(){
            return String.Format("MABDS:{0} => [TenBDS:{1}, HuongBDS:{2}, DiaChi:{3}, Dientich:{4} m2, GiaBan:{5} d]",
            this.getMABDS(), this.getTenBDS(), this.getHuong(), this.getDiaChi(),this.getDienTich(), this.getGiaBan());
        }

        public String getMABDS()
        {
            return MABDS;
        }

        public void setMABDS(String mABDS)
        {
            MABDS = mABDS;
        }

        public String getTenBDS()
        {
            return TenBDS;
        }

        public void setTenBDS(String tenBDS)
        {
            TenBDS = tenBDS;
        }

        public String getHuong()
        {
            return Huong;
        }

        public void setHuong(String huong)
        {
            Huong = huong;
        }

        public String getDiaChi()
        {
            return DiaChi;
        }

        public void setDiaChi(String diaChi)
        {
            DiaChi = diaChi;
        }

        public float getDienTich()
        {
            return DienTich;
        }

        public void setDienTich(float dienTich)
        {
            DienTich = dienTich;
        }

        public float getGiaBan()
        {
            return GiaBan;
        }

        public void setGiaBan(float giaBan)
        {
            GiaBan = giaBan;
        }


    }

    class Program
    {
        public static void printMenu()
        {
            Console.WriteLine("+----------MENU----------+");
            Console.WriteLine("|-1.Them 1 BDS           |");
            Console.WriteLine("|-2.Sua 1 BDS            |");
            Console.WriteLine("|-3.Xoa 1 BDS            |");
            Console.WriteLine("|-4.Xuat 1 BDS           |");
            Console.WriteLine("|-5.Tim theo ten 1 BDS   |");
            Console.WriteLine("|-6.Tim theo huong BDS   |");
            Console.WriteLine("|-7.Tim theo gia 1 BDS   |");
            Console.WriteLine("|-0.Thoat chuong trinh   |");
            Console.WriteLine("+------------------------+");

        }
        //  Nhap 1 BDS
        public static BDS inBDS()
        {
            string MABDS, TenBDS, Huong, DiaChi;
            float DienTich, GiaBan;
            System.Console.WriteLine("Nhap Ma BDS:");
            MABDS = Console.ReadLine();

            System.Console.WriteLine("Nhap TenBDS:");
            TenBDS = Console.ReadLine();

            System.Console.WriteLine("Nhap Huong:");
            Huong = Console.ReadLine();

            System.Console.WriteLine("Nhap DiaChi:");
            DiaChi = Console.ReadLine();

            System.Console.WriteLine("Nhap DienTich:");
            DienTich = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Nhap GiaBan:");
            GiaBan = Convert.ToInt32(Console.ReadLine());

            BDS a = new BDS(MABDS,TenBDS,Huong,DiaChi,DienTich,GiaBan);
            return a;
        }

        // cap nhat
         public static BDS updateBDS(BDS a)
        {
            BDS tmp = a;

            string TenBDS, Huong, DiaChi;
            float DienTich, GiaBan;
            System.Console.WriteLine("Nhap TenBDS:");
            TenBDS = Console.ReadLine();
            if (!TenBDS.Equals(""))tmp.setTenBDS(TenBDS);

            System.Console.WriteLine("Nhap Huong:");
            Huong = Console.ReadLine();
            if (!Huong.Equals(""))tmp.setHuong(Huong);

            System.Console.WriteLine("Nhap DiaChi:");
            DiaChi = Console.ReadLine();
            if (!DiaChi.Equals(""))tmp.setDiaChi(DiaChi);

            System.Console.WriteLine("Nhap DienTich:");
            string dt = Console.ReadLine();
            if (!dt.Equals("")) tmp.setDienTich(Convert.ToInt32(dt));

            System.Console.WriteLine("Nhap GiaBan:");
            string gb = Console.ReadLine();
            if (!gb.Equals("")) tmp.setGiaBan(Convert.ToInt32(gb));
        
            return tmp;
        }
        

        static void Main(string[] args)
        {
            ArrayList BDSList = new ArrayList();
            int sw = 1;
            string choose;
            Boolean cont = true;
            while (cont)
            {
                printMenu();
                Boolean k = false;
                while (!k)
                {
                    try
                    {
                        choose = Console.ReadLine();
                        sw = Convert.ToInt32(choose);
                        k = true;
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Vui long nhap so!!");
                    }
                }
                
                // sw = Convert.ToInt32(Console.ReadLine());

                switch (sw)
                {
                    case 0:
                        Console.WriteLine("Tam biet!!");
                        cont = false;
                        break;
                    case 1:
                        BDSList.Add(inBDS());
                        System.Console.WriteLine("Nhap thanh cong!!!");
                        break;
                    case 2:
                        Console.WriteLine("Nhap MABDS can sua");
                        string MABDS = Console.ReadLine();
                        Boolean kt = false;
                        for (int i = 0; i < BDSList.Count; i++){
                            if (BDSList[i].GetType() == typeof(BDS) && ((BDS)BDSList[i]).getMABDS().Equals(MABDS)){
                                BDSList[i] = updateBDS((BDS)BDSList[i]);
                                System.Console.WriteLine("Update thanh cong!!!");
                                kt = true;
                                break;
                            }
                        }
                        if (!kt) System.Console.WriteLine("Khong tim thay ID!!!");
                        break;
                    case 3:
                        Console.WriteLine("Nhap MABDS can xoa");
                        string MABDS2 = Console.ReadLine();
                        Boolean kt2 = false;
                        for (int i = 0; i < BDSList.Count; i++){
                            if (BDSList[i].GetType() == typeof(BDS) && ((BDS)BDSList[i]).getMABDS().Equals(MABDS2)){
                                BDSList.RemoveAt(i);
                                System.Console.WriteLine("Xoa thanh cong!!!");
                                kt2 = true;
                                break;
                            }
                        }
                        if (!kt2) System.Console.WriteLine("Khong tim thay ID!!!");
                        break;
                    case 4:
                        Console.WriteLine("Danh sach co {0} BDS",BDSList.Count);
                        foreach (var BDS in BDSList)
                        {
                            if (BDS.GetType() == typeof(BDS)){
                                System.Console.WriteLine(((BDS)BDS).toString());
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("Tim theo ten");
                        string TenBDS = Console.ReadLine();
                        Boolean kt3 = false;
                        for (int i = 0; i < BDSList.Count; i++){
                            if (BDSList[i].GetType() == typeof(BDS) && ((BDS)BDSList[i]).getTenBDS().Equals(TenBDS)){
                                System.Console.WriteLine(((BDS)BDSList[i]).toString());
                                kt3 = true;
                            }
                        }
                        if (!kt3) System.Console.WriteLine("Khong tim thay Ten!!!");
                        break;
                    case 6:
                        Console.WriteLine("Tim theo huong");
                        string HuongBDS = Console.ReadLine();
                        Boolean kt4 = false;
                        for (int i = 0; i < BDSList.Count; i++){
                            if (BDSList[i].GetType() == typeof(BDS) && ((BDS)BDSList[i]).getHuong().Equals(HuongBDS)){
                                System.Console.WriteLine(((BDS)BDSList[i]).toString());
                                kt4 = true;
                            }
                        }
                        if (!kt4) System.Console.WriteLine("Khong tim thay Ten!!!");
                        break;
                    case 7:
                        Console.WriteLine("Tim theo gia");
                        float Gia = Convert.ToInt32(Console.ReadLine());
                        Boolean kt5 = false;
                        for (int i = 0; i < BDSList.Count; i++){
                            if (BDSList[i].GetType() == typeof(BDS) && ((BDS)BDSList[i]).getGiaBan() == Gia){
                                System.Console.WriteLine(((BDS)BDSList[i]).toString());
                                kt5 = true;
                            }
                        }
                        if (!kt5) System.Console.WriteLine("Khong tim thay Ten!!!");
                        break;

                    default:
                        Console.WriteLine("Vui long nhap dung");
                    break;
                }
            }

            Console.WriteLine("Hello World!");
        }
    }
}
