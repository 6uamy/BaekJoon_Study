using System;
using System.Text;

namespace BaekJoon1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder allNumbers = new StringBuilder();

            for (int i = N; i > 0; i--)
            {
                allNumbers.Append(i + "\n");
            }
            Console.Write(allNumbers.ToString());
        }
    }
}
