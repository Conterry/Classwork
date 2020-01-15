
using System;

namespace ShildtExamples
{
    // Пример заполнения класса.
    class Building
    {
        public int Floors;
        public int Area;
        public int Occupants; 
    }

    class BuildingDemo
    {
        static void Main()
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
}
