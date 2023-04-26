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
			//colour for heading
			Console.ForegroundColor = ConsoleColor.Green;


			Console.WriteLine("=====Welcome to The Recipe Writer=====");
			//while loop to run menu until the wrong condition is entered 
			while (true)
			{

				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("==============Main Menu=================");
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("\n1 - Enter details for single RECIPE:"
								 + "\n2 - Display Recipe"
								 + "\n3 - Request recipe is scaled"
								 + "\n4 - Request quantity reset"
								 + "\n5 - Clear recipe"
								 + "\n6 - Exit"
								 );

				string userOption = Console.ReadLine();
				//created an object for external class
			    Recipe rec = new Recipe();
				//switch case to check user option in menu
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
					case "5":
						// call method to clear recipe
						rec.clearRecipe();
						break;
					case "6":
						// exit 
						Console.WriteLine("Closing Application");
						return;
					default:
						//Invalid option
						Console.WriteLine("Invalid Option, Try again!!!!");
						break;
				}
			}

		}
	}
}
	

