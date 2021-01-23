using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner2._0
{
    class City
    {
        public string Name { get; set; }
        public string Mayor { get; set; }
        public List<Building> Buildings { get; set; } = new List<Building>();

        public int YearEstablished = 2021;

        public City(string name, string mayor)
        {
            Name = name;
            Mayor = mayor;
        }

        public void AddBuilding(Building building)
        {
            Buildings.Add(building);
        }
    }
}
