using System;

namespace CSLight_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string zodiacSign;
            string job;

            Console.Write("Как вас зовут: ");
            name = Console.ReadLine();
            Console.Write("Сколько вам лет: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Какой ваш знак зодиака: ");
            zodiacSign = Console.ReadLine();
            Console.Write("Где вы работаете: ");
            job = Console.ReadLine();

            Console.WriteLine($"Вас зовут {name}, вам {age} год, вы {zodiacSign} и работаете {job}.");
        }
    }
}
