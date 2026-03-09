public static class StatisticsHelper
{	
	public static double CalculateAverage(int[] values)
	{
		if (values.Length == 0 || values == null)
		{
			throw new ArgumentException("Array cannot be empty");
		}

		return values.Average();
	}

	public static int CalculateMax(int[] values)
	{
		if (values.Length == 0 || values == null)
		{
			throw new ArgumentException("Array cannot be empty");
		}

		return values.Max();
	}

	public static int CalculateMin(int[] values)
	{
		if (values.Length == 0 || values == null)
		{
			throw new ArgumentException("Array cannot be empty");
		}

		return values.Min();
	}
}