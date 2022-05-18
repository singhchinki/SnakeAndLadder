using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
       const int WIN_POSITION = 100;
       public static int currentPosition = 0;
       static Random random = new Random();
       public static int throwDice()
        {
            return random.Next(1, 7);
        }
        public static int checkForOption()
        {
            return random.Next(1,4);
        }

        static void Main(string[] args)
        {
            int playerOnePosition = 0;
            int playerTwoPosition = 0;
            int playerOneRollDiceCount = 0;
            int playerTwoRollDiceCount = 0;
            while (currentPosition < WIN_POSITION - 1)
            {
                int playerOnethrowDices = throwDice();
                playerOneRollDiceCount++;
                int playerTwothrowDices = throwDice();
                playerTwoRollDiceCount++;
                int selectOption = checkForOption();
                switch (selectOption)
                {
                    case 1:
                        Console.WriteLine("Player got ladder");
                        playerOnePosition += playerOnethrowDices;
                        playerTwoPosition += playerTwothrowDices;

                        if (playerOnePosition > WIN_POSITION)
                        {
                            playerOnePosition -= playerOnethrowDices;
                        }
                        else if (playerOnePosition > WIN_POSITION)
                        {
                            playerTwoPosition -= playerOnethrowDices;
                        }
                        Console.WriteLine("player one position is=" + playerOnePosition);
                        Console.WriteLine("player two position is=" + playerTwoPosition);
                        break;
                    case 2:
                        Console.WriteLine("Player got snake");
                        if ((playerOnePosition - playerOnethrowDices) < 0)
                        {
                            playerOnePosition = 0;
                        }
                        else
                        {
                            playerOnePosition -= playerOnethrowDices;
                        }
                        if ((playerTwoPosition - playerTwothrowDices) < 0)
                        {
                            playerTwoPosition = 0;
                        }
                        else
                        {
                            playerTwoPosition-= playerTwothrowDices;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Player not play");
                        break;
                    default:
                        break;
                }
                if (playerOnePosition == WIN_POSITION)
                {
                    Console.WriteLine("Player one is won!");
                    Console.WriteLine("number of dice was played by player for win the game is" + playerOneRollDiceCount);
                    break;
                }
                else if ((playerTwoPosition == WIN_POSITION) && (playerOnePosition != WIN_POSITION))
                {
                    Console.WriteLine("Player Two is won!");
                    Console.WriteLine("number of dice was played by player for win the game is" + playerOneRollDiceCount);
                    break;
                }  
            }   
         }
    }
}
