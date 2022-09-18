using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC-2 Roll Die
            int Start_Position = 0, r = 0;
            Random random = new Random();
            r = random.Next(1, 7);
            Console.WriteLine("Dice:"+ r);
            Console.ReadLine();
        }
    }
}
