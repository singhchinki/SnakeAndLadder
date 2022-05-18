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
        public static int playerOption()
        {
            int throwDices = throwDice();
            int selectOption = checkForOption();
            if (selectOption == 2)
            {
                currentPosition += throwDices;
            }
            else if (selectOption == 3)
            {
                currentPosition -= throwDices;
                if (currentPosition < 0)
                {
                    currentPosition = START_POSITION;
                }
            }
            else
            {
                Console.WriteLine("Do nothing player stay in same position");
            }
            return currentPosition;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Start position is: " + START_POSITION);
            Console.WriteLine("End postion is: " + END_POSITION);
            Console.WriteLine("Current position is: " + playerOption());

        }
    }
}
