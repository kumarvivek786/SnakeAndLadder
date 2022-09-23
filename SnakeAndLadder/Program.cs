using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SnakeAndLadder
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //UC-2 Roll Die
            int Start_Position = 0, r = 0, choice = 0;
            const int NOPLAY = 0;
            const int LADDER = 1;
            const int SNAKE=2;
            Random random = new Random();
            r = random.Next(1, 7);
            Console.WriteLine("Dice:" + r);
            
            choice=random.Next(0, 3);
            Console.WriteLine("choice: {0}" , choice);

            switch (choice)
            {
                case NOPLAY:
                    Console.WriteLine("position: {0}", Start_Position);
                    break;
                case LADDER:
                    Start_Position = Start_Position + r;
                    Console.WriteLine("position: {0}", Start_Position);
                    break;
                case SNAKE:
                    Start_Position = Start_Position - r;
                    if (Start_Position < 0)
                        Start_Position = 0;
                    Console.WriteLine("position:{0}", Start_Position);
                    break;
            }
            Console.ReadLine();
                




        }
    }
}
    


