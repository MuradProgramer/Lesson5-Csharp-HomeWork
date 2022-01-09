using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5CsharpHW
{
    class PetShop
    {

        public CatHouse[] CatHouses { get; set; }

        public int CountCatHouse { get; set; }

        public PetShop(CatHouse[] catHouses, int countCatHouse)
        {
            CatHouses = catHouses;
            CountCatHouse = countCatHouse;
        }

        public void ShowAllCats()
        {
            for (int i = 0; i < CountCatHouse; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\t\t\t CAT HOUSE: {CatHouses[i].Name}\n");
                CatHouses[i].ShowCats();
                Console.ResetColor();
            }
        }
    }
}
