using System;

namespace nested_prac
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 9;
            while (i >= 0)
            {
                int k = i;
                while (k >= 0)
                {
                    Console.Write(k + " ");
                    k--;
                }
                Console.WriteLine();
                i--;
            }
            /*
            for(int i = 9; i >= 0; i--)
            {
                for (int k = i; k >= 0; k--)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
                
            }
            */
        }
    }
}
