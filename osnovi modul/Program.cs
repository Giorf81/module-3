using System;

class MainClass
{
    public static void Main(string[] args)
    {

        string MyName = "Danil";
        byte age = 16;
        bool pet = false;
        float legsize = 999;

        Console.WriteLine($"My name is {MyName}");
        Console.WriteLine($"MyAge {age}");
        Console.WriteLine($"Do I have a pet? {pet}");
        Console.WriteLine($"My shoe size is {legsize}");

    }
    enum Semaphore
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }
}