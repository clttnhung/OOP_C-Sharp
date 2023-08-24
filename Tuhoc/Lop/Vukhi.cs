using System;

namespace Lop
{
    internal class Vukhi
    {
        // Du lieu
        public string name = "Ten vu khi";
        int dosatthuong = 0;

        // Thuoc tinh
        public string Noisanxuat{set;get;}

        public int Satthuong{
            // = khi thuc hien phep gan, ghi vao
            set
            { 
                dosatthuong = value;
            }
            // khi truy cap, doc thuoc tinh
            get
            {
                return dosatthuong;
            }
        }
        
        // Phuong thuc khoi tao
        public Vukhi()
        {
            dosatthuong = 1;
        }
        public Vukhi(string name, int _dosatthuong)
        {
            dosatthuong = _dosatthuong;
            this.name = name;

        }
        public Vukhi(string abc)
        {
            Console.WriteLine(abc);
        }
        // Phuong thuc
        public void Thietlapsatthuong(int dosatthuong)
        {
            
            this.dosatthuong = dosatthuong;
            // this - ref: tham chieu
        }
        public void Tancong()
        {
            Console.Write(name + ":\t");
            for ( int i = 0; i < dosatthuong; i++ )
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}