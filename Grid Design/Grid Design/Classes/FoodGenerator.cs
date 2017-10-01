using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid_Design.Classes
{
    class FoodGenerator
    {

        private int foodPosVertical;
        private int foodPosHorizontal;
        
        Random food = new Random();
       

        public int FoodPosVertical
        {
            get {
                this.foodPosVertical = food.Next(1, 28);
                return foodPosVertical; }
        }

        public int FoodPosHorizontal
        {
            get {
                this.foodPosHorizontal = food.Next(1, 100);
                return foodPosHorizontal; }
        }

        public void PlaceFood(int across, int up)
        {
            Console.SetCursorPosition(across, up);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
