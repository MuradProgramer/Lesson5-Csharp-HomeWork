using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lesson5CsharpHW
{
    class Cat
    {
        public string Nickname { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public int Energy { get; set; }

        public double Price { get; set; }

        public int MealQuantity { get; set; }

        public Cat(string nickname, int age, string gender, int energy, double price, int mealQuantity)
        {
            Nickname = nickname;
            Age = age;
            Gender = gender;
            Energy = energy;
            Price = price;
            MealQuantity = mealQuantity;
        }

        public void Play()
        {
            if (Energy - 10 < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(1000);
                Console.WriteLine("------------- The cat has no energy. It needs to sleep!! -------------");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Energy -= 10;
                Thread.Sleep(1000);
                Console.WriteLine("____________ THE CAT WAS PLAYED ____________");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Eat(int mealcount)
        {
            if (MealQuantity - mealcount < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(500);
                Console.WriteLine("----------- C A T   H A S N'T   M E A L!! -----------");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                MealQuantity -= mealcount;
                Energy += 2 * mealcount;
                Thread.Sleep(500);
                Console.WriteLine("___________ C A T   E A T E D   S U C C E S F U L Y ___________");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Sleep(double seconds)
        {
            Thread.Sleep((int)(seconds * 1000));
            Energy += (int)(seconds * 10);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("___________ C A T   W A S   S L E E P E D ___________");
        }

        public void ShowCat()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("------------------------------------------ CAT ------------------------------------------");
            Console.WriteLine($"NickName: {Nickname}  |  Age: {Age}  |  Gender: {Gender}  |  Energy: {Energy}  |  Price: {Price}  |  Meal Quantity: {MealQuantity}");
            Console.WriteLine("-----------------------------------------------------------------------------------------\n");
        }
    }
}
