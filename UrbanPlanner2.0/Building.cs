using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner2._0
{
    class Building
    {
        //Private Properties
        private string _designer { get; set; }
        private DateTime _dateConstructed { get; set; } = DateTime.Now;
        private string _address { get; set; }
        private string _owner { get; set; }
        //Public Properties
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume => Width * Depth * (3 * Stories);

        //Constructor
        public Building(string address)
        {
            _address = address;
        }

        //Public Methods
        public DateTime Construct() => _dateConstructed;

        public string Purchase(string owner) => _owner = owner;

        public string Designer(string designer) => _designer = designer;

        public string Address() => _address;
        public string Designer() => _designer;
        public string Owner() => _owner;
    }
}