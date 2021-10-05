using System;
using System.Data;
using System.Text;

namespace Adec_Practical_Exam
{
    class Program
    {
        #region Main
        public static void Main(string[] args)
        {
			bool menu = true;
			do
			{
				menu = MenuSelection();
			} while (menu);

		}
        #endregion

        #region Menu Layout
        private static bool MenuSelection()
        {
			Console.Clear();
			Console.WriteLine("=============================");
			Console.WriteLine("=   Menu - Practical Exam   =");
			Console.WriteLine("=============================");
			Console.WriteLine("\n 1 - Reverse Numbers ");
			Console.WriteLine("\n 2 - Multiplication Table");
			Console.WriteLine("\n 3 - Decimal to Binary using Recursion");
			Console.WriteLine("\n 4 - Permutation Sort ");
			Console.WriteLine("\n 5 - Hollow Rectangle ");
			Console.WriteLine("\n 6 - Diamond Pattern");
			Console.WriteLine("\n 7 - Convert Number to Words");
			Console.WriteLine("\n 8 - MDAS ");
			Console.WriteLine("\n 0 - Close");
			Console.Write("\nSelect number from menu: ");
			var choice = Console.ReadLine();
			bool counter = true;
			
			switch (choice)
			{
				case "1":
					ReverseArray(counter);
					break;
				case "2":
					MultiplicationTable(counter);
					break;
				case "3":
					DecimalToBinaryRecursion(counter);
					break;
				case "4":
					ListPermutationSort(counter);
					break;
				case "5":
					HollowRectangle(counter);
					break;
				case "6":
					DiamondPattern(counter);
					break;
				case "7":
					NumberToWords(counter);
					break;
				case "8":
					MDAS(counter);
					break;
				case "0":
					counter = false;
					break;
				default:
					counter = true;
					break;
			}

			return counter;

        }

        #endregion

        #region Main Menu Methods
        /*
			[MPCS 04-10-2021]: This method will reverse the given 5 numbers.
		*/
        private static void ReverseArray(bool retry)
        {
            while (retry)
            {
				Console.Clear();
				Console.WriteLine("=============================");
				Console.WriteLine("=       Reverse Numbers	   =");
				Console.WriteLine("=============================");

				Console.Write("\nInstruction: Create a program to ask the user for 5 numbers" +
					", store them in an array and show them in reverse order.");

				Console.Write("\n\nEnter 5 numbers to reverse: ");
				var number = Console.ReadLine();
				
				//Validates number length given by user.
                if (number.Length != 5)
                {
					Console.WriteLine("\nPlease enter 5 numbers.");
                }
				else if (number.Length == 5)
                {
					char[] numberArray = number.ToCharArray();
					// Reverses one dimentional array in sequence 
					Array.Reverse(numberArray);

					//Output result
					Console.WriteLine("\nReverse is: {0}", String.Concat(numberArray)); 
				}
				
				//Retry or exit back to menu
				Console.Write("\n\nTry again? (y/n): ");
				retry = Console.ReadLine().ToLower() == "y" ? true : false;
			}
			

		}

		/*
			[MPCS 04-10-2021]: This method will display multiplication table from 1 to any number given by user.
		*/
		private static void MultiplicationTable(bool retry)
		{
			while (retry)
			{
				Console.Clear();
				Console.WriteLine("=================================");
				Console.WriteLine("=       Multiplication Table	   =");
				Console.WriteLine("=================================");
				Console.Write("\nInstruction: Write a program in C# to display the multiplication table vertically from 1 to n.");

                try
                {
					Console.Write("\n\nEnter up to the table number starting from 1: ");
					var endNumber = Convert.ToInt32(Console.ReadLine());

					//Create table
					Console.Write("\nMultiplication table from 1 to {0} \n", endNumber);
					for (int rows = 1; rows <= endNumber; rows++)
					{
						Console.Write("\n");
						for (int cols = 1; cols <= endNumber; cols++)
						{
							if (cols <= endNumber - 1)
								Console.Write("{0}x{1} = {2}, ", cols, rows, rows * cols);
							else
								Console.Write("{0}x{1} = {2}", cols, rows, rows * cols);

						}
					}
				}
                catch (Exception)
                {
					Console.WriteLine("\nInvalid input!");
                }
				

				//Retry or exit back to menu
				Console.Write("\n\nTry again? (y/n): ");
				retry = Console.ReadLine().ToLower() == "y" ? true : false;
			}
		}

