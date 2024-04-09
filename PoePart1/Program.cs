// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

namespace PoePart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Recpipe App");
            Console.WriteLine();

            Recipe recipe = new Recipe();

            int exit = -1;
            while (exit != 0)
            {
                int choseOption = recipe.ShowOptions();

                int chosenOption = Convert.ToInt32(Console.ReadLine());
                switch (chosenOption)
                {
                    case 1:
                        Console.WriteLine("Choose an Option:");
                        break;
                    case 2:
                        recipe.AddIngredient();
                        break;
                    case 3:
                        Console.WriteLine();
                        recipe.DisplayRecipe();
                        Console.ResetColor();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine(recipe.ScaleRecipe());
                        Console.WriteLine();
                        recipe.DisplayRecipe();
                        Console.ResetColor();
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine(recipe.ScaleRecipe());
                        Console.WriteLine();
                        recipe.DisplayRecipe();
                        Console.ResetColor();
                        Console.WriteLine();
                        break;
                    case 6:
                        recipe.ClearData();
                        break;
                    case 7:
                        exit = 0;
                        Console.WriteLine("Exiting recipe app..");
                        break;
                    default:
                        Console.WriteLine("Invalid choice,please try again.");
                        break;


                }
            }
        }



    }

}

