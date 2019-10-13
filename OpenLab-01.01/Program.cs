using System;

namespace OPEN_LAB_Uloha_01._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string zadane = Console.ReadLine();
            int zadanečislo = int.Parse(zadane);

            if (zadanečislo < 10)
            {
                Console.WriteLine("This number is less then 10");
            }
            else
            {
                Console.WriteLine("This number is greater or equal to 10");
            }
        }
    }
}