using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Grid_Design.Classes
{
    class Movement
    {
        private string direction;


        public void MoveRight()
        {
            
        }

        public Movement(string direction)
        {
            this.direction = direction;
        }

    }





    //Do NOT change under any circumstance

    //for (int i = 1; i<newSnake.Count; i++)
    //                    {
    //                        Console.SetCursorPosition(newSnake[i].PosHorizontal, newSnake[i].PosVertical);
    //                        Console.Write(0);
    //                        tempHorizontal = newSnake[i].PosHorizontal;
    //                        tempVertical = newSnake[i].PosVertical;
    //                        newSnake[i].PosHorizontal = moveHorizontalForNextSegment;
    //                        newSnake[i].PosVertical = moveVerticalForNextSegment;
    //                        Console.SetCursorPosition(newSnake[i].PosHorizontal, newSnake[i].PosVertical);
    //                        Console.Write(elm1.SnakePart);
    //                        moveVerticalForNextSegment = tempVertical;
    //                        moveVerticalForNextSegment = tempHorizontal;






    //                    }
}
