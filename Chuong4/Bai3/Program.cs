using System;

namespace Bai3
{
    class Tamgiac
        {
            public int a;
            public int b;
            public int c;
            public void Nhap()
            {
                Console.WriteLine("Nhap canh a: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap canh b");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap canh c");
                c = int.Parse(Console.ReadLine());
            }
            public void Kiemtra()
            {
                if ( a==b && b==c)
                {
                    Console.WriteLine("Tam giac deu");
                }
                
                else if ( a*a + b*b == c*c || a*a + c*c == b*b|| b*b + c*c == a*a)
                {
                    if ( a==b || a==c || b==c)
                    {
                       Console.WriteLine("Tam giac vuong can");
                    }
                    else
                    {
                        Console.WriteLine("Tam giac vuong ");
                    }
                }

                else if ( a==b || a==c || b==c)
                    {
                       Console.WriteLine("Tam giac can");
                    }
                else
                {
                    Console.WriteLine("Tam giac thuong");
                }
            }
             public bool Kiemtratamgiac()
            {
                if (a + b == c)
                {
                    return false;
                }
                if (a + c == b)
                {
                    return false;
                }
                if ((c + b) == a)
                {
                    return false;
                }
                return true;
            }
        }
       
    internal class Program
    {
        static void Main(string[] args)
        {
            Tamgiac n = new Tamgiac();
                    n.Nhap();
                    if (n.Kiemtratamgiac())
                    {
                        n.Kiemtra();
                    }
                    else
                    {
                        Console.WriteLine("Khong hop le");
                    }
        }
    }
}
