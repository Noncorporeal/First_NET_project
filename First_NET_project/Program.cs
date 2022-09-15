using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_NET_project
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter your name: ");
			string name = Console.ReadLine();
			Console.Write("Enter your location: ");
			string location = Console.ReadLine();

			Console.WriteLine($"My name is {name}, I am from {location}");
			DateTime date = DateTime.Now;
			Console.WriteLine($"Today's date is {date.ToString("d")}");
			DateTime christmas = new DateTime(2022, 12, 25);
			Console.WriteLine("There are {0} days till Christmas!", (christmas - date).TotalDays);


			double width, height, woodLength, glassArea;
			string widthString, heightString;
			Console.Write("Width Input:");
			widthString = Console.ReadLine();
			
			width = double.Parse(widthString);
			Console.Write("Height Input: ");
			heightString = Console.ReadLine();

			height = double.Parse(heightString);
			woodLength = 2 * (width + height) * 3.25;
			glassArea = 2 * (width * height);

			Console.WriteLine("The length of the wood is " +
			woodLength + " feet");

			Console.WriteLine("The area of the glass is " +
			glassArea + " square metres");

			Console.WriteLine("Press Enter to Exit...");
			while (Console.ReadKey().Key != ConsoleKey.Enter) { }

		}
	}
}
