using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5CsharpHW
{
    class CatHouse
    {
        public string Name { get; set; }

        public Cat[] Cats { get; set; }

        public int CatsCount { get; set; }

        public CatHouse(Cat[] cats, int catsCount, string name)
        {
            Name = name;
            Cats = cats;
            CatsCount = catsCount;
        }
        
        public void AddCat(Cat newcat)
        {
            Cat[] newcats = new Cat[CatsCount + 1];
            newcats[CatsCount] = newcat;
            for (int i = 0; i < CatsCount; i++)
            {
                newcats[i] = Cats[i];
            }
            CatsCount++;
            Cats = newcats;
        }

        public void RemoveByNickName(string nickname)
        {
            if (Cats == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You Cant Remove Any Cat, Because There arn't any cat in Cat House.");
                return;
            }

            Cat[] newcats = new Cat[CatsCount - 1];
            for (int i = 0, k = 0; i < CatsCount; i++)
            {
                if (nickname == Cats[i].Nickname)
                {
                    continue;
                }
                newcats[k++] = Cats[i];
            }
            Cats = newcats;
            CatsCount--;
        }

        public void ShowCats()
        {
            foreach (var cat in Cats)
            {
                cat.ShowCat();
            }
        }
    }
}
