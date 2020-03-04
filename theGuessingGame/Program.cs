using System;

namespace theGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GameMethods mathGame = new GameMethods();
            MathGame game = new MathGame();
            Console.WriteLine("Hey whats your name?");
            string userName = Console.ReadLine();
            mathGame.GameInput = userName;
            bool boolFirstLevel = false;

           Console.WriteLine("Hi " + mathGame.GameInput + " want to play a game?");

            string userInput = Console.ReadLine();
            string returnedResponse = mathGame.CheckUserInput(userInput);

            
            Console.WriteLine("You voted " + returnedResponse);
            if(returnedResponse == "Yes")
            {
               boolFirstLevel = game.PlayGame(userName);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Good bye! " + userName);
            }
            game.levelTwo();

        }
    }
}
