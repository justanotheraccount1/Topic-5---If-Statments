namespace Topic_5___If_Statments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sam Ahrens 09/18/24
            bool working;
            string dinosaur, magicWord, answer, guess1, guess2, guess3, guess4, guess5, password, topping, animal, weather;
            int age, confirm, grade;
            double temp, bet, money;
            int people = 20;
            int cats = 20;
            int dogs = 15;
            Console.ForegroundColor = ConsoleColor.White;
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
            //else if (age < 16)
            //    Console.WriteLine("You can't drive");
            //else if (age < 18)
            //    Console.WriteLine("You can drive, but not vote");
            //else if (18 <= age)
            //    Console.WriteLine("You can vote, but you can't rent a car");
            //else if (age >= 25)
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

            //Console.WriteLine("What is the largest country in the world?");
            //Console.WriteLine();
            //Console.WriteLine("A). Canada");
            //Console.WriteLine("B). Russia");
            //Console.WriteLine("C). USA");
            //Console.WriteLine("D). China");
            //Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Input the letter as your answer...");
            //Console.ForegroundColor = ConsoleColor.White;
            //answer = Console.ReadLine();
            //if (answer.ToLower() == "a")
            //    Console.WriteLine("Good try, but incorrect. Canada is the second largest");
            //else if (answer.ToLower() == "b")
            //    Console.WriteLine("That is correct");
            //else if (answer.ToLower() == "c")
            //    Console.WriteLine("Incorrect. The US is not the largest");
            //else if (answer.ToLower() == "d")
            //    Console.WriteLine("Incorrect. China is actually the smallest of the 4");
            //else
            //    Console.WriteLine("That is an invalid answer. Please input one of the 4 options.");



            //Console.WriteLine("Please input a temperature in degrees Celcius:");
            //double.TryParse(Console.ReadLine(), out temp);
            //if (temp >= 100)
            //    Console.WriteLine("the water is a gas");
            //else if (temp >= 0)
            //    Console.WriteLine("The water is a liquid");
            //else
            //    Console.WriteLine("the water is a solid");


            //Part 3

            //Console.WriteLine("How old are you?");
            //int.TryParse(Console.ReadLine(), out age);
            //if (age >= 13 && age <= 18)
            //    Console.WriteLine("You are a teen");
            //else
            //    Console.WriteLine("You are not a teen");

            //Console.WriteLine("Hey, are you working tonight? Yes or No");
            //answer = Console.ReadLine();
            //if (answer.ToLower() == "yes")
            //    Console.WriteLine("Shoot, I wanted to go to a movie with you tonight");
            //else if (answer.ToLower() == "no")
            //{
            //    Console.WriteLine("Great! How much money do you have on you right now?");
            //    Console.Write("$");
            //    double.TryParse(Console.ReadLine(), out money);
            //    if (money >= 20)
            //        Console.WriteLine("Great! We should go to the movies together.");
            //    else if (money < 20)
            //        Console.WriteLine("AHGHHGH!!! I really wanted to go to the movies with you, but you don't have enough to come. :(");

            //}
            //else
            //    Console.WriteLine("That's not an answer you IDIOT!");


            //password = "password";
            //Console.WriteLine("Please enter the password:");
            //guess1 = Console.ReadLine().ToLower();
            //if (guess1 == password)
            //    Console.WriteLine("Access Granted");
            //else
            //{
            //    Console.WriteLine("Try again:");
            //    guess2 = Console.ReadLine().ToLower();
            //    if (guess2 == password)
            //        Console.WriteLine("Access Granted");
            //    else
            //    {
            //        Console.WriteLine("Try again:");
            //        guess3 = Console.ReadLine().ToLower();
            //        if (guess3 == password)
            //            Console.WriteLine("Access Granted");
            //        else
            //        {
            //            Console.WriteLine("Try again:");
            //            guess4 = Console.ReadLine().ToLower();
            //            if (guess4 == password)
            //                Console.WriteLine("Access Granted");
            //            else
            //            {
            //                Console.WriteLine("Try again:");
            //                guess5 = Console.ReadLine().ToLower();
            //                if (guess5 == password)
            //                    Console.WriteLine("Access Granted");
            //                else
            //                {
            //                    Console.WriteLine("Access Denied");
            //                }
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine("What is your favorite pizza topping?");
            //topping = Console.ReadLine().ToLower();
            //if (topping == "pepperoni" || topping == "bacon")
            //    Console.WriteLine("yum");
            //else
            //    Console.WriteLine("I don't like " + topping);


            //Console.WriteLine("How old are you?");
            //int.TryParse(Console.ReadLine(), out age);
            //if (age >= 60 || age <= 12)
            //    Console.WriteLine("the ticket costs $2.50");
            //else
            //    Console.WriteLine("the ticket costs $3.50");


            //Console.WriteLine("What is your favorite animal?");
            //animal = Console.ReadLine().ToLower();
            //if (animal == "cat" || animal == "dog")
            //    Console.WriteLine("Me too");
            //else
            //    Console.WriteLine("To each their own.");


            Console.WriteLine("is it sunny or cloudy?");
            weather = Console.ReadLine().ToLower();
            Console.WriteLine("What is the temperature?");
            double.TryParse(Console.ReadLine(), out temp);
            if (temp >= 25 || weather == "sunny")
                Console.WriteLine("Swim time");
            else
                Console.WriteLine("Nap time");














        }
    }
}
