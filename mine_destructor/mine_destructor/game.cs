using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mine_destructor
{
    class game
    {
       
       
        public static void frame()
        {
            for(int i = 0; i < 45; i++)
            {
                Console.SetCursorPosition(i,0);
                Console.WriteLine("-");
            }
             for(int i = 45; i>0; i--)
            {
                Console.SetCursorPosition(i,15);
                Console.WriteLine("-");
            }
             for(int i = 15; i>0; i--)
            {
                Console.SetCursorPosition(0,i);
                Console.WriteLine("|");
            }
             for(int i = 15; i>0; i--)
            {
                Console.SetCursorPosition(45,i);
                Console.WriteLine("|");
            }
            
        }
      

        public void play()
        {
            vehicle car = new vehicle();
            mine mine = new mine();
            ConsoleKeyInfo key;
            car.start();
            mine.createMine();
            int counter = 0;

            do
            {
                
                mine.draw();
                key = Console.ReadKey();
                car.move(key);
                car.draw();
                game.frame();
                if (key.Key == ConsoleKey.A)
                {
                    car.destruction(mine);
                    counter++;
                }
                car.score();
                Console.WriteLine("Counter-->"+counter);
                

            } while (key.Key != ConsoleKey.Escape && counter<=10);

        }
    }
}


