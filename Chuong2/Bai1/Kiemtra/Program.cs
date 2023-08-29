using System;
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Hoten, Lop, Danhhieu;

            Double QTH, HTTTQL, CSLT, Triet;
            Console.Write(" Ho va ten: ");
            Hoten = Console.ReadLine().ToUpper();
            Console.Write("Lop: ");
            Lop = Console.ReadLine().ToUpper();
            Console.Write("Diem_QTH: ");
            QTH = Convert.ToDouble(Console.ReadLine());
            Console.Write("Diem_HTTTQL: ");
            HTTTQL = Convert.ToDouble(Console.ReadLine());
            Console.Write("Diem_CSLT: ");
            CSLT = Convert.ToDouble(Console.ReadLine());
            Console.Write("Diem_Triet: ");
            Triet = Convert.ToDouble(Console.ReadLine());
            double[] Diem = { QTH, HTTTQL, CSLT, Triet };
            double Tongdiem = 0;
            for (int i = 0; i < Diem.Length; i++)
            {
                
                if (Diem[i] < 4.0)
                {
                    Tongdiem += 0;
                }
                else if ( Diem[i] < 5.5)
                {
                    Tongdiem += 1;
                }
                else if ( Diem[i] < 7.0)
                {
                    Tongdiem += 2;
                }
                else if (Diem[i] < 8.5)
                {
                    Tongdiem += 3;
                }
                else
                {
                    Tongdiem += 4;
                }
            }
            double GPA = Tongdiem/4; 
            if (GPA >= 3.6)
            {
                Danhhieu = "Xuat sac";
            }
            else if (GPA > 3.2 & GPA <3.6)
            {
                Danhhieu = "Gioi";
            }
            else if (GPA >= 2.5 & GPA <3.2)
            {
                Danhhieu = "Trung binh";
            }
            else 
            {
                Danhhieu = "Yeu";
            }
            Console.WriteLine("Sinh vien " + Hoten + ", Lop " + Lop + ", Dat GPA " + GPA + ", Xep loai " + Danhhieu );
            Console.ReadLine();
        }
    }
}
