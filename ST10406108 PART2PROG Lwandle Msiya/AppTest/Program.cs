using System;
using System.Collections.Generic;

namespace RecipeApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace RecipeApp
    {
        //RecipeApp class
        public class RecipeApp
        {
            private static List<Recipe> _recipes = new List<Recipe>();

            //welcome message to app
            public static void Main()
            {
                Console.WriteLine("Welcome to the Recipe App!");

                while (true)
                {
                    DisplayMainMenu();
                }
            }

            //menu display
            private static void DisplayMainMenu()
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add a new recipe");
                Console.WriteLine("2. Display all recipes");
                Console.WriteLine("3. Exit");

                int choice = GetIntegerInput("Enter your choice (1-3): ", 1, 3);
                //switch case
                switch (choice)
                {
                    case 1:
                        CreateNewRecipe();
                        break;

                    case 2:
                        DisplayAllRecipes();
                        break;

                    case 3:
                        Console.WriteLine("Exiting the Recipe App. Goodbye!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }


            //entering details of recipe
            private static void CreateNewRecipe()
            {
                Console.WriteLine("\nEnter details for the new recipe:");

                string recipeTitle = GetStringInput("Enter recipe title: ");
                Recipe newRecipe = new Recipe(recipeTitle, new List<Ingredient>());

                while (true)
                {
                    Ingredient newIngredient = CreateNewIngredient();
                    newRecipe.Ingredients.Add(newIngredient);

                    if (!GetYesNoInput("Add another ingredient? (yes/no): "))
                        break;
                }

                _recipes.Add(newRecipe);
                Console.WriteLine("Recipe added successfully!");
            }

            //entering ingredients
            private static Ingredient CreateNewIngredient()
            {
                Console.WriteLine("\nEnter details for the ingredient:");

                string ingredientName = GetStringInput("Enter ingredient name: ");
                double ingredientQuantity = GetDoubleInput("Enter ingredient quantity: ");
                string ingredientUnit = GetStringInput("Enter ingredient unit: ");
                string foodGroup = GetStringInput("Enter food group: ");
                int calories = GetIntegerInput("Enter calories: ", 0);
                string steps = GetStringInput("Enter steps:");

                return new Ingredient(ingredientName, ingredientQuantity, ingredientUnit, foodGroup, calories , steps);
            }

            //display of recipes
            private static void DisplayAllRecipes()
            {
                Console.WriteLine("\nAll Recipes:");
                foreach (var recipe in _recipes)
                {
                    Console.WriteLine(recipe);
                }
            }

            //string input
            private static string GetStringInput(string prompt)
            {
                Console.Write(prompt);
                return Console.ReadLine();
            }

            //double int input
            private static double GetDoubleInput(string prompt)
            {
                while (true)
                {
                    Console.Write(prompt);
                    if (double.TryParse(Console.ReadLine(), out double result))
                        return result;

                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            //integer input
            private static int GetIntegerInput(string prompt, int minValue, int maxValue = int.MaxValue)
            {
                while (true)
                {
                    Console.Write(prompt);
                    if (int.TryParse(Console.ReadLine(), out int result) && result >= minValue && result <= maxValue)
                        return result;

                    Console.WriteLine($"Invalid input. Please enter a valid integer between {minValue} and {maxValue}.");
                }
            }

            //'yes or no' input
            private static bool GetYesNoInput(string prompt)
            {
                while (true)
                {
                    Console.Write(prompt);
                    string input = Console.ReadLine().Trim().ToLower();

                    if (input == "yes")
                        return true;
                    else if (input == "no")
                        return false;
                    else
                        Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                }
            }
        }
    }
}
