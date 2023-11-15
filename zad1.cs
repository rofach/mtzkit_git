using System;

class Program
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		for (int i = 1; i <= n; i++)
		{
			string line = "";
			for (int j = 1; j <= n - i; j++)
				line += "  ";

			for (int j = n - i + 1; j <= n; j++)
			{
				if (j == n - i + 1 || j == n)
					line += "* ";
				else line += "+ ";
			}
			string newLine = line.Remove(2 * n - 1);
			Console.WriteLine(newLine);
			
		}
		for (int i = n - 1; i >= 0; i--)
		{
			string line = "";
			for (int j = 1; j <= n - i; j++)
				line += "  ";

			for (int j = n - i + 1; j <= n; j++)
			{
				if (j == n - i + 1 || j == n)
					line += "* ";
				else line += "+ ";
			}
			string newLine = line.Remove(2 * n - 1);
			Console.WriteLine(newLine);
		}

		// changes
		Console.WriteLine();

	}
}