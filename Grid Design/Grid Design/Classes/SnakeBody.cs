using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid_Design.Classes
{
    public class SnakeBody
    {
        private int posIn;
        private int posDown;
        private int snakePart;

        public int PosIn
        {
            get { return this.posIn; }
            set { this.posIn = value; }
        }

       
        public int PosDown
        {
            get { return this.posDown; }
            set { this.posDown = value; }
        }

        public int SnakePart
        {
            get
            {
                Console.BackgroundColor = ConsoleColor.Red;
                return this.snakePart;                
            }
        }

        public SnakeBody (int posIn, int posDown, int snakePart)
        {
            this.posIn = posIn;
            this.posDown = posDown;
            this.snakePart = snakePart;
        }

    }
}
