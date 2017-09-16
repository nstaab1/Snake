using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid_Design.Classes
{
    public class SnakeBody
    {
        private int posX;
        private int posY;
        private int snakePart;

        public int PosX
        {
            get { return this.posX; }
        }

       
        public int PosY
        {
            get { return this.posY; }
        }

        public int SnakePart
        {
            get
            {
                Console.BackgroundColor = ConsoleColor.Red;
                return this.snakePart;                
            }
        }

        public SnakeBody (int posX, int posY, int snakePart)
        {
            this.posX = posX;
            this.posY = posY;
            this.snakePart = snakePart;
        }

    }
}
