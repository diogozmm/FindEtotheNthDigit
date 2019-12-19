using System;

namespace FindEtotheNthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor entre 1 e 15");

            try
            {
                int value = int.Parse(Console.ReadLine());
                Console.WriteLine("A Constante E é igual a:");
                Console.WriteLine(Math.Round(Math.E, value));
            }

            catch(Exception)
            {
                Console.WriteLine("Digite um valor entre 1 e 15!!!");
            }

        }
    }
}
