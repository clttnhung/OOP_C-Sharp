
using System;

namespace MyApp 
{
    internal class CS004
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Nhap so nguyen a:");
            a= int.Parse(Console.ReadLine());
            if   ( a % 2==0)
            {
                Console.WriteLine("So a la so chan");
            }
            else
            {
                Console.WriteLine("So a la so le");
            }
        }
    }
}
