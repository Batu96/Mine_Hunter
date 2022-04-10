using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mine_destructor
{
    class mine
    {
        public int x1, x2, x3, x4, x5, y1, y2, y3, y4, y5;
        public  void createMine()
        {
            Random rnd = new Random();
            x1 = rnd.Next(1,45);
            x2 = rnd.Next(1,45);
            x3 = rnd.Next(1,45);
            x4 = rnd.Next(1,45);
            x5 = rnd.Next(1,45);
            y1 = rnd.Next(1,15) ;
            y2= rnd.Next(1,15);
            y3= rnd.Next(1,15);
            y4= rnd.Next(1,15);
            y5= rnd.Next(1,15);
            }
        public  void draw()
        {
            Console.SetCursorPosition(x1,y1);
            Console.Write("*");
            Console.SetCursorPosition(x2,y2);
            Console.Write("*");
            Console.SetCursorPosition(x3,y3);
            Console.Write("*");
            Console.SetCursorPosition(x4,y4);
            Console.Write("*");
            Console.SetCursorPosition(x5,y5);
            Console.Write("*");
        }   
        public void explode(int i ,int j)
        {
            Console.SetCursorPosition(i , j);
            Console.Write("O");
            Console.Beep(800,500);
        }    
    
    
    }
}
