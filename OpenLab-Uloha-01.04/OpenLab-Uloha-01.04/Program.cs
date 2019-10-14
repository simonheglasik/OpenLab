using System;

namespace OPEN_LAB_Uloha_01._4
{
    class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {

                string basse = Console.ReadLine();
                string height = Console.ReadLine();
                int B = int.Parse(basse);
                int H = int.Parse(height);
                int result = Sum(B, H);
                Console.WriteLine(result);
            }

        }
        public static int Sum(int z, int v)
        {
            int sum = (z * v) / 2;
            return sum;
        }


    }
}