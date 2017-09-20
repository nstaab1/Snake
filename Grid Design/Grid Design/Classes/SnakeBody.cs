using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid_Design.Classes
{
    public class SnakeBody
    {
        private int posHorizontal;
        private int posVertical;
        private int snakePart;

        public int PosHorizontal
        {
            get { return this.posHorizontal; }
            set { this.posHorizontal = value; }
        }

       
        public int PosVertical
        {
            get { return this.posVertical; }
            set { this.posVertical = value; }
        }

        public int SnakePart
        {
            get
            {
                Console.BackgroundColor = ConsoleColor.Red;
                return this.snakePart;                
            }
        }

        public SnakeBody (int posDown, int posAcross, int snakePart)
        {            
            this.posVertical = posDown;
            this.posHorizontal = posAcross;
            this.snakePart = snakePart;
        }

    }
}
