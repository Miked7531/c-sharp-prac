using System;

namespace nested_prac
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 9; i >= 0; i--)
            {
                for (int k = i; k >= 0; k--)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
