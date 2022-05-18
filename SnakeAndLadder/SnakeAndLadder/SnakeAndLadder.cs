using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
       const int WIN_POSITION = 0;
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
            int RollDiceCount = 0;
            while (currentPosition < WIN_POSITION - 1)
            {
                int throwDices = throwDice();
                RollDiceCount++;
                int selectOption = checkForOption();
                switch (selectOption)
                {
                    case 1:
                        Console.WriteLine("Player got ladder");
                        currentPosition += throwDices;
                        Console.WriteLine("Current position is=" + currentPosition);
                        if (currentPosition > WIN_POSITION)
                        {
                            currentPosition -= throwDices;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Player got snake");
                        if ((currentPosition - throwDices) < 0)
                        {
                            currentPosition = 0;
                        }
                        else
                        {
                            currentPosition -= throwDices;
                            Console.WriteLine("current Position is=" +currentPosition);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Player not play");
                        break;
                    default:
                        break;
                }
                if (currentPosition == WIN_POSITION)
                {
                    Console.WriteLine("Player won!");
                    Console.WriteLine("number of dice was played by player for win the game is" + RollDiceCount);
                    break;
                }
            }   
         }
    }
}
