using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Bai2
{
    static String Nhap()
    {
        string a = Console.ReadLine();
        return a;
    }
    static String ThucHien(double a, double b, char toantu)
    {
        switch (toantu)
        {
            case '+':
                return Convert.ToString(a + b);
            case '-':
                return Convert.ToString(a - b);
            case '*':
                return Convert.ToString(a * b);
            case '/':
                return Convert.ToString(a / b);
            default:
                return "Khong co phep tinh nay!!!";
        }
    }
    static void InKQ(string a)
    {
        Console.WriteLine("{0} {1} {2}, ");
    }
    public static void Main(string[] args)
    {
        double a, b;
        char toantu, t;
        do
        {
            Console.Write("a=");
            a = double.Parse(Bai2.Nhap());
            Console.Write("b=");
            b = double.Parse(Bai2.Nhap());
            Console.Write("Toan tu: ");
            toantu = char.Parse(Bai2.Nhap());
            Console.Write("Tiep tuc: ");
            t = char.Parse(Bai2.Nhap());
            Console.Write(a, b);
            Bai2.InKQ(Bai2.ThucHien(a, b, toantu));
        } while (t.Equals('t') & t.Equals('T'));
        Console.ReadKey();
    }
}
