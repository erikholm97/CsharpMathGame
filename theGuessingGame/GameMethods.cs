using System;
using System.Collections.Generic;
using System.Text;

namespace theGuessingGame
{
    class GameMethods
    {
        private string gameInput; // field
        private string gameResponse;
        public string GameInput   // property
        {
            get { return gameInput; }
            set { gameInput = value; }
        }
        public string CheckUserInput(string input)
        {
            try
            {
                if (input == "yes" || input == "Yes" || input == "YES")
                {
                    gameResponse = "Yes";
                }
                else if (input == "no" || input == "No" || input == "NO")
                {
                    gameResponse = "No";
                }
                else
                {
                    gameResponse = "Start over something went wrong";
                }
               
            }
            catch(SystemException ex)
            {
                Console.WriteLine(ex);
            }
            return gameResponse;
        }



    }
}
