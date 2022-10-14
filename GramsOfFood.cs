using System.Threading;

namespace BonAppetit
{
    public class GramsOfFood
    {
        static public int sumOfGrams { get; set; } 
        public GramsOfFood(int g = 0, string name = "")
        {
            Grams = g;
            FoodName = name != "" ? " - " + name : "";
        }
        public int Grams { get; set; }
        public string FoodName { get; set; }
    }
}
