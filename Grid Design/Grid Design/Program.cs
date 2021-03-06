﻿using System;
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
            int upMaxCoordinate = 28;
            int acrossMaxCoordinate = 100;
            int[,] numbers2D = new int[upMaxCoordinate, acrossMaxCoordinate];

            int score = 0;

            

            bool gameOver = false;

            FoodGenerator addFood = new FoodGenerator();
            // cursor position for food generator
            int upFood;
            int acrossFood;

            //points used to initialize snake
            int horizontalPoint = 0;
            int verticalPoint = 0;
            List<SnakeBody> newSnake = new List<SnakeBody>();

            SnakeBody elm1 = new SnakeBody(3, 6, 5);
            SnakeBody elm2 = new SnakeBody(3, 5, 5);
            SnakeBody elm3 = new SnakeBody(3, 4, 5);
            SnakeBody elm4 = new SnakeBody(3, 3, 5);
            SnakeBody elm5 = new SnakeBody(3, 2, 5);
            SnakeBody elm6 = new SnakeBody(3, 1, 5);
            newSnake.Add(elm1);
            newSnake.Add(elm2);
            newSnake.Add(elm3);
            newSnake.Add(elm4);
            newSnake.Add(elm5);
            newSnake.Add(elm6);


            //for as long as the start snake, make those values snakepart
            for (int i = 0; i < newSnake.Count; i++)
            {
                verticalPoint = newSnake[i].PosVertical;
                horizontalPoint = newSnake[i].PosHorizontal;
                numbers2D[verticalPoint, horizontalPoint] = newSnake[i].SnakePart;
            }




            //PRINTS GRID!!
            for (int i = 0; i < numbers2D.GetLength(0); i++)
            {
                //loops through each row
                for (int k = 0; k < numbers2D.GetLength(1); k++)
                {



                    Console.BackgroundColor = ConsoleColor.Black;
                    if (numbers2D[i, k] == 0)
                    {
                        //put a single value
                        numbers2D[i, k] = 0;

                        //Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(numbers2D[i, k]);

                    }
                    else
                    {
                        //Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(elm1.SnakePart);
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    // Take a key handler and change values based on the key that is changed
                    //if (Console.ReadKey == )


                }
                //next row
                Console.WriteLine();
            }


            //generate random coordinates
            //Random horizontal = new Random();
            //Random vertical = new Random();
            //int randomHorizontal = horizontal.Next(1, 100);
            //int randomVertical = vertical.Next(1, 28);
            //Console.SetCursorPosition(randomHorizontal, randomVertical);
            //Console.BackgroundColor = ConsoleColor.Yellow;
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.Write("1");
            //Console.ForegroundColor = ConsoleColor.Black;

            bool gameLength = true;
            //int firstMovement = 0;
            //ConsoleKeyInfo info = Console.ReadKey(true);

            //add food at a random place
            acrossFood = addFood.FoodPosHorizontal;
            upFood = addFood.FoodPosVertical;
            addFood.PlaceFood(acrossFood, upFood);

            int sleepVariable = 37;
            double variableHolder = sleepVariable * 1.5;
            int verticalSleep;
            verticalSleep = (int)variableHolder;

            do
            {
                int tempVertical = 0;
                int tempHorizontal = 0;
                int moveVerticalForNextSegment = 0;
                int moveHorizontalForNextSegment = 0;
                ConsoleKeyInfo info = Console.ReadKey(true);

                while (Console.KeyAvailable == false)
                {


                    if (newSnake[0].PosHorizontal <= 0 || newSnake[0].PosHorizontal >= acrossMaxCoordinate || newSnake[0].PosVertical <= 0 || newSnake[0].PosVertical >= upMaxCoordinate)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over");
                        Console.WriteLine($"score: {score}");
                        gameOver = true;
                        break;

                    }

                    if ((info.Key == ConsoleKey.A || info.Key == ConsoleKey.LeftArrow))
                    {
                       

                        Thread.Sleep(sleepVariable);
                        //variable used to move snake right by 1 space
                        int moveLeft = 0;
                        moveLeft += newSnake[0].PosHorizontal - 1;
                        
                        if (newSnake[0].PosHorizontal == acrossFood && newSnake[0].PosVertical == upFood)
                        {
                            score += newSnake.Count;
                            newSnake.Add(new SnakeBody(upFood, acrossFood, 5));
                            //Console.Write(0);
                            newSnake[0].PosHorizontal = moveLeft;
                            Console.SetCursorPosition(newSnake[0].PosHorizontal, newSnake[0].PosVertical);
                            Console.Write(newSnake[0].SnakePart);
                            acrossFood = addFood.FoodPosHorizontal;
                            upFood = addFood.FoodPosVertical;
                            addFood.PlaceFood(acrossFood, upFood);
                        }
                        else
                        {
                            Console.SetCursorPosition(newSnake[0].PosHorizontal, newSnake[0].PosVertical);
                            //Move variable store the previous position of the head of the snake
                            moveVerticalForNextSegment = newSnake[0].PosVertical;
                            moveHorizontalForNextSegment = newSnake[0].PosHorizontal;
                            Console.Write(0);
                            newSnake[0].PosHorizontal = moveLeft;
                            
                            //Check to see if snake is touching itself.
                            for (int i = 1; i < newSnake.Count; i++)
                            {
                                if( newSnake[0].PosHorizontal == newSnake[i].PosHorizontal && newSnake[0].PosVertical == newSnake[i].PosVertical)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Game Over");
                                    Console.WriteLine($"score: {score}");
                                    gameOver = true;
                                    return;
                                }
                            }

                            Console.SetCursorPosition(newSnake[0].PosHorizontal, newSnake[0].PosVertical);
                            Console.Write(newSnake[0].SnakePart);
                            
                                                        
                            for (int i = 1; i < newSnake.Count; i++)
                            {
                                Console.SetCursorPosition(newSnake[i].PosHorizontal, newSnake[i].PosVertical);
                                Console.BackgroundColor = ConsoleColor.Red;
                                //Console.Write(0);
                                tempHorizontal = newSnake[i].PosHorizontal;
                                tempVertical = newSnake[i].PosVertical;
                                newSnake[i].PosHorizontal = moveHorizontalForNextSegment;
                                newSnake[i].PosVertical = moveVerticalForNextSegment;
                                Console.SetCursorPosition(newSnake[i].PosHorizontal, newSnake[i].PosVertical);
                                Console.Write(newSnake[i].SnakePart);
                                moveVerticalForNextSegment = tempVertical;
                                moveHorizontalForNextSegment = tempHorizontal;
                            }
                            score++;

                        }
                        Console.SetCursorPosition(tempHorizontal, tempVertical);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(0);

                    }
                    if ((info.Key == ConsoleKey.W || info.Key == ConsoleKey.UpArrow))
                    {
                       

                        Thread.Sleep(verticalSleep);
                        //variable used to move snake right by 1 space
                        int moveUp = 0;
                        moveUp += newSnake[0].PosVertical - 1;

                        if (newSnake[0].PosHorizontal == acrossFood && newSnake[0].PosVertical == upFood)
                        {                           
                            score += newSnake.Count;
                            newSnake.Add(new SnakeBody(upFood, acrossFood, 5));
                            Console.Write(0);
                            newSnake[0].PosVertical = moveUp;
                            Console.SetCursorPosition(newSnake[0].PosHorizontal, newSnake[0].PosVertical);
                            Console.Write(newSnake[0].SnakePart);
                            acrossFood = addFood.FoodPosHorizontal;
                            upFood = addFood.FoodPosVertical;
                            addFood.PlaceFood(acrossFood, upFood);
                        }                       
                        else
                        {
                            Console.SetCursorPosition(newSnake[0].PosHorizontal, newSnake[0].PosVertical);
                            //Move variable store the previous position of the head of the snake
                            moveVerticalForNextSegment = newSnake[0].PosVertical;
                            moveHorizontalForNextSegment = newSnake[0].PosHorizontal;
                            Console.Write(0);
                            newSnake[0].PosVertical = moveUp;
                            //Check to see if snake is touching itself.
                            for (int i = 1; i < newSnake.Count; i++)
                            {
                                if (newSnake[0].PosHorizontal == newSnake[i].PosHorizontal && newSnake[0].PosVertical == newSnake[i].PosVertical)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Game Over");
                                    Console.WriteLine($"score: {score}");
                                    gameOver = true;
                                    return;
                                }
                            }

                            Console.SetCursorPosition(newSnake[0].PosHorizontal, newSnake[0].PosVertical);
                            Console.Write(newSnake[0].SnakePart);                                                 

                            for (int i = 1; i < newSnake.Count; i++)
                            {
                                Console.SetCursorPosition(newSnake[i].PosHorizontal, newSnake[i].PosVertical);
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Write(0);
                                tempHorizontal = newSnake[i].PosHorizontal;
                                tempVertical = newSnake[i].PosVertical;
                                newSnake[i].PosHorizontal = moveHorizontalForNextSegment;
                                newSnake[i].PosVertical = moveVerticalForNextSegment;
                                Console.SetCursorPosition(newSnake[i].PosHorizontal, newSnake[i].PosVertical);
                                Console.Write(newSnake[i].SnakePart);
                                moveVerticalForNextSegment = tempVertical;
                                moveHorizontalForNextSegment = tempHorizontal;
                            }
                            score++;
                        }
                        Console.SetCursorPosition(tempHorizontal, tempVertical);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(0);


                    }
                    if ((info.Key == ConsoleKey.D || info.Key == ConsoleKey.RightArrow))
                    {
                        

                        Thread.Sleep(sleepVariable);
                        //variable used to move snake right by 1 space
                        int moveRight = 0;
                        moveRight += newSnake[0].PosHorizontal + 1;

                        if (newSnake[0].PosHorizontal == acrossFood && newSnake[0].PosVertical == upFood)
                        {
                            score += newSnake.Count;
                            newSnake.Add(new SnakeBody(upFood, acrossFood, 5));
                            Console.Write(0);
                            newSnake[0].PosHorizontal = moveRight;
                            Console.SetCursorPosition(newSnake[0].PosHorizontal, newSnake[0].PosVertical);
                            Console.Write(newSnake[0].SnakePart);
                            acrossFood = addFood.FoodPosHorizontal;
                            upFood = addFood.FoodPosVertical;
                            addFood.PlaceFood(acrossFood, upFood);
                        }                        
                        else
                        {
                            Console.SetCursorPosition(newSnake[0].PosHorizontal, newSnake[0].PosVertical);
                            //Move variable store the previous position of the head of the snake
                            moveVerticalForNextSegment = newSnake[0].PosVertical;
                            moveHorizontalForNextSegment = newSnake[0].PosHorizontal;
                            Console.Write(0);
                            newSnake[0].PosHorizontal = moveRight;
                            
                            //Check to see if snake is touching itself.
                            for (int i = 1; i < newSnake.Count; i++)
                            {
                                if (newSnake[0].PosHorizontal == newSnake[i].PosHorizontal && newSnake[0].PosVertical == newSnake[i].PosVertical)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Game Over");
                                    Console.WriteLine($"score: {score}");
                                    gameOver = true;
                                    return;
                                }
                            }
                            Console.SetCursorPosition(newSnake[0].PosHorizontal, newSnake[0].PosVertical);
                            Console.Write(newSnake[0].SnakePart);
                                                        
                            for (int i = 1; i < newSnake.Count; i++)
                            {
                                Console.SetCursorPosition(newSnake[i].PosHorizontal, newSnake[i].PosVertical);
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Write(0);
                                tempHorizontal = newSnake[i].PosHorizontal;
                                tempVertical = newSnake[i].PosVertical;
                                newSnake[i].PosHorizontal = moveHorizontalForNextSegment;
                                newSnake[i].PosVertical = moveVerticalForNextSegment;
                                Console.SetCursorPosition(newSnake[i].PosHorizontal, newSnake[i].PosVertical);
                                Console.Write(newSnake[i].SnakePart);
                                moveVerticalForNextSegment = tempVertical;
                                moveHorizontalForNextSegment = tempHorizontal;
                            }
                            score++;
                        }
                        Console.SetCursorPosition(tempHorizontal, tempVertical);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(0);


                    }
                    if ((info.Key == ConsoleKey.S || info.Key == ConsoleKey.DownArrow))
                    {
                        

                        Thread.Sleep(verticalSleep);
                        //variable used to move snake right by 1 space
                        int moveDown = 0;
                        moveDown += newSnake[0].PosVertical + 1;

                        if (newSnake[0].PosHorizontal == acrossFood && newSnake[0].PosVertical == upFood)
                        {
                            score += newSnake.Count;
                            newSnake.Add(new SnakeBody(upFood, acrossFood, 5));
                            Console.Write(0);
                            newSnake[0].PosVertical = moveDown;
                            Console.SetCursorPosition(newSnake[0].PosHorizontal, newSnake[0].PosVertical);
                            Console.Write(newSnake[0].SnakePart);
                            acrossFood = addFood.FoodPosHorizontal;
                            upFood = addFood.FoodPosVertical;
                            addFood.PlaceFood(acrossFood, upFood);
                        }                    
                        else
                        {
                            Console.SetCursorPosition(newSnake[0].PosHorizontal, newSnake[0].PosVertical);
                            //Move variable store the previous position of the head of the snake
                            moveVerticalForNextSegment = newSnake[0].PosVertical;
                            moveHorizontalForNextSegment = newSnake[0].PosHorizontal;
                            Console.Write(0);
                            newSnake[0].PosVertical = moveDown;
                            
                            //Check to see if snake is touching itself.
                            for (int i = 1; i < newSnake.Count; i++)
                            {
                                if (newSnake[0].PosHorizontal == newSnake[i].PosHorizontal && newSnake[0].PosVertical == newSnake[i].PosVertical)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Game Over");
                                    Console.WriteLine($"score: {score}");
                                    gameOver = true;
                                    return;
                                }
                            }
                            Console.SetCursorPosition(newSnake[0].PosHorizontal, newSnake[0].PosVertical);
                            Console.Write(newSnake[0].SnakePart);
                                                        
                            for (int i = 1; i < newSnake.Count; i++)
                            {
                                Console.SetCursorPosition(newSnake[i].PosHorizontal, newSnake[i].PosVertical);
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Write(0);
                                tempHorizontal = newSnake[i].PosHorizontal;
                                tempVertical = newSnake[i].PosVertical;
                                newSnake[i].PosHorizontal = moveHorizontalForNextSegment;
                                newSnake[i].PosVertical = moveVerticalForNextSegment;
                                Console.SetCursorPosition(newSnake[i].PosHorizontal, newSnake[i].PosVertical);
                                Console.Write(newSnake[i].SnakePart);
                                moveVerticalForNextSegment = tempVertical;
                                moveHorizontalForNextSegment = tempHorizontal;
                            }
                            score++;
                        }
                        Console.SetCursorPosition(tempHorizontal, tempVertical);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(0);


                    }



                }
                if(newSnake[0].PosHorizontal <= 0 || newSnake[0].PosHorizontal >= acrossMaxCoordinate || newSnake[0].PosVertical <= 0 || newSnake[0].PosVertical >= upMaxCoordinate)
                {
                    if (gameOver == true)
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over");
                        Console.WriteLine($"score: {score}");
                        Thread.Sleep(1000);
                        break;
                    }
                
                    
                }


            } while (gameLength == true);


































            //DONT FUCKING TOUCH THIS PILE OF HORSE SHIT

            //////////////////////////////int gameStart = 80;
            //////////////////////////////int tree = 0;
            ////////////////////////////////last coordinate of earlier element
            //////////////////////////////int tempVertical = 0;
            //////////////////////////////int tempHorizontal = 0;
            ////////////////////////////////coordinate of current element
            ////////////////////////////////NOT FUCKED UP
            //////////////////////////////int moveVertical = 9;
            //////////////////////////////int moveHorizontal = 4;

            //////////////////////////////while (tree < gameStart)
            //////////////////////////////{
            //////////////////////////////    ConsoleKeyInfo info = Console.ReadKey(true);


            //////////////////////////////    //set current position to temporary coordinate
            //////////////////////////////    tempHorizontal = newSnake[0].PosHorizontal;
            //////////////////////////////    tempVertical = newSnake[0].PosVertical;
            //////////////////////////////    //erase
            //////////////////////////////    Console.SetCursorPosition(tempHorizontal, tempVertical);
            //////////////////////////////    Console.Write(0);
            //////////////////////////////    //set current coordinates to movement coordinates
            //////////////////////////////    newSnake[0].PosHorizontal = moveHorizontal;
            //////////////////////////////    newSnake[0].PosVertical = moveVertical;
            //////////////////////////////    //move and print to new movement coordinates
            //////////////////////////////    Console.SetCursorPosition(newSnake[0].PosHorizontal, newSnake[0].PosVertical);
            //////////////////////////////    //Thread.Sleep(500);
            //////////////////////////////    Console.Write(newSnake[0].SnakePart);


            //////////////////////////////    for (int i = 1; i < newSnake.Count; i++)
            //////////////////////////////    {
            //////////////////////////////        //set movement coordinates to temporary coordinates
            //////////////////////////////        moveHorizontal = tempHorizontal;
            //////////////////////////////        moveVertical = tempVertical;
            //////////////////////////////        //set temporary coordinates to current coordinates
            //////////////////////////////        tempVertical = newSnake[i].PosVertical;
            //////////////////////////////        tempHorizontal = newSnake[i].PosHorizontal;
            //////////////////////////////        //erase
            //////////////////////////////        Console.SetCursorPosition(tempHorizontal, tempVertical);
            //////////////////////////////        Console.Write(0);
            //////////////////////////////        //change current coordinates to new movement coordinates
            //////////////////////////////        newSnake[i].PosHorizontal = moveHorizontal;
            //////////////////////////////        newSnake[i].PosVertical = moveVertical;
            //////////////////////////////        //print to new coordinates
            //////////////////////////////        Console.SetCursorPosition(newSnake[i].PosHorizontal, newSnake[i].PosVertical);
            //////////////////////////////        Console.Write(newSnake[i].SnakePart);

            //////////////////////////////    }
            //////////////////////////////    moveHorizontal += newSnake.Count - 1;















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



        }

    }

}


//set cursor position (Change position of the edit.
//separate classes into if is snake is not snake....
//LICEcap for making gifs

