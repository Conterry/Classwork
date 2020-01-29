
using System;

namespace ShildtExamples
{
    // (Example 1)Пример заполнения класса.
    class Building
    {
        public int Floors;
        public int Area;
        public int Occupants; 
    }

    class BuildingDemo
    {
        static void mein()
        {
            Building house = new Building();
            int areaPP;

            house.Occupants = 4;
            house.Area = 2500;
            house.Floors = 2;

            areaPP = house.Area / house.Occupants;  
            Console.WriteLine(areaPP);
        }
    }

    //(Example 2)trenning exersize with Classes

    class Sup
    {
        public int Kartoshka;
        public int Voda;
        public int Svekla;
    }

    class SupInfo
    {
        public static void SupBorch()
        {
            Sup borch = new Sup();

            borch.Kartoshka = 100;
            borch.Voda = 200;
            borch.Svekla = 50;
            Console.WriteLine("You need buy...");
            Console.Write("Kartoshka - "); Console.WriteLine(borch.Kartoshka);
            Console.Write("Voda - "); Console.WriteLine(borch.Voda);
            Console.Write("Svekla - "); Console.WriteLine(borch.Svekla);
        }

        public static void SupVermeshelka()
        {
            Sup vermeshel = new Sup();
            
            vermeshel.Kartoshka = 150;
            vermeshel.Voda = 300;
            vermeshel.Svekla = 0;
            Console.WriteLine("You need buy...");
            Console.Write("Kartoshka - "); Console.WriteLine(vermeshel.Kartoshka);
            Console.Write("Voda - "); Console.WriteLine(vermeshel.Voda);
            Console.Write("Svekla - "); Console.WriteLine(vermeshel.Svekla);

        }
    }

    class Do
    {
        static void Main()
        {
            Console.WriteLine("What do you want to cook?");
            Console.WriteLine("Borch or Vermeshel Sup?");
            string cook = Console.ReadLine();
            if(cook == "Borch")
            {
                SupInfo.SupBorch();
            }
            if(cook == "Vermeshel Sup")
            {
                SupInfo.SupVermeshelka();
            }
        }
    }
}
