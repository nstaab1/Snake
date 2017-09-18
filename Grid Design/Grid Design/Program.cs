using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Grid_Design.Classes;
using System.Timers;

namespace Grid_Design
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] numbers2D = new int[10, 40];
            int xPoint = 0;
            int yPoint = 0;
            List<SnakeBody> newSnake = new List<SnakeBody>();

            SnakeBody elm1 = new SnakeBody(4,8,5);
            SnakeBody elm2 = new SnakeBody(4,12,5); 
            newSnake.Add(elm1);
            newSnake.Add(elm2);

            for (int i = 0; i < newSnake.Count; i++)
            {
                xPoint = newSnake[i].PosIn;
                yPoint = newSnake[i].PosDown;
                numbers2D[xPoint, yPoint] = newSnake[i].SnakePart;
            }
            
           


            //PRINTS GRID!!
            for (int i = 0; i < numbers2D.GetLength(0); i++)
            {
                //loops through each row
                for (int k = 0; k < numbers2D.GetLength(1); k++)
                {

                    


                    if (numbers2D[i, k] == 0)
                    {
                        //put a single value
                        numbers2D[i, k] = 0;
                        Console.BackgroundColor = ConsoleColor.White;
                        //Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(numbers2D[i, k]);

                    }
                    else
                    {
                        Console.Write(elm1.SnakePart);
                    }
                    // Take a key handler and change values based on the key that is changed
                    //if (Console.ReadKey == )


                }
                //next row
                Console.WriteLine();
            }

            int gameStart = 80;
            int tree = 0;
            //last coordinate of earlier element
            int tempDown = 0;
            int tempIn = 0;
            //coordinate of current element
            //NOT FUCKED UP
            int moveToDown = 5;
            int moveToIn = 4;

            while (tree < gameStart)
            {
                ConsoleKeyInfo info = Console.ReadKey(true);

                
                //set current position to temporary coordinate
                tempIn = newSnake[0].PosIn;
                tempDown = newSnake[0].PosDown;
                //erase
                Console.SetCursorPosition(tempIn, tempDown);
                Console.Write(0);
                //set current coordinates to movement coordinates
                newSnake[0].PosIn = moveToIn;
                newSnake[0].PosDown = moveToDown;
                //move and print to new movement coordinates
                Console.SetCursorPosition(newSnake[0].PosIn, newSnake[0].PosDown);
                //Thread.Sleep(500);
                Console.Write(newSnake[0].SnakePart);


                for (int i = 1; i < newSnake.Count; i++)
                {
                    //set movement coordinates to temporary coordinates
                    moveToIn = tempIn;
                    moveToDown = tempDown;
                    //set temporary coordinates to current coordinates
                    tempDown = newSnake[i].PosIn;
                    tempIn = newSnake[i].PosDown;
                    //erase
                    Console.SetCursorPosition(tempIn, tempDown);
                    Console.Write(0);
                    //change current coordinates to new movement coordinates
                    newSnake[i].PosIn = moveToIn;
                    newSnake[i].PosDown = moveToDown;
                    //print to new coordinates
                    Console.SetCursorPosition(newSnake[i].PosIn, newSnake[i].PosDown);
                    Console.Write(newSnake[i].SnakePart);

                }
                moveToDown+= newSnake.Count;















                //if ((info.Key == ConsoleKey.A || info.Key == ConsoleKey.LeftArrow))
                //{

                //    if (xPoint - 1 < 0 || xPoint - 1 > 39)
                //    {
                //        Console.WriteLine("YOU LOSE!");
                //        gameStart = false;
                //        return;
                //    }


                //    Console.SetCursorPosition(xPoint, yPoint);
                //    Console.Write(0);
                //    Console.SetCursorPosition(xPoint - 1 , yPoint);
                //    Console.Write(1);                    
                //    xPoint--;

                //}
                //if ((info.Key == ConsoleKey.W || info.Key == ConsoleKey.UpArrow))
                //{

                //    if (yPoint - 1 < 0 /*|| yPoint - 1 > 9*/)
                //    {
                //        Console.WriteLine("YOU LOSE!");
                //        gameStart = false;
                //        return;
                //    }

                //    Console.SetCursorPosition(xPoint, yPoint );
                //    Console.Write(0);
                //    Console.SetCursorPosition(xPoint, yPoint -1);
                //    Console.Write(1);                   
                //    yPoint--;

                //}
                //if ((info.Key == ConsoleKey.D || info.Key == ConsoleKey.RightArrow))
                //{

                //    if (/*xPoint + 1 < 0 ||*/ xPoint + 1 > 39)
                //    {
                //        Console.WriteLine("YOU LOSE!");
                //        gameStart = false;
                //        return;
                //    }

                //    Console.SetCursorPosition(xPoint, yPoint);
                //    Console.Write(0);
                //    Console.SetCursorPosition(xPoint +1, yPoint);
                //    Console.Write(1);                    
                //    xPoint++;

                //}
                //if ((info.Key == ConsoleKey.S || info.Key == ConsoleKey.DownArrow))
                //{

                //    if (yPoint + 1 < 0 || yPoint + 1 > 9)
                //    {
                //        Console.WriteLine("YOU LOSE!");
                //        gameStart = false;
                //        return;
                //    }

                //    Console.SetCursorPosition(xPoint, yPoint);
                //    Console.Write(0);
                //    Console.SetCursorPosition(xPoint, yPoint +1);
                //    Console.Write(1);                                    
                //    yPoint++;


                //}
            }

        }

    }

    //set cursor position (Change position of the edit.
    //separate classes into if is snake is not snake....
    //LICEcap for making gifs
}
