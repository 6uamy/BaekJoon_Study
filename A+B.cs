using System;

namespace BaekJoon1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int i;
            for (i = 0; i < T; i++)
            {
                string[] a = Console.ReadLine().Split(' ');
                int A = int.Parse(a[0]);
                int B = int.Parse(a[1]);

                Console.WriteLine("{0}", A + B);
            }

        }
    }
}