		/*
			[MPCS 04-10-2021]: This method will convert decimal input to binary value.
		*/
		private static void DecimalToBinaryRecursion(bool retry)
        {
			while (retry)
			{
				Console.Clear();
				Console.WriteLine("=================================================");
				Console.WriteLine("=       Decimal to Binary using Recursion	  =");
				Console.WriteLine("=================================================");
				Console.Write("\nInstruction: Write a program in C# to convert a decimal number to binary using recursion.");

                try
                {
					Console.Write("\n\nEnter a decimal number: ");
					int input = Convert.ToInt32(Console.ReadLine());

					//Call method to output decimal to binary converted value
					Console.WriteLine("The binary equivalent of {0} is: {1}", input, ConvertedBinaryValue(input));
				}
                catch (Exception)
                {
					Console.WriteLine("\nInvalid input!");
				}
				

				//Retry or exit back to menu
				Console.Write("\n\nTry again? (y/n): ");
				retry = Console.ReadLine().ToLower() == "y" ? true : false;
			}
		}

		/*
			[MPCS 04-10-2021]: This method will list initialized elements (ABC) into permutation sort
		*/
		private static void ListPermutationSort(bool retry)
        {
			while (retry)
			{
				Console.Clear();
				Console.WriteLine("=================================");
				Console.WriteLine("=       Permutation Sort        =");
				Console.WriteLine("=================================");
				Console.Write("\nInstruction: Write a program in C# to sort a list of elements using Permutation sort. \n\n");

				//initialized string value;
				string elements = "ABC"; 
				char[] elemArray = elements.ToCharArray();
				
				//Call method to process permutation sorting
				GetPermutation(elemArray, 0, elements.Length-1);  


				//Retry or exit back to menu
				Console.Write("\n\nTry again? (y/n): ");
				retry = Console.ReadLine().ToLower() == "y" ? true : false;
			}
		}

		/*
			[MPCS 04-10-2021]: This method will draw a hollow rectangle based from name and size input
		*/
		private static void HollowRectangle(bool retry)
		{
			while (retry)
			{
				Console.Clear();
				Console.WriteLine("=================================");
				Console.WriteLine("=       Hollow Rectangle        =");
				Console.WriteLine("=================================");
				Console.Write("\nInstruction: Write a program in C# to ask the user for his/her name and a size, and display a hollow rectangle with it.");

                try
                {
					// Input needed values
					Console.Write("\n\nEnter a your name: ");
					string name = Console.ReadLine();
					int nameLength = name.Length;

					Console.Write("\nEnter size: ");
					int size = Convert.ToInt32(Console.ReadLine());

					// Draw rectangle
					for (int i = 1; i <= size; i++)
					{
						// Create new line
						Console.WriteLine();

						// Output name as X
						if (i == 1 || i == size)
						{
							for (int j = 1; j <= size; j++)
								Console.Write(name);
						}

						// Output name as Y
						else
						{
							for (int j = 1; j <= size + nameLength; j++)
								if (j == 1 || j == size + nameLength)
									Console.Write(name);
								else
									Console.Write(" ");
						}

					}
				}
                catch (Exception)
                {
					Console.WriteLine("\nInvalid input!");
                }

				//Retry or exit back to menu
				Console.Write("\n\nTry again? (y/n): ");
				retry = Console.ReadLine().ToLower() == "y" ? true : false;
			}
		}


		/*
			[MPCS 04-10-2021]: This method will draw a diamond pattern based from input row number
		*/
		private static void DiamondPattern(bool retry)
		{
			while (retry)
			{
				Console.Clear();
				Console.WriteLine("=================================");
				Console.WriteLine("=       Diamond Pattern         =");
				Console.WriteLine("=================================");
				Console.Write("\nInstruction: Write a program in C# to display the pattern like a diamond.");

				try
				{
					// Input rows
					Console.Write("\n\nInput number of rows: ");
					int rows = Convert.ToInt32(Console.ReadLine());

					// get quotient with absolute value for the base of diamond
					rows = ~~(rows / 2); 
					int i;

					// draw triangle
					for (i = 0; i <= rows; i++) 
					{
						Console.Write("\n");
						for (int j = 1; j <= rows - i; j++)
							Console.Write(" ");
						for (int j = 1; j <= 2 * i - 1; j++)
							Console.Write("*");
						
					}

					// draw inverted triangle
					for (i = rows - 1; i >= 1; i--) 
					{
						Console.Write("\n");
						for (int j  = 1; j <= rows - i; j++)
							Console.Write(" ");
						for (int j  = 1; j <= 2 * i - 1; j++)
							Console.Write("*");
						
					}
				}
				catch (Exception)
				{
					Console.WriteLine("\nInvalid input!");
				}

				//Retry or exit back to menu
				Console.Write("\n\nTry again? (y/n): ");
				retry = Console.ReadLine().ToLower() == "y" ? true : false;
			}
		}

