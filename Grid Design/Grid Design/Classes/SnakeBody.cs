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


        //when snake head hits "1" add snakepart to body

        //public void AddSnakePart(int up, int accross)
        //{
        //    if(boardElement == foodElement)
        //    {
        //        /* add on to snake;*/
        //    }
        //}


        //End game when snake head hits boundary or itself

        //public void QuitGame()
        //{
        //    if (snakebody[0] > 28 || snakebody[0] < 0)
        //    {
        //        /*end program;*/
        //    }
        //    if(snakebody[1] > 100 || snakebody[1] < 0)
        //    {
        //        /*end program;*/
        //    }
        //    if(snakeElement == snakePart)
        //    {
        //        /*end program;*/
        //    }
        //}
    }
}
