using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1
{
	internal class Program
	{
		static string userOption;

		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.Green;


			Console.WriteLine("=====Welcome to The Recipe Writer=====");
			
			while (true)
			{

				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("==============Main Menu=================");
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("\n1 - Enter details for single RECIPE:"
								 + "\n2 - Display Recipe"
								 + "\n3 - Request recipe is scaled"
								 + "\n4 - Request quantity reset"
								 + "\n5 - Enter new recipe"
								 );

				string userOption = Console.ReadLine();

			    Recipe rec = new Recipe();

				switch (userOption)
				{

					case "1":
						//call method to get recipe details
						rec.getRecipe();

						break;
					case "2":
						//call method to display recipe details
						rec.displayRecipe();
						;
						break;
					case "3":
						//call method scale recipe
						rec.scaleRecipe();
						break;
					case "4":
						//call method to reset and enter new recipe
						rec.quantityReset();
						break;

				}
			}

		}
	}
}
	

