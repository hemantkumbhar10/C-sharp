using System;

namespace SqaureOfSquare { 
	class Square
	{
		static void Main()
		{
			Console.WriteLine("Enter side of the square");
			string sSide = Console.ReadLine();       
			int side = int.Parse(sSide);                    //converts string to int
			float square = side * side;
			Console.WriteLine(square);
		}
	}
};