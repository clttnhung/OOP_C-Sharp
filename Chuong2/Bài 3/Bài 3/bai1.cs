using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");

            int n = Convert.ToInt32(Console.ReadLine());
            float[] A = new float[n];
            float tong, tich, max, min;
            int indexMax, indexMin;
            tong = 0;
            max = 0;
            min = 0;
            indexMin = 0;
            indexMax = 0;
            tich = 1;
           
            for (int i = 0; i < n; i++)
            {
                A[i] = float.Parse(Console.ReadLine());
                if (A[i] < 0)
                {
                    tong += Math.Abs(A[i]);
                }
                if (A[i] < min)
                {
                    min = A[i];
                }
                if (A[i] > max)
                    max = A[i];
            }
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == max)
                    indexMax = i;
                if (A[i] == min)
                    indexMin = i;
            }
            if (indexMax > indexMin)
               {
                 for (int i = indexMin+1; i < indexMax; i++)
                  {
                        tich *= A[i];
                  }
                }
            else if (indexMax < indexMin)
                {
                  for (int i = indexMax+1; i < indexMin; i++)
                   {
                        tich *= A[i];
                   }
                }
            
            Console.WriteLine("Tong = " + tong);
            Console.WriteLine("Tich = " + tich);
            Array.Sort(A);
            Console.Write("A_tang = [");
            for (int i = 0; i < A.Length; i++)  
            {
                if (i==n-1)
                {
                    Console.WriteLine(A[i]+"]");
                }
                else
                {
                    Console.Write(A[i] + ", ");
                }
            }
            Console.Write("A_biendoi = [");
            foreach (float i in A)
            { 
                int a = (int)i;
                if (a % 2 == 0) Console.Write(a + ", "); 
            }
            foreach (float i in A)
            { 
                int a = (int)i;
                if (a % 2 != 0 & i !=n-1)
                {
                    Console.Write(a + ", ");
                }
                else
                {
                    Console.Write(a + "");
                }    
            }
            Console.WriteLine("]");
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}