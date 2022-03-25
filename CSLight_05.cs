using System;

namespace CSLight_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Иванов";
            string surname = "Иван";
            string buffer;

            Console.WriteLine("Значения переменных до перестановки:");
            Console.WriteLine("name: " + name);
            Console.WriteLine("surname: " + surname);
            Console.WriteLine();

            buffer = name;
            name = surname;
            surname = buffer;

            Console.WriteLine("Значения переменных после перестановки:");
            Console.WriteLine("name: " + name);
            Console.WriteLine("surname: " + surname);
        }
    }
}
