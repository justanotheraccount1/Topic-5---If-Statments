﻿namespace Topic_5___If_Statments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sam Ahrens 09/18/24
            int people = 20;
            int cats = 30;
            int dogs = 15;

            Console.WriteLine("People:" + people + " Cats:" + cats + " Dogs:" + dogs);
            if (people < cats)
                Console.WriteLine("Too amny cats! The world is DOOMED!");

            if (people > cats)
                Console.WriteLine("Not a lot of cats, the world is saved.");

            if (people < dogs)
                Console.WriteLine("The world is drooled on.");

            if (people > dogs)
                Console.WriteLine("The world is dry.");

            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
            Console.Clear();
            dogs += 5;
            Console.WriteLine("People:" + people + " Cats:" + cats + " Dogs:" + dogs);
            if (people >= dogs)
                Console.WriteLine("People are greater than or equal to dogs.");

            if (people <= dogs)
                Console.WriteLine("People are less than or equal to dogs.");

            if (people == dogs)
                Console.WriteLine("People are dogs.");

        }
    }
}
