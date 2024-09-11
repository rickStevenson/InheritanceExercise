using System;
using System.Xml;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var bird = new Bird()
            {
                Classification = "owl",
                CanFly = "Yes",
                Color = "brown",
                WingSpan = 5
            };
            Console.WriteLine($"This {bird.AnimalType} is an {bird.Classification}. " +
                $"It has {bird.Legs} legs, {bird.Color} {bird.SkinType} and can fly. " +
                $"It has a { bird.WingSpan}ft wingspan " +
                $"It's habitat is land and {bird.Habitat}.");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var lizard = new Reptile()
            {
                Classification = "lizard",
                BackBone = true,
                EggLayer = true,
                AgeLength = 5
            };
            Console.WriteLine($"This {lizard.AnimalType} is a {lizard.Classification}. " +
                $"It has {lizard.Legs} legs, {lizard.SkinType}, has a backbone and lays eggs. " +
                $"It lives to be about {lizard.AgeLength} years old. " +
                $"It's primary habitat is on {lizard.Habitat}. ");
        }
    }
}
