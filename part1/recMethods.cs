using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1
{
	internal class recMethods
	{

		class Ingredient
		{
			public string[] ingredientName;
			public double[] quantities;
			public string[] unit;
		}

		class Recipe
		{

			private int numIngredients;
			private string[] ingredients;
			private double[] quantity;
			private string[] units;
			private int numSteps;
			private string[] steps;
			private double factor;

			public Recipe()
			{
				ingredients = new string[0];
				quantity = new double[0];
				units = new string[0];
				steps = new string[0];
			}


			public void getRecipe()
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("====USER RECIPE INPUT====");
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("Enter number of Ingredients : ");
				int ingredientsNum = int.Parse(Console.ReadLine());

				ingredients = new string[ingredientsNum];
				quantity = new double[ingredientsNum];
				units = new string[ingredientsNum];

				for (int x = 0; x < ingredientsNum; x++)
				{
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine(">>>>>>>>>> Ingredient Details  <<<<<<<<<<<");
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine("Recipe Name:");
					Console.ReadLine();
					Console.WriteLine($"Ingredient no.{x + 1}");
					Console.Write("Ingredient name: ");
					ingredients[x] = Console.ReadLine();
					Console.WriteLine("Quantity: ");
					quantity[x] = double.Parse(Console.ReadLine());
					Console.WriteLine("Unit of measurement: ");
					units[x] = Console.ReadLine();
					Console.ReadLine();

				}
				Console.Write("Enter number of steps for recipe:");
				int numSteps = int.Parse(Console.ReadLine());
				steps = new string[numSteps];
				for (int x = 0; x < numSteps; x++)
				{
					Console.WriteLine($"Step no.{x + 1}: ");
					steps[x] = Console.ReadLine();
				}

				
			}

			public void displayRecipe()
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Recipe Ingredients: ");
				for (int x = 0; x < numIngredients; x++)
				{

					Console.WriteLine(quantity[x]  + units[x] + ingredients[x]);

				}
				;
			}

			public void scaleRecipe()
			{
				for (int x = 0; x < quantity.Length; x++)
				{
					quantity[x] *= factor;
				}
				
			}
			public void quantityReset()
			{

				
			}
			public void exit()
			{
				Console.ReadLine();
			}
		}
	} }
