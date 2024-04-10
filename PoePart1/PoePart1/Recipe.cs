using System;
using System.Linq;

namespace PoePart1
{
    public class Recipe
    {
        private Ingredients[] ingredients;
        private int numOfIngredients;

        public Recipe()
        {
            ingredients = new Ingredients[10];
            numOfIngredients = 0;
        }

        public int ShowOptions()
        {
            Console.WriteLine("Options:");
            Console.WriteLine("1. Add ingredient");
            Console.WriteLine("2. Display recipe");
            Console.WriteLine("3. Scale recipe");
            Console.WriteLine("4. Reset recipe");
            Console.WriteLine("5. Clear Data");
            Console.WriteLine("6. Exit");
            Console.WriteLine("Enter your choice:");

            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        public void AddIngredient(string name, int quantity, string unitOfMeasurement)
        {
            if (numOfIngredients < ingredients.Length)
            {
                ingredients[numOfIngredients] = new Ingredients(name, quantity, unitOfMeasurement);
                numOfIngredients++;
                Console.WriteLine("Ingredient added successfully.");
            }
            else
            {
                Console.WriteLine("Maximum capacity reached. Cannot add more ingredients.");
            }
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("Recipe:");
            for (int i = 0; i < numOfIngredients; i++)
            {
                Ingredients ingredient = ingredients[i];
                Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity} {ingredient.UnitofMeasurement}");
            }
        }

        public string ScaleRecipe()
        {
            Console.WriteLine("Enter the name of ingredient you would like to scale:");
            string response = Console.ReadLine();

            // Find the ingredient by name
            Ingredients ingredientToScale = ingredients.FirstOrDefault(ing => ing.Name.Equals(response, StringComparison.OrdinalIgnoreCase));

            if (ingredientToScale != null)
            {
                Console.WriteLine("Enter scaling factor (0.5, 2, or 3): ");
                double factor;
                if (double.TryParse(Console.ReadLine(), out factor) && (factor == 0.5 || factor == 2 || factor == 3))
                {
                    // Scale the quantity of the ingredient
                   ingredientToScale.Quantity = (int)(ingredientToScale.Quantity * factor);
                    return "Recipe scaled successfully.";
                }
                else
                {
                    return "Invalid scaling factor. Scaling factor must be 0.5, 2, or 3.";
                }
            }
            else
            {
                return "Invalid name of ingredient.";
            }
        }

        public string ResetRecipe()
        {
            Console.WriteLine("Enter the name of ingredient you would like to reset:");
            string response = Console.ReadLine();

            // Find the ingredient by name
            Ingredients ingredientToScale = ingredients.FirstOrDefault(ing => ing.Name.Equals(response, StringComparison.OrdinalIgnoreCase));

            if (ingredientToScale != null)
            { 
                for(int  i = 0;i<numOfIngredients;i++)
                {
                    ingredientToScale.Quantity = ingredientToScale.storedQuantity;
                }
            }

            
            return "Recipe reset successfully.";
        }

        public void ClearData()
        {
            ingredients = new Ingredients[10];
            numOfIngredients = 0;
            Console.WriteLine("All data cleared. Starting a new recipe...");
        }
    }
}
