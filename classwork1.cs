using System;

namespace cw1
{
    class Program
    {
        static void Main(string[] args)
      
        {
            string Charachtername = "Fatima";
            int age = 24;
            float speed = 99.9f;
            string superpower1 = "invisibility";
            string superpower2 = "controlling thunder";
            Console.WriteLine("my name is {0} and my superpowers are {1} and {2}, i am {3} years old and my speed is {4}", Charachtername, superpower1, superpower2, age, speed);
            // anotherhero
            string HeroName = "Jupiter";
            double Heroheight = 1.85;
            int heroAge = 25;
            string herosuperpower1 = "mind control";
            string herosuperpower2 = "remote lifting";
            int ageDifference = heroAge - age;
            Console.WriteLine("{0} is {1} years old and his height is {2}, his superpowers are {3} and {4}", HeroName, heroAge, Heroheight, herosuperpower1, herosuperpower2);
            Console.WriteLine("the age difference between {0} and {1} is {2}", HeroName, Charachtername, ageDifference);

        }
    }
}
