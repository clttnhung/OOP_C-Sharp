
// public class PHONG
// {
//     public string tenkh;
//     public string cmnd;
//     public int ngaythue;
//     public int tienthue;
//     public virtual void Nhap()
//     {
//         Console.Write("Nhap ten khach hang: ");
//         tenkh = Console.ReadLine();
//         Console.Write("Nhap so cmnd: ");
//         cmnd = Console.ReadLine();
//         Console.Write("Nhap ngay thue: ");
//         ngaythue = int.Parse(Console.ReadLine());
//     }
//     public virtual int Tinh()
//     {
//         return 0;
//     }
//     public virtual void Xuat()
//     {
//         Console.WriteLine($"Ten khach hang la {tenkh}");
//         Console.WriteLine($"So cmnd khach hang la {cmnd}");
//         Console.WriteLine($"Ngay khach hang thue la {ngaythue}");
//         Console.WriteLine($"Tong tien khach hang phai tra la {tienthue}");
//     }
// }
// public class STANDARD:PHONG
// {
//     public override void Nhap()
//     {
//         base.Nhap();
//     }
//     public override int Tinh()
//     {
//         if(ngaythue<5)
//         {
//             tienthue=500*ngaythue;
//         }
//         else if(ngaythue>=5)
//         {
//             tienthue=400*ngaythue;
//         }
//         return tienthue;
//     }
//     public override void Xuat()
//     {
//         base.Xuat();
//     }
// }
// public class Vip:PHONG
// {
//     public string loaiphong;
//     public override void Nhap()
//     {
//         base.Nhap();
//         Console.Write("Nhap ten loai phong: ");
//         loaiphong=Console.ReadLine();
//     }
//     public override int Tinh()
//     {
//         if (ngaythue<5)
//         {
//             if (loaiphong=="Luxury")
//             {
//                 tienthue=1100*ngaythue;
//             }
//             else
//             {
//                 tienthue=1300*ngaythue;
//             }
//         }
//         else
//         {
//             tienthue=1000*ngaythue;
//         }
               
//         return tienthue;
//     }
//     public override void Xuat()
//     {
//         base.Xuat();
//     }
// }
// class Bai4c6
// {
//     static void Main(string[] args)
//     {
//        PHONG st = new STANDARD();
//        PHONG vip = new Vip();
//        st.Nhap();
//        st.Tinh();
//        st.Xuat();
//        vip.Nhap();
//        vip.Tinh();
//        vip.Xuat();
//     }
// }

