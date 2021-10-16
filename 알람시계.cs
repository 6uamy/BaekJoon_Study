using System;

namespace BaekJoon1016
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] a = Console.ReadLine().Split(' ');
            int H = int.Parse(a[0]);
            int M = int.Parse(a[1]);

            if (H == 0)
            {
                if (M < 45)
                {
                    H = 23;
                    M = M + 60 - 45;
                    Console.WriteLine("{0} {1}", H, M);
                }
                else
                {
                    M -= 45;
                    Console.WriteLine("{0} {1}", H, M);
                }
            }
            else
            {
                if (M < 45)
                {
                    H--;
                    M = M + 60 - 45;
                    Console.WriteLine("{0} {1}", H, M);
                }
                else
                {
                    M -= 45;
                    Console.WriteLine("{0} {1}", H, M);
                }
            }
        }
    }
}
