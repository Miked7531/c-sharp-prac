using System;

namespace sweetpracprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 9; i >= 0; i-=2)
            {
                Console.WriteLine(i);
            }
            /*
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 0);
            */
            /*
            int i = 0; // initialization
            while (i < 10) // condition
            {
                Console.WriteLine(i);
                i++; //update
            }
            */
        }
    }
}
