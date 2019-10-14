using System;

namespace OPEN_LAB_Uloha_01._3
{
    class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {
                string a = Console.ReadLine();

                int A = int.Parse(a);

                int result = Sum(A);

                Console.WriteLine(result);
            }
        }
        public static int Sum(int a)
        {
            return a + 1;
        }
    }

}
