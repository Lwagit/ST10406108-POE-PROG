using System;
using System.Linq;

namespace PoePart1
{
    //class for recipe
    public class Recipe
    {
        private Ingredients[] ingredients;
        private int numOfIngredients;

        //method for recipe
        public Recipe()
        {
            ingredients = new Ingredients[10];
            numOfIngredients = 0;
        }

        //program menu
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

        //method to store or add ingredients
        public void AddIngredient(string name, int quantity, string unitOfMeasurement)
        {
            //if statement for adding ingredients
            if (numOfIngredients < ingredients.Length)
            {
                ingredients[numOfIngredients] = new Ingredients(name, quantity, unitOfMeasurement);
                numOfIngredients++;
                Console.WriteLine("Ingredient added successfully.");
            }
            else
            {
                //else statement that sends message that says cannot add anymore ingredients
                Console.WriteLine("Maximum capacity reached. Cannot add more ingredients.");
            }
        }

        //method to display recipe
        public void DisplayRecipe()
        {
            Console.WriteLine("Recipe:");
            for (int i = 0; i < numOfIngredients; i++)
            {
                Ingredients ingredient = ingredients[i];
                Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity} {ingredient.UnitofMeasurement}");
            }
        }

        //scale method
        public string ScaleRecipe()
        {
            //input ingredient name 
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
                    //message returned if scaled wrong
                    return "Invalid scaling factor. Scaling factor must be 0.5, 2, or 3.";
                }
            }
            else
            {
                
                return "Invalid name of ingredient.";
            }
        }

        //reset method
        public string ResetRecipe()
        {
            //prompt to enter ingredients
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

            //messeage displayed if recipe reset succesfully
            return "Recipe reset successfully.";
        }

        //method to clear all the recipe data

        public void ClearData()
        {
            ingredients = new Ingredients[10];
            numOfIngredients = 0;
            Console.WriteLine("All data cleared. Starting a new recipe...");
            //above,is the message displayed when all recipe data has been cleared
        }
    }
}
