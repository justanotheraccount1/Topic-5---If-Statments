namespace Topic_5___If_Statments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sam Ahrens 09/18/24
            string dinosaur, magicWord, answer;
            int age, confirm, grade;
            double temp, bet;
            int people = 20;
            int cats = 20;
            int dogs = 15;

            //Part 1
            //Console.WriteLine("People:" + people + " Cats:" + cats + " Dogs:" + dogs);
            //if (people < cats)
            //    Console.WriteLine("Too amny cats! The world is DOOMED!");

            //if (people > cats)
            //    Console.WriteLine("Not a lot of cats, the world is saved.");

            //if (people < dogs)
            //    Console.WriteLine("The world is drooled on.");

            //if (people > dogs)
            //    Console.WriteLine("The world is dry.");

            //Console.WriteLine("Press ENTER to continue...");
            //Console.ReadLine();
            //Console.Clear();
            //dogs += 5;
            //Console.WriteLine("People:" + people + " Cats:" + cats + " Dogs:" + dogs);
            //if (people >= dogs)
            //    Console.WriteLine("People are greater than or equal to dogs.");

            //if (people <= dogs)
            //    Console.WriteLine("People are less than or equal to dogs.");

            //if (people == dogs)
            //    Console.WriteLine("People are dogs.");

            //Console.WriteLine("What famous dinosaur has 3 horns?");
            //dinosaur = Console.ReadLine();
            //if (dinosaur.ToLower() == "triceratops")
            //    Console.WriteLine("Correct!");


            //Console.WriteLine("What's the magic word?");
            //magicWord = Console.ReadLine().ToLower();
            //if (magicWord == "please")
            //    Console.WriteLine("Correct!");
            //else
            //    Console.WriteLine("Nope that's not the magic word");
            //if (magicWord == "what")
            //    Console.WriteLine("But sort of correct?");


            //Console.WriteLine("How old are you?");
            //int.TryParse(Console.ReadLine(), out age);
            //if (age <= 0)
            //    Console.WriteLine("How are you even typing?");
            //if (age <= 15)
            //    Console.WriteLine("You can't drive");
            //if (age <= 17)
            //    Console.WriteLine("You can't vote");
            //if (age <= 24)
            //    Console.WriteLine("You can't rent a car");
            //if (age >= 25)
            //    Console.WriteLine("You can do anything legal");

            //Console.WriteLine("Please enter a freezing temperature of water:");
            //double.TryParse(Console.ReadLine(), out temp);
            //if (temp == 0)
            //    Console.WriteLine("Yes. 0 degrees Celcius is the exact freezing temperature of water");
            //if (temp == 32)
            //    Console.WriteLine("Yes. 32 degrees Ferenhiet is the exact freezing temperature of water");
            //if (temp == 273.2)
            //    Console.WriteLine("Yes. 273.2 degrees Kelvin is the exact freezing temperature of water");


            //Part 2
            //Console.WriteLine("What was your grade?");
            //int.TryParse(Console.ReadLine(), out grade);
            //if (grade < 50)
            //    Console.WriteLine("You failed");
            //else if (grade < 65)
            //    Console.WriteLine("You got a D");
            //else if (grade < 75)
            //    Console.WriteLine("You got a C");
            //else if (grade < 85)
            //    Console.WriteLine("You got a B");
            //else
            //    Console.WriteLine("You got an A");


            //Console.WriteLine("How old are you?");
            //int.TryParse(Console.ReadLine(), out age);
            //if (age >= 16)
            //    Console.WriteLine("The roads are not safe");
            //else
            //    Console.WriteLine("I can drive without fear!");

            //Console.WriteLine("How much will you bet?");
            //if (double.TryParse(Console.ReadLine(), out bet))
            //{

            //    Console.WriteLine("You bet " + bet.ToString("C"));
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //    Console.WriteLine("You will bet the minimum input");
            //    bet = 1;
            //}

            Console.WriteLine("What is the largest country in the world?");
            Console.WriteLine();
            Console.WriteLine("A). Canada");
            Console.WriteLine("B). Russia");
            Console.WriteLine("C). USA");
            Console.WriteLine("D). China");
            Console.WriteLine();
            Console.WriteLine("Input the letter as your answer...");
            answer = Console.ReadLine();
            if (answer == "a")
                Console.WriteLine("Good try, but incorrect. Canada is the second largest");
            else if (answer == "b")
                Console.WriteLine("That is correct");
            else if (answer == "c")
                Console.WriteLine("Incorrect. The US is not the largest");
            else if (answer == "d")
                Console.WriteLine("Incorrect. China is actually the smallest of the 4");
            else











        }
    }
}
