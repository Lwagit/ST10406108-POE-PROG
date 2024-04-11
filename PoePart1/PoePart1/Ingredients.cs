namespace PoePart1
{
    //class for ingredients
    public class Ingredients
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string UnitofMeasurement { get; set; }

        public int storedQuantity { get; set; }

        public Ingredients(string name, int quantity, string unitOfMeasurement)
        {
            Name = name;
            storedQuantity = quantity;
            Quantity = quantity;
            UnitofMeasurement = unitOfMeasurement;
        }
    }
}
