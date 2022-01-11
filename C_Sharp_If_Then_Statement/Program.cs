using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class Program
{
	public static void Main()
	{
		int i = 10, j = 20;

		if (i > j)
		{
			Console.WriteLine("i is greater than j");
		}

		if (i < j)
		{
			Console.WriteLine("i is less than j");
		}

		if (i == j)
		{
			Console.WriteLine("i is equal to j");
		}
	}

    private static object GetDebuggerDisplay()
    {
        throw new NotImplementedException();
    }
}


 