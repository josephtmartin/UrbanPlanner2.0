using System;

namespace UrbanPlanner2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building1 = new Building("1234 1st Avenue")
            {
                Width = 500,
                Depth = 250,
                Stories = 5,
            };
            Building building2 = new Building("4321 Katherine Court")
            {
                Width = 1000,
                Depth = 500,
                Stories = 25,
            };
            Console.WriteLine($"{building1.Address()}");
            Console.WriteLine($"Designed by {building1.Designer("Liz Barnes")}");
            Console.WriteLine($"Constructed on {building1.Construct()}");
            Console.WriteLine($"Owned by {building1.Purchase("Joseph Martin")}");
            Console.WriteLine($"{building1.Volume} cubic meters of space");
            Console.WriteLine();
            Console.WriteLine($"{building2.Address()}");
            Console.WriteLine($"Designed by {building2.Designer("Kaitlyn VanHook")}");
            Console.WriteLine($"Constructed on {building2.Construct()}");
            Console.WriteLine($"Owned by {building2.Purchase("Rob Bandstra")}");
            Console.WriteLine($"{building2.Volume} cubic meters of space");
            Console.WriteLine();
            //Urban Planner 2.0 City
            City megalopolis = new City("megalopolis", "Jerry Gergich");

            megalopolis.AddBuilding(building1);
            megalopolis.AddBuilding(building2);

            foreach (Building building in megalopolis.Buildings)
            {
                Console.WriteLine($"{building.Address()}\nDesigned by {building.Designer()}\nConstruced on {building.Construct()}\nOwned by {building.Owner()}\n{building.Volume} cubic meters of space");
                Console.WriteLine();
            }
        }
    }
}
