// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

namespace PoePart1
{
    internal class Program
    {
        //main class comment
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Recpipe App");
            Console.WriteLine();

            Recipe recipe = new Recipe();

            int exit = -1;
            while (exit != 0)
            {
                int choice = recipe.ShowOptions();

                //switch case or condition function
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("How many ingredients to be used?");
                        int ingredientNumber = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < ingredientNumber; i++)
                        {
                            //promt to enter ingredient name
                            Console.WriteLine("Enter ingredient name:");
                            string ingredientName = Console.ReadLine();

                            Console.WriteLine("Enter quantity:");
                            int quantity;
                            while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
                            {
                                Console.WriteLine("Invalid quantity. Please enter a positive integer:");
                            }

                            Console.WriteLine("Enter unit of measurement:");
                            string unitOfMeasurement = Console.ReadLine();

                            recipe.AddIngredient(ingredientName, quantity, unitOfMeasurement);
                        }

                        break;
                    case 2:
                        recipe.DisplayRecipe();
                        break;
                    case 3:
                        recipe.ScaleRecipe();
                        break;
                    case 4:
                        recipe.ResetRecipe();
                        break;
                    case 5:
                        recipe.ClearData();
                        break; 
                    case 6:
                        Console.WriteLine("Exiting recipe app..");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice,please try again.");
                        break;


                }
            }
        }



    }

}
