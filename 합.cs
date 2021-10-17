using System;

namespace BaekJoon1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i;
            int m = 0;
            for (i = 1; i <= n; i++)
            {
                m += i;
            }
            Console.WriteLine("{0}", m);
        }
    }
}
