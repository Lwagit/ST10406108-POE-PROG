// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoePart1
{
    public class Ingredients
    {
        public string Name { get; set; }

        public int Quantity { get; set; }
        public string UnitofMeasurement { get; }
        public string unitOfMeasurement { get; set; }

        public Ingredients(string name, int quantity, string unitOfMeasurement)
        {
            Name = name;
            Quantity = quantity;
            UnitofMeasurement = unitOfMeasurement;
        }

    }
}