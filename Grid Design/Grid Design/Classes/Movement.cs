using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Grid_Design.Classes
{
    class Movement
    {
        static void Main(string[] args)
        {
            int positionX = 1;
            int positionY = 1;

            string O = "O";
            //Timer timer = new Timer(2000);
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(O);
            while (positionX < 20)
            {

                Thread.Sleep(100);
                Console.SetCursorPosition(positionX, positionY);
                Console.Write(O);
                positionX += 1;


            }




        }

    }
}
