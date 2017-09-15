using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid_Design
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] numbers2D = new int[10, 40];

            //numbers2D[3, 6] = 7;
            int xPoint = 4;
            int yPoint = 4;
            // end case value =5;
            //put this ALL in a 2 dimensional array while loop till END condition.
            // print grid
            int n = 200;
            //test game
            for (int j = 0; j < n; j++)
            {

                

                numbers2D[xPoint, yPoint] = 1;
                //test case

                for (int i = 0; i < numbers2D.GetLength(0); i++)
                {
                    //loops through each row
                    for (int k = 0; k < numbers2D.GetLength(1); k++)
                    {

                        //set cursor position (Change position of the edit.
                        //separate classes into if is snake is not snake....
                        //LICEcap for making gifs


                        if (numbers2D[i, k] == 0)
                        {
                            //put a single value
                            numbers2D[i, k] = 0;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(numbers2D[i, k]);
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.Write(numbers2D[i, k]);
                        }
                        // Take a key handler and change values based on the key that is changed
                        //if (Console.ReadKey == )


                    }
                    //next row
                    Console.WriteLine();
                }

                Console.WriteLine("Move Direction?");
                string input = Console.ReadLine();
                if (input == "s")
                {
                    if (xPoint + 1 < 0 || xPoint + 1 > 9)
                    {
                        Console.WriteLine("YOU LOSE!");
                        return;
                    }
                    numbers2D[(xPoint), yPoint] = 0;
                    numbers2D[(xPoint + 1), yPoint] = 1;
                    xPoint++;



                } else if (input == "w")
                {
                    if (xPoint -1 < 0 || xPoint - 1 > 10)
                    {
                        Console.WriteLine("YOU LOSE!");
                        return;
                    }
                    numbers2D[(xPoint), yPoint] = 0;
                    numbers2D[(xPoint - 1), yPoint] = 1;
                    xPoint--;


                }
                else if (input == "a")
                {
                    if (yPoint - 1 < 0 || yPoint - 1 > 39)
                    {
                        Console.WriteLine("YOU LOSE!");
                        return;
                    }

                    numbers2D[(xPoint), yPoint] = 0;
                    numbers2D[(xPoint), yPoint -1] = 1;
                    yPoint--;
                }
                else if (input == "d")
                {
                    if (yPoint + 1 < 0 || yPoint + 1 > 39)
                    {
                        Console.WriteLine("YOU LOSE!");
                        return;
                    }
                    numbers2D[(xPoint), yPoint] = 0;
                    numbers2D[(xPoint), yPoint + 1] = 1;
                    yPoint++;
                }

                


            }

        }

    }
}
