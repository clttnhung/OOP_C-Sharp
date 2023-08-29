using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Bài_2
{
    internal class Program
    {
        static void main(string[] args)
        {
            double a, b;
            string toantu, t;
            do
            {
                Console.Write("a=");
                a = float.Parse(Console.ReadLine());
                Console.Write("b=");
                b = float.Parse(Console.ReadLine());
                Console.Write("Toan tu: ");
                toantu = Console.ReadLine();
                Console.Write("Tiep tuc: ");
                t = Console.ReadLine();
                switch (toantu)
                {
                    case "+":
                        Console.WriteLine("{0} {1} {2} = {3}", a, toantu, b, a + b);
                        break;
                    case "-":
                        Console.WriteLine("{0} {1} {2} = {3}", a, toantu, b, a - b);
                        break;
                    case "*":
                        Console.WriteLine("{0} {1} {2} = {3}", a, toantu, b, a * b);
                        break;
                    case "/":
                        Console.WriteLine("{0} {1} {2} = {3}", a, toantu, b, a / b);
                        break;
                    default:
                        Console.WriteLine("Khong co phep tinh nay");
                        break;
                }
            } while ( t != "t" & t != "T");
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}*/

class Program
{
    static void Nhap(ref float a, ref float b, ref char toantu)
    {
        Console.Write("a=");
        a = float.Parse(Console.ReadLine());
        Console.Write("b=");
        b = float.Parse(Console.ReadLine());
        Console.Write("Toan tu:");
        toantu = char.Parse(Console.ReadLine());
        
    }
    static float Thuchien(float a, float b, char toantu, float kq)
    {
        if (toantu == '+')
        {
            kq = a + b;
        }
        else if (toantu == '-')
        {
            kq = a - b;
        }
        else if (toantu == '*')
        {
            kq = a * b;
        }
        else if (toantu == '/')
        {
            kq = a / b;
        }
        return kq;
    }
    static void InKQ(float a, float b, char toantu, float kq)
    {
        Console.WriteLine("{0} {1} {2} = {3}", a, toantu, b, kq);
    }
    static void Main(string[] args)
    {
        float a = 0, b = 0, kq = 0;
        char toantu = '+';
        char tieptuc = 'l';
        while (true)
        {
            Nhap(ref a, ref b,ref toantu);
            kq = Thuchien(a, b, toantu, kq);
            InKQ(a, b, toantu, kq);
            Console.Write("Tiep tuc:");
            tieptuc = char.Parse(Console.ReadLine());
            if (tieptuc == 't' || tieptuc == 'T')
                break;
        }

    }
}

/* Cach Bach
 * public class Bai2
{
    static String Nhap()
    {
        string a = Console.ReadLine();
        return a;
    }
    static String ThucHien(double a, double b, char o)
    {
        switch (o)
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
        Console.WriteLine(a);
    }
    public static void Main(string[] args)
    {
        double a, b;
        char o, t;
        do
        {
            Console.Write("a=");
            a = double.Parse(Bai2.Nhap());
            Console.Write("b=");
            b = double.Parse(Bai2.Nhap());
            Console.Write("Toan tu: ");
            o = char.Parse(Bai2.Nhap());
            Bai2.InKQ(Bai2.ThucHien(a, b, o));
            Console.Write("Tiep tuc: ");
            t = char.Parse(Bai2.Nhap());
        } while (t.Equals('t') || t.Equals('T'));
    }*/

