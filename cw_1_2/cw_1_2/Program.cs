using System;

namespace cw_1_2
{
    class Program
    {
        static double playerspeed;

        static void Main(string[] args)
        {
            setspeed(2.5);
            Console.WriteLine("Current player speed is: " + Getspeed());

        }

        static void setspeed(double newspeed)
        {
            playerspeed = newspeed;
        }

        static double Getspeed()
        {
            return playerspeed;
        }
    }
}
