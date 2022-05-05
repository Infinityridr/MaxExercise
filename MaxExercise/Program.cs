using System;

namespace MaxExercise
{
    internal class Program
    {
        private static void Main()
        {
            try
            {
                Console.Write("Type your 2 numbers:\n\n1)");
                var n1 = Convert.ToInt64(Console.ReadLine());
                Console.Write("\n2)");
                var n2 = Convert.ToInt64(Console.ReadLine());
                Max(n1, n2);
            }
            catch (Exception)
            {
                Console.WriteLine("\nThat not even a number...");
            }
        }

        public static void Max(long n1,long n2) 
        {
            string MaxN = Convert.ToString((n1 > n2) ? n1 : n2);
            Console.WriteLine("\n{0} is bigger",MaxN);
            Main();
        }
    }
}
