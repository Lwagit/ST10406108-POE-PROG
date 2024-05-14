namespace RecipeApp.RecipeApp
{
    //ingredient class
    internal class Ingredient
    {
            public string Name { get; }
            public double Quantity { get; }
            public string Unit { get; }
            public string FoodGroup { get; }
            public int Calories { get; }

        //ingredient method
            public Ingredient(string name, double quantity, string unit, string foodGroup, int calories, string steps)
            {
                Name = name;
                Quantity = quantity;
                Unit = unit;
                FoodGroup = foodGroup;
                Calories = calories;
            }

        //override
            public override string ToString()
            {
                return $"{Quantity} {Unit} of {Name} ({FoodGroup}, {Calories} calories)";
            }
        

    }
}