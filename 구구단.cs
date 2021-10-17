using System;

namespace BaekJoon1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M,R;
            for(M = 1; M <= 9; M++)
            {
                R = N * M;
                Console.WriteLine("{0} * {1} = {2}", N, M, R);
            }
        }
    }
}
