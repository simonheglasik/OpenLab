using System;

namespace OPEN_LAB_Uloha_01._2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                int A = int.Parse(a);
                int B = int.Parse(b);
                int result = Sum(A, B);

                Console.WriteLine(result);
            }
        }

        public static int Sum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
    }
}