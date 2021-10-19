using System;
using System.Text;

namespace BaekJoon1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder allNumbers = new StringBuilder();

            for (int i = 1; i <= N; i++)
            {
                int number = N - (N - i);
                allNumbers.Append(number + "\n");
            }
            Console.Write(allNumbers.ToString());
        }
    }
}
