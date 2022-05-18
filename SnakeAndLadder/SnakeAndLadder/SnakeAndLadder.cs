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
        public static int throwDice()
        {
            Random random = new Random();
            int number = random.Next(1, 7);
            return number;
        }
        static void Main(string[] args)
        {
            currentPosition += throwDice();
            Console.WriteLine("current Position is:" + currentPosition);
            Console.WriteLine("Start position is: " + START_POSITION);
            Console.WriteLine("End postion is: " + END_POSITION);

        }
    }
}
