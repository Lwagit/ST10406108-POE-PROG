// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoePart1
{
    public class Recipe
    {
        private Ingredients[] ingredients;
        private Steps[] steps;
        private int numOfIngredients;
        private int numOfSteps;

        public Recipe()
        {
            ingredients = new Ingredients[10];
            steps = new Steps[10];
        }

        public int ShowOptions()
        {
            Console.WriteLine("Options:");
            Console.WriteLine("1.Add ingredient:");
            Console.WriteLine("2.Display recipe:");
            Console.WriteLine("3.Scale recipe:");
            Console.WriteLine("4.Reset recipe:");
            Console.WriteLine("5.Clear Data:");
            Console.WriteLine("6.Exit:");
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
                Ingredients ingredient = ingredients[i]; // Get the current ingredient
                Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity} {ingredient.unitOfMeasurement}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < numOfSteps; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i].Description}");
            }
        }

        public string ScaleRecipe()
        {
            Console.WriteLine("Enter scaling factor (0.5, 2, or 3): ");
            double factor = double.Parse(Console.ReadLine());

            foreach (Ingredients ingredient in ingredients)
            {
                ingredient.Quantity = (int)(ingredient.Quantity * factor);
            }

            return "Recipe scaled successfully.";
        }

        public string ResetRecipe()
        {
            ingredients = new Ingredients[10];
            steps = new Steps[10];
            numOfIngredients = 0;
            numOfSteps = 0;

            return "Recipe reset succesfully.";
        }

        public void ClearData()
        {
            ingredients = new Ingredients[10];
            steps = new Steps[10];
            numOfIngredients = 0;
            numOfSteps = 0;

            Console.WriteLine("All data cleared. Starting a new recipe...");
        }
    }
}
