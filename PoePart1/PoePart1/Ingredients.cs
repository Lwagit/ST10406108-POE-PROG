﻿namespace PoePart1
{
    //class for ingredients
    public class Ingredients
    {
        //declaring getters and setters
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string UnitofMeasurement { get; set; }

        public int storedQuantity { get; set; }

        //constructor for ingredients of recipe
        public Ingredients(string name, int quantity, string unitOfMeasurement)
        {
            Name = name;
            storedQuantity = quantity;
            Quantity = quantity;
            UnitofMeasurement = unitOfMeasurement;
        }
    }
}
