using System;

namespace Compara_Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 números quaisquer");
            int num1 = 0, num2 = 0, num3 = 0, maior=0;
            num1 = Convert.ToInt32(Console.ReadLine());
            num2= Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    maior = num1;
                }
            }
            else if (num2 > num3)
            {
                maior = num2;
            }
            else if (num1 > num3)
            {
                maior = num1;
            }
            else maior = num3;
            Console.WriteLine("O maior número entre eles é "+ maior);
        }
    }
}
