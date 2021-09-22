using System;

namespace HW1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Checking_For_Prime_Number(7);
        }

        static void Checking_For_Prime_Number (int number)
        {
            int d = 0;
            int i = 2;
            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                    i++;
                }
                else
                {
                    i++;
                }
            }
            if(d ==0)
            {
                Console.WriteLine($"Число {number} простое");
            }
            else
            {
                Console.WriteLine($"Число {number} не простое");
            }
        }
    }
}
