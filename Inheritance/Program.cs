using System;
using System.Xml;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var bird = new Bird()
            {
                Classification = "owl",
                CanFly = "Yes",
                Color = "brown",
                WingSpan = 5
            };
            Console.WriteLine($"This {bird.AnimalType} is an {bird.Classification}. " +
                $"It has {bird.Legs} legs, {bird.Color} {bird.SkinType} and can fly. " +
                $"It has a {bird.WingSpan}ft wingspan " +
                $"It's habitat is land and {bird.Habitat}.");



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


            //Adam and Eve Kata
            //Use if the Create() isn't static
            //var god = new God();
            //god.Create();

            //Use if Create() is static
            var firstHumans =  God.Create();
            
        }
    }
    public class God
    {
        public static Human[] Create()
        {
            var adam = new Man();
            var eve = new Woman();

            Human[] firstHumans = new Human[2];

            firstHumans[0] = adam;
            firstHumans[1] = eve;

            return firstHumans;
        }
    }
    public class Human
    {

    }
    public class Man : Human
    {

    }
    public class Woman : Human 
    { 
    
    }
}