		/*
			[MPCS 04-10-2021]: This method will translate input number to corresponding words
		*/
		private static void NumberToWords(bool retry)
		{
			while (retry)
			{
				Console.Clear();
				Console.WriteLine("=========================================");
				Console.WriteLine("=       Convert Number to Words         =");
				Console.WriteLine("=========================================");
				Console.Write("\nInstruction: Create a program in C# that can accept a numeric input and convert it to its word equivalent. ");

                try
                {
					Console.Write("\n\nInput number: ");  
					int input = Convert.ToInt32(Console.ReadLine());
					
					Console.WriteLine("\nOutput:  {0}", ConvertNumberToText(input));
				}
                catch (Exception)
                {
					Console.WriteLine("\nInvalid input!");
				}

				//Retry or exit back to menu
				Console.Write("\n\nTry again? (y/n): ");
				retry = Console.ReadLine().ToLower() == "y" ? true : false;
			}
		}

		/*
			[MPCS 04-10-2021]: This method will display calculated value from text formula using MDAS rule.
		*/
		private static void MDAS(bool retry)
		{
			while (retry)
			{
				Console.Clear();
				Console.WriteLine("=========================================");
				Console.WriteLine("=                M D A S                =");
				Console.WriteLine("=========================================");
				Console.Write("\nInstruction: Create a program in C# that could process a given text formula using MDAS rule.");

				Console.Write("\n\nInput: ");
				var textFormula = Console.ReadLine(); 

				DataTable table = new DataTable();
				table.Columns.Add("textFormula", typeof(string), textFormula);
				DataRow row = table.NewRow();
				table.Rows.Add(row);


				Console.WriteLine("\nOutput:  {0}", double.Parse((string)row["textFormula"]));

				//Retry or exit back to menu
				Console.Write("\n\nTry again? (y/n): ");
				retry = Console.ReadLine().ToLower() == "y" ? true : false;
			}
		}

		#endregion

		#region Sub-methods

		/*
		[MPCS 04-10-2021]: This method performs recursive call to convert decimal to binary.
		Recursion time complexity: Usage of recursion is advantageous in shorter code, but higher time complexity compared to iteration. 
		*/
		private static int ConvertedBinaryValue(int decimalInput)  
		{
			int divisor = 2, modulus = 2;

			if (decimalInput == 0)
				return 0;
			else
				return ((decimalInput % modulus) + 10 * ConvertedBinaryValue(decimalInput / divisor));  
		}


		static void GetPermutation(char[] elemArray, int start, int next)
		{
			if (start == next)
				Console.WriteLine(elemArray);
			else
			{
				for (int i = start; i <= next; i++)
				{
					Swap(ref elemArray[start], ref elemArray[i]);
					//Recursive call
					GetPermutation(elemArray, start + 1, next);
					Swap(ref elemArray[start], ref elemArray[i]); 
				}
			}
		}

		static void Swap(ref char start, ref char next)
		{
			char temp;
			temp = start;
			start = next;
			next = temp;
		}


		private static string ConvertNumberToText (int input)
        {
			int[] num = new int[4];
			int first = 0;
			int ones, tens, hundreds;
			string and = "";

			StringBuilder convertedText = new StringBuilder();
			if (input < 0)
			{
				// Handle negative numbers
				convertedText.Append("Negative ");
				input = -input;
			}

			if (input == 0) 
				return "Zero";
			

			string[] words0 = { "", "One ", "Two ", "Three ", "Four ", "Five ", "Six ", "Seven ", "Eight ", "Nine " };
			string[] words1 = { "Ten ", "Eleven ", "Twelve ", "Thirteen ", "Fourteen ", "Fifteen ", "Sixteen ", "Seventeen ", "Eighteen ", "Nineteen " };
			string[] words2 = { "Twenty ", "Thirty ", "Forty ", "Fifty ", "Sixty ", "Seventy ", "Eighty ", "Ninety " };
			string[] words3 = { "Thousand ", "Million ", "Billion " };

			

			// units
			num[0] = input % 1000;           
			num[1] = input / 1000;
			num[2] = input / 1000000;

			// thousands
			num[1] = num[1] - 1000 * num[2];

			// millions
			num[2] = num[2] - 1000 * num[3];  

			// billions
			num[3] = input / 1000000000;

			
			for (int i = 3; i > 0; i--)
			{
				if (num[i] != 0)
				{
					first = i;
					break;
				}
			}
			for (int i = first; i >= 0; i--)
			{
				if (num[i] == 0) 
					continue;

				ones = num[i] % 10;              
				tens = num[i] / 10;
				hundreds = num[i] / 100;             
				tens = tens - 10 * hundreds;               
				if (hundreds > 0) 
					convertedText.Append(words0[hundreds] + "Hundred ");

				if (ones > 0 || tens > 0)
				{
					if (hundreds > 0 || i < first) 
						convertedText.Append(and);
					
					if (tens == 0)
						convertedText.Append(words0[ones]);
					else if (tens == 1)
						convertedText.Append(words1[ones]);
					else
						convertedText.Append(words2[tens - 2] + words0[ones]);
				}
				if (i != 0) 
					convertedText.Append(words3[i - 1]);
			}

			// Converted values
			return convertedText.ToString(); 
		}
		#endregion

	}
}
