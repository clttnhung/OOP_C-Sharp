using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chương_3
{
    internal class Bai
    {
        class Meo
        {
            public string Ten;
            public string Giong;
            public string Gioitinh;
            public float Tuoi;
            public static int dem = 0;
            public Meo()
            {
                Ten = "a";
                Giong = "b";
                Gioitinh = "c";
                Tuoi = 2;
                dem++;
            }
            public void Nhap()
            {
                Console.Write("Nhap ten meo: ");
                Ten = Console.ReadLine();
                Console.Write("Nhap loai giong: ");
                Giong = Console.ReadLine();
                Console.Write("Nhap gioi tinh: ");
                Gioitinh = Console.ReadLine();
                Console.Write("Nhap so tuoi: ");
                Tuoi = float.Parse(Console.ReadLine());

            }

            public void Xuat()
            {
                Console.WriteLine("Ten meo: {0}, Loaigiong:{1}, Gioitinh:{2}, So tuoi:{3}", Ten, Giong, Gioitinh, Tuoi);

            }
            ~Meo()
            {
                Console.WriteLine("Huy");
            }
            class Program
            {
                static void Main(string[] args)
                {
                    Meo n1 = new Meo();
                    n1.Nhap();
                    n1.Xuat();
                    Meo n2 = new Meo();
                    n2.Nhap();
                    n2.Xuat();
                    Meo n3 = new Meo();
                    n3.Nhap();
                    n3.Xuat();
                    Console.WriteLine("So con meo da nhap:{0}", dem);
                    Console.ReadLine();
                }
            }
        }
    }

}
