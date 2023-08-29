using System;
namespace VietJackCsharp
{
    class program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[4, 4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                
                }
            Console.WriteLine(A[2,0]);
            Console.WriteLine(A[2,1]);
            Console.WriteLine(A[0,2]);

            Console.ReadKey();
            Console.ReadKey();

        }
    }
}