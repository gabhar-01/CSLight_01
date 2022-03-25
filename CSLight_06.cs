using System;

namespace CSLight_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int money;
            int crystalCount;
            int crystalPrice = 50;

            Console.Write("Введите количество золота, имеющееся в вашем кошельке: ");
            money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Добро пожаловать в Лавку Алхимика! Сегодня кристаллы стоят " + crystalPrice + " золота.");
            Console.Write("Сколько кристаллов Вы хотите купить: ");
            crystalCount = Convert.ToInt32(Console.ReadLine());

            money -= crystalCount * crystalPrice;

            Console.WriteLine("Вы купили " + crystalCount + " кристаллов. У вас осталось " + money + " золота.");
        }
    }
}
