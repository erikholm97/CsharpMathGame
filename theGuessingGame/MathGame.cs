using System;
using System.Collections.Generic;
using System.Text;

namespace theGuessingGame
{
    class MathGame
    {
        private string userNameInGame;
        public Random rnd = new Random();
        public bool PlayGame(string userName)
        {
            int testCount = 0;
            userNameInGame = userName;
            int firstNumber = 0;
            int secondNumber = 0;
            int finalNumber = 0;
            string userResponse;
            int convertedUserResponse;
            Console.Clear();
            Console.WriteLine("Im going to put up to math problems and if you solve them you can reach the next level.");
            Console.WriteLine("Press enter to start.");
            Console.ReadLine();
            Console.Clear();
            bool finnishedFirstLevel = false;
            firstNumber = rnd.Next(1, 50);
            secondNumber = rnd.Next(1, 50);
            finalNumber = firstNumber + secondNumber;


            Console.WriteLine("So... what is " + firstNumber + " + " + secondNumber + "? Press enter to submit.");
            userResponse = Console.ReadLine();
            convertedUserResponse = int.Parse(userResponse);

            do
            {
                try
                {
                    if (convertedUserResponse == finalNumber)
                    {
                        Console.WriteLine("Good job " + userName + " answer " + userResponse + " was right since " + firstNumber + " + " + secondNumber + " = " + finalNumber + " You are really smart!");
                        finnishedFirstLevel = true;
                    }
                    else
                    {
                        Console.WriteLine("Sorry the answer is wrong, the correct one is " + finalNumber + " better luck next time " + userNameInGame + " press enter to try again.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Something went wrong" + ex + " please restart by pressing enter. ");
                    Console.ReadLine();
                    return false;

                }
            } while (finnishedFirstLevel == false);

            Console.WriteLine("Taking the steps to the next level");
            return true;



        }
        public void levelTwo()
        {
            bool finnished = false;
            Console.Clear();
            Console.WriteLine("You are smart "  + userNameInGame + " but let me se if you are even smarter! (press enter)" );
            Console.ReadLine();

            int levelTwoNumberOne = rnd.Next(1, 1000);
            int levelTwoNumberTwo = rnd.Next(1, 1000);
            int finalNumberLevelTwo = levelTwoNumberTwo - levelTwoNumberTwo;

            Console.WriteLine("What is " + levelTwoNumberOne + " - " + levelTwoNumberTwo + "?");
            string levelTwoAnswer = Console.ReadLine();
            int convertToint = int.Parse(levelTwoAnswer);
            do
            {
                if (finalNumberLevelTwo == convertToint)
                {
                    Console.WriteLine("WOOOOOOOOW!! You are really good " + userNameInGame);

                }
                else
                {
                    Console.WriteLine("Better luck next time" + userNameInGame + " the answer was wrong this time but it will probably be right the next time! Try again someother time goodbye.");
                    finnished = false;
                }
            }
            while (finnished = false);
            Console.Clear();
            Console.WriteLine("let's procceed... (press enter)");
            Console.ReadLine();
            
        }

    }
}
