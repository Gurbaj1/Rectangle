using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENG8040_A1
{
	class Program
	{
		public static int ValidateMenuSelection()
		{
			string userInput = "";
			bool validMenuSelect = false;

			while (validMenuSelect == false)
			{
				Console.WriteLine("1 = Get Rectangle Length");
				Console.WriteLine("2 = Change Rectangle Length");
				Console.WriteLine("3 = Get Rectangle Width");
				Console.WriteLine("4 = Change Rectangle Width");
				Console.WriteLine("5 = Get Rectangle Perimeter");
				Console.WriteLine("6 = Get Rectangle Area");
				Console.WriteLine("7 = Exit\n");

				Console.WriteLine("Please select an option, by entering a number:\n");
				userInput = Console.ReadLine();

				if (userInput != "1" &&
					userInput != "2" &&
					userInput != "3" &&
					userInput != "4" &&
					userInput != "5" &&
					userInput != "6" &&
					userInput != "7")
				{
					Console.WriteLine("That's not a valid menu option, please try again:\n");
				}
				else
				{
					validMenuSelect = true;
				}
			}

			Console.WriteLine();
			return int.Parse(userInput);
		}

		public static int ValidateUserInput(string rectside)
		{
			int Number = 1;
			bool isValid = false;

			while (isValid == false)
			{
				Console.WriteLine($"Please enter the {rectside} of your rectangle: ");
				string userInput = Console.ReadLine();
				Console.WriteLine();

				bool result = int.TryParse(userInput, out Number);

				if (result == false)
				{
					Console.WriteLine("That's not a valid input please, please try again.\n");
				}
				else if (Number < 0)
				{
					Console.WriteLine("Number cannot be less than 0 please try again.\n");
				}

				else
				{
					isValid = true;
					Console.WriteLine($"Your new {rectside} is : {Number}.\n");
				}
			}

			return Number;
		}
		static void Main(string[] args)
		{
			Rectangle r = new Rectangle();
			bool validRectangleselect = false;
			string rectselection;
			int selection;

			while (validRectangleselect == false)
			{
				Console.WriteLine("1 = Create default rectangle\n");
				Console.WriteLine("2 = Create custom rectangle\n");
				Console.WriteLine("Choose a menu item to begin:");
				rectselection = Console.ReadLine();
				Console.WriteLine();

				if (rectselection != "1" && rectselection != "2")
				{
					Console.WriteLine("That's not a valid selection, please try again.\n");
				}
				else if (int.Parse(rectselection) == 1)
				{
					validRectangleselect = true;
					int length = 1;
					int width = 1;
					Console.WriteLine($"Your length and width are {length} and {width}.\n");
					Rectangle customRectangle = new Rectangle(length, width);
					r = customRectangle;
				}
				else if (int.Parse(rectselection) == 2)
				{
					validRectangleselect = true;

					int length;
					int width;

					length = ValidateUserInput("length");
					width = ValidateUserInput("width");

					Console.WriteLine($"Your custom numbers are {length} and {width}.\n");
					Rectangle customRectangle = new Rectangle(length, width);
					r = customRectangle;
				}
			}
			selection = ValidateMenuSelection();

			while (selection != 7)
			{
				int result;

				switch (selection)
				{
					case 1:
						Console.WriteLine($"Length is : {r.Getlength()}\n");
						break;
					case 2:
						result = ValidateUserInput("length");
						r.Setlength(result);
						break;
					case 3:
						Console.WriteLine($"width is : {r.Getwidth()}\n");
						break;
					case 4:
						result = ValidateUserInput("width");
						r.Setwidth(result);
						break;
					case 5:
						Console.WriteLine($"Perimeter {r.Getlength() * 2} + {r.Getwidth() * 2} is: {r.Getperimeter()}\n");
						break;
					case 6:
						Console.WriteLine($"Area {r.Getlength()} * {r.Getwidth()} is: {r.Getarea()}\n");
						break;
					default:
						break;
				}

				selection = ValidateMenuSelection();
			}
		}
	}
}


