using System;

namespace CSLight_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int userPicsCount = 52;
            int picsInTheRow = 3;
            int fullRows, remainingPics;
            fullRows = userPicsCount / picsInTheRow;
            remainingPics = userPicsCount % picsInTheRow;
            Console.WriteLine("Выведется " + fullRows + " полностью заполненных рядов картинок, а так же " + remainingPics + " картинка сверх меры.");
        }
    }
}