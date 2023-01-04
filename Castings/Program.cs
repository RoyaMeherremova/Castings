

using Castings.Models;
using System.Xml.Linq;

Salmon salmon = new Salmon();
//Eagle eagle = new Eagle();
//Animal animal1 = eagle;
////animal1.Sound();
Animal animal2 = salmon;
Bird bird = new Bird();
Animal animal3 = new Salmon();

//salmon.Sound();
//eagle.Sound();
//Animal animal = new Animal();
//animal.Sound();
//Bird bird = new Bird();
//bird.Sound();

//Eagle eagle1 = new Eagle();
//Animal animal1 = new Animal();
//Eagle eagle2 = (Eagle)animal1;


//Eagle eagle1 = new Eagle();
//Animal animal1 = new Animal();
//Fish fish1 = new Fish();
//Bird bird1 = new Bird();
//Eagle eagle3 = (Eagle)animal1;

//Animal[] arr = { eagle1, animal1, fish1, bird1, eagle3 };
//foreach (var item in arr)
//{
//    item.Name = "XXX";
//    Console.WriteLine(item.Name);
//}


//string str = "gggg";
//object obj = str;
//string name = obj.ToString();

//int num = 55;
//object obj1 = num;
//int num3 = (int)obj1;

//bool isMarried = false;
//object obj2 = isMarried;
//bool result = (bool)obj2;


//byte num1 = 22;
//int num2 = num1;

//int num3 = 22;
//byte num4 = (byte)num3;

Bird bird1 = new Bird();
Fish fish = new Fish();
Animal animal1 = new Bird();
Animal animal = new Fish();

object[] objects = { 1, 2, "Salam", bird1, fish, animal1, animal2 };

//foreach (var item in objects)
//{
//	if (item is Animal )
//	{
//        ((Animal)item).Name = "test";
//        Console.WriteLine(((Animal)(item)).Name);
//    }
//    else
//    {
//        Console.WriteLine("Cant cast");
//    }
//}


//foreach (var item in objects)
//{
//    if (item is Animal a)
//    {
//        a.Name = "test";
//        Console.WriteLine(a.Name);
//    }
//    else
//    {
//        Console.WriteLine("Cant cast");
//    }
//}

foreach (var item in objects)
{
    Animal animal5 = item as Animal;
	if (animal5!=null)
	{
		animal5.Name = "var";
		Console.WriteLine(animal5.Name);

    }
	else
	{
		Console.WriteLine(item);
	}

}
