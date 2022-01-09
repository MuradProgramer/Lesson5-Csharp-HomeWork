using Lesson5CsharpHW;
using System;

Cat cat1 = new Cat("Mestan", 10, "K", 30, 20.4, 1200);
Cat cat2 = new Cat("Tom", 12, "K", 50, 12.5, 1000);
Cat[] cats1 = new Cat[2] { cat1, cat2 };


Cat cat3 = new Cat("Puchu", 13, "Q", 120, 12, 1200);
Cat cat4 = new Cat("Mesi", 5, "Q", 30, 20, 700);
Cat[] cats2 = new Cat[2] { cat3, cat4 };


CatHouse catHouse1 = new(cats1, 2, "CAT HOUSE 1");
CatHouse catHouse2 = new(cats2, 2, "CAT HOUSE 2");


CatHouse[] catHouses = new CatHouse[2] { catHouse1, catHouse2 };

PetShop petShop = new PetShop(catHouses, 2);

////////////////////////////////////////////////////

//petShop.CatHouses[0].AddCat(new Cat("asdad", 12, "Q", 12, 21, 1221));
//petShop.ShowAllCats();

//petShop.CatHouses[0].AddCat(new Cat("asdad", 12, "Q", 12, 21, 1221));
//petShop.CatHouses[0].RemoveByNickName("asdad");
//petShop.ShowAllCats();

//petShop.CatHouses[0].Cats[0].ShowCat(); 
//petShop.CatHouses[0].Cats[0].Eat(20); // + energy, - meal quantity
//petShop.CatHouses[0].Cats[0].ShowCat(); 

//petShop.CatHouses[0].Cats[0].ShowCat();
//petShop.CatHouses[0].Cats[0].Sleep(1.5); // + energy
//petShop.CatHouses[0].Cats[0].ShowCat();

//petShop.CatHouses[0].Cats[0].ShowCat();
//petShop.CatHouses[0].Cats[0].Play(); // - energy
//petShop.CatHouses[0].Cats[0].ShowCat();
