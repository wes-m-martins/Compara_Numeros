using System;

namespace Compara_Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 2 números quaisquer");
            int num1 = 0, num2 = 0, maior;
            num1= Convert.ToInt32(Console.ReadLine());
            num2= Convert.ToInt32(Console.ReadLine());
            
            if (num1 > num2)
            {
                maior = num1;
            }
            else 
            {
                maior = num2;
            }
            

            Console.WriteLine("O maior número entre eles é"+ maior);
        }
    }
}
