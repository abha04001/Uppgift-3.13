using System;
namespace Uppgift_3._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ditt ålder om du vill delta i tävlingen OBS måste vara mellan 16 - 19");
            int ålder = int.Parse(Console.ReadLine());
            if (ålder >= 16 && ålder <= 19)
            {
                Console.WriteLine("Du får delta i tävlingen");
            }
            else
            {
                Console.WriteLine("Du får INTE delta i tävlingen");
            }

        }
    }
}