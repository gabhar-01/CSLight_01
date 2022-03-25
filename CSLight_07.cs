using System;

namespace CSLight_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople;
            int visitingTime = 10;
            int hour = 60;
            int waitingTime;
            int waitingMinute;
            int waitingHour;

            Console.WriteLine("Вы заходите в поликлинику и видите огромную очередь из старушек!");
            Console.Write("Введите количество людей в очереди: ");
            countOfPeople = Convert.ToInt32(Console.ReadLine());

            waitingTime = countOfPeople * visitingTime;
            waitingHour = waitingTime / hour;
            waitingMinute = waitingTime % hour;

            Console.WriteLine();
            Console.WriteLine("Вы должны отстоять в очереди " + waitingHour + " часа " + waitingMinute + " минут.");
        }
    }
}
