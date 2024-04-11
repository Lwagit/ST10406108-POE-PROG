// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

//main program
namespace PoePart1
{
    //class for Program
    internal class Program
    {
        //main class comment
        static void Main(string[] args)
        {
            //display welcome message of recipe program
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

                            //promt to enter quantity
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

                    case 2://
                        recipe.StepDescription();
                        break;

                    case 3:
                        //case for displaying the recipe
                        recipe.DisplayRecipe();
                        break;
                    case 4:
                        //case for Scale of recipe
                        recipe.ScaleRecipe();
                        break;
                    case 5:
                        //case for Reset
                        recipe.ResetRecipe();
                        break;
                    case 6:
                        //case for clearing the recipe data
                        recipe.ClearData();
                        break; 
                    case 7:
                        //case for exiting the recipe program
                        Console.WriteLine("Exiting recipe app..");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice,please try again.");
                        break;
                    //all above are the program options

                }
            }
        }



    }

}
