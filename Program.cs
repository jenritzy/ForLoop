using System;

namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ForLoop";
            for (int i = 1; i < 4; i++) 
            {
                Console.WriteLine("Loop Iteration: " + i);
                for(int j = 1; j < 4; j++)
                {
                    Console.WriteLine("\t inner loop iteration: " + j);
                }
            }
            Console.ReadKey();


            
        }
    }
}