//Problem 2. Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;
using System.Threading;

class MoonGravitation
{
    static void Main()
    {
        Console.WriteLine("Please enter your weight: ");
        Console.Write("Come on! Don't be shy: ");
        double weight = double.Parse(Console.ReadLine());

        double weightOnMoon = weight * 0.17;
        Console.WriteLine("Your weight on the Moon will be....");
        Thread.Sleep(1000);
        Console.WriteLine("Calculating...");
        Thread.Sleep(1000);
        System.Media.SystemSounds.Asterisk.Play();        
        Console.WriteLine("Tadaaa  -->  {0}kg.", weightOnMoon);

    }
}
