using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mine_destructor
{
    class vehicle
    {
        public char vehicle_sign = 'V';
        public int xlocation=1;
        public int ylocation=1;
        int score_counter = 0;


        public void start()
        {
            Console.SetCursorPosition(xlocation, ylocation);
            Console.WriteLine(vehicle_sign);
            game.frame();

        }
        public void draw()
        {
            Console.Clear();
            Console.SetCursorPosition(xlocation, ylocation);
            Console.Write(vehicle_sign);
        }
        public void move(ConsoleKeyInfo basilan)
        {
            
            if (basilan.Key == ConsoleKey.RightArrow)
            {
              xlocation++;
             }
            if (basilan.Key == ConsoleKey.LeftArrow)
            {
              xlocation--;
             }
            if (basilan.Key == ConsoleKey.UpArrow)
            {
              ylocation--;
             }
            if (basilan.Key == ConsoleKey.DownArrow)
            {
                ylocation++;
            }
        }
    public void destruction(mine mines)
        {
            
                if (xlocation == mines.x1 && ylocation == mines.y1)
                {
                    mines.explode(xlocation, ylocation); score_counter++;
                }
                if (xlocation == mines.x2 && ylocation == mines.y2)
                {
                    mines.explode(xlocation, ylocation); score_counter++;
                }
                if (xlocation == mines.x3 && ylocation == mines.y3)
                {
                    mines.explode(xlocation, ylocation); score_counter++;
                }
               if (xlocation == mines.x4 && ylocation == mines.y4)
               {
                    mines.explode(xlocation, ylocation); score_counter++;
               }
               if (xlocation == mines.x5 && ylocation == mines.y5)
               {
                    mines.explode(xlocation, ylocation); score_counter++;
               }
        }

        public void score()
        {
           
            Console.SetCursorPosition(0, 16);
            
            Console.WriteLine("score -->" + score_counter);

        }

    }
}
