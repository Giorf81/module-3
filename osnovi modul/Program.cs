using System;

class MainClass
{
    public static void Main(string[] args)
    {

        Console.Write("Введите имя: ");
        var name = Console.ReadLine();
        Console.Write("age? ");
        var age = Convert.ToInt32(Console.ReadLine());
        Console.Write("birthday? ");
        var birthdate = Console.ReadLine();

        Console.WriteLine("твое имя: {0}, твой возраст: {1}, твой др: {2}", name, age, birthdate);
    }
    enum Semaphore
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }
}