using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
       const int START_POSITION = 0;
       const int END_POSITION = 100;
       public static int currentPosition = 0;
       public static int selectOption = 0;
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
            while (currentPosition < END_POSITION - 1)
            {
                int throwDices = throwDice();
                int selectOption = checkForOption();
                switch (selectOption)
                {
                    case 1:
                        Console.WriteLine("Player got ladder");
                        currentPosition += throwDices;
                        if (currentPosition > END_POSITION)
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
                        }
                        break;
                    case 3:
                        Console.WriteLine("Player not play");
                        break;
                    default:
                        break;

                }
            }   

        }
    }
}
