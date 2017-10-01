using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Grid_Design.Classes
{
    class Movement
    {
        public Movement()
        {
            
        }

        // Need to put for loops and if/else logic in these methods
        // Also may need to rework method inputs
        public void MoveLeft(List<SnakeBody> name, int movementVariable)
        {
            movementVariable += name[0].PosHorizontal - 1;
            
        }
                
        public void MoveRight(List<SnakeBody> name, int movementVariable)
        {
            movementVariable += name[0].PosHorizontal + 1;
        }
                
        public void MoveDown(List<SnakeBody> name, int movementVariable)
        {
            movementVariable += name[0].PosVertical + 1;
        }
        
        public void MoveUp(List<SnakeBody> name, int movementVariable)
        {
            movementVariable += name[0].PosVertical - 1;
        }








        //private string direction;


        //public void MoveSnake()
        //{
        //    //Console.SetCursorPosition(newSnake[i].PosHorizontal, newSnake[i].PosVertical);
        //    //Console.BackgroundColor = ConsoleColor.Black;
        //    //Console.Write(0);
        //    //tempHorizontal = newSnake[i].PosHorizontal;
        //    //tempVertical = newSnake[i].PosVertical;
        //    //newSnake[i].PosHorizontal = moveHorizontalForNextSegment;
        //    //newSnake[i].PosVertical = moveVerticalForNextSegment;
        //    //Console.SetCursorPosition(newSnake[i].PosHorizontal, newSnake[i].PosVertical);
        //    //Console.Write(elm1.SnakePart);
        //    //moveVerticalForNextSegment = tempVertical;
        //    //moveHorizontalForNextSegment = tempHorizontal;
        //}

        //public void MoveRight(SnakeBody elm)
        //{
        //    Thread.Sleep(150);

        //    //variable used to move snake right by 1 space
        //    int moveRight = 0;
        //    moveRight += newSnake[0].PosHorizontal + 1;
        //    Console.SetCursorPosition(elm.PosHorizontal, elm.PosVertical);

        //    //Move variable store the previous position of the head of the snake
        //    moveVerticalForNextSegment = elm.PosVertical;
        //    moveHorizontalForNextSegment = elm.PosHorizontal;
        //    Console.Write(0);
        //    elm.PosHorizontal = moveRight;
        //    Console.SetCursorPosition(elm.PosHorizontal, elm.PosVertical);
        //    Console.Write(elm.SnakePart);
        //}
        //public void MoveLeft(SnakeBody elm)
        //{
        //    Thread.Sleep(150);
        //    //variable used to move snake right by 1 space
        //    int moveLeft = 0;
        //    moveLeft += newSnake[0].PosHorizontal - 1;
        //    Console.SetCursorPosition(elm.PosHorizontal, elm.PosVertical);
        //    //Move variable store the previous position of the head of the snake
        //    moveVerticalForNextSegment = elm.PosVertical;
        //    moveHorizontalForNextSegment = elm.PosHorizontal;
        //    Console.Write(0);
        //    elm.PosHorizontal = moveLeft;
        //    Console.SetCursorPosition(elm.PosHorizontal, elm.PosVertical);
        //    Console.Write(elm.SnakePart);
        //}
        //public void MoveDown(SnakeBody elm)
        //{
        //    Thread.Sleep(150);
        //    //variable used to move snake right by 1 space
        //    int moveDown = 0;
        //    moveDown += newSnake[0].PosVertical + 1;
        //    Console.SetCursorPosition(elm.PosHorizontal, elm.PosVertical);
        //    //Move variable store the previous position of the head of the snake
        //    moveVerticalForNextSegment = elm.PosVertical;
        //    moveHorizontalForNextSegment = elm.PosHorizontal;
        //    Console.Write(0);
        //    elm.PosVertical = moveDown;
        //    Console.SetCursorPosition(elm.PosHorizontal, elm.PosVertical);
        //    Console.Write(elm.SnakePart);
        //}
        //public void MoveUp(SnakeBody elm)
        //{
        //    Thread.Sleep(150);

        //    //variable used to move snake right by 1 space
        //    int moveUp = 0;
        //    moveUp += newSnake[0].PosVertical - 1;
        //    Console.SetCursorPosition(elm.PosHorizontal, elm.PosVertical);

        //    //Move variable store the previous position of the head of the snake
        //    moveVerticalForNextSegment = elm.PosVertical;
        //    moveHorizontalForNextSegment = elm.PosHorizontal;
        //    Console.Write(0);
        //    elm.PosVertical = moveUp;
        //    Console.SetCursorPosition(elm.PosHorizontal, elm.PosVertical);
        //    Console.Write(elm.SnakePart);
        //}

        //public Movement(string direction)
        //{
        //    this.direction = direction;
        //}

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
