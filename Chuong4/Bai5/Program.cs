
using System;

namespace Bai5
{
    public class Doanhnghiep
    {
        public string TenDN;
        public int MST;
        public string Diachi;
        public Doanhnghiep()
        {
            Console.Write("Nhap ten doanh nghiep: ");
            TenDN = Console.ReadLine();
            Console.Write("Nhap ma so thue doanh nghiep: ");
            MST = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap dia chi doanh nghiep: ");
            Diachi = Console.ReadLine();
        }
    }
    internal class DanhsachDN
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so doanh nghiep: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Doanhnghiep[] doanhnghiep = new Doanhnghiep[n];
            for (int i = 0; i<n; i++)
            {
                Console.WriteLine($" Nhap thong tin doanh nghiep thu {i+1}");
                doanhnghiep[i]= new Doanhnghiep();
            }
            for (int i = 0; i <n; i++)
            {
                Console.WriteLine($"Thong tin doanh nghiep thu {i+1} la:");
                Console.WriteLine($"- Ten doanh nghiep la: {doanhnghiep[i].TenDN}");
                Console.WriteLine($"- Ma so thue doanh nghiep la: {doanhnghiep[i].MST}");
                Console.WriteLine($"- Dia chi doanh nghiep la: {doanhnghiep[i].Diachi}");
            }
            Console.Write("Tim ma so thue theo ten doanh nghiep: ");
            string tendoanhnghiep = Console.ReadLine();
            int k;
            for (int i = 0; i<n; i++)
            {
                if (tendoanhnghiep == doanhnghiep[i].TenDN)
                {
                    k=i;
                    Console.WriteLine($"Ma so thue can tim la: {doanhnghiep[k].MST}");
                }                
            }
            Console.Write("Tim ten doanh nghiep va dia chi doanh nghiep theo ma so thue: ");
            int masothue = Convert.ToInt32(Console.ReadLine());
            int m;
            for (int i = 0; i<n; i++)
            {
                if (masothue == doanhnghiep[i].MST)
                {
                    m=i;
                    Console.WriteLine("Ten doanh nghiep va dia chi doanh nghiep can tim la:");
                    Console.WriteLine($"- Ten doanh nghiep la: {doanhnghiep[m].TenDN}");
                    Console.WriteLine($"- Dia chi doanh nghiep la: {doanhnghiep[m].Diachi}");
                }                
            }
        }
    }

}
