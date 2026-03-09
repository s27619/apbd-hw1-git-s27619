public static class StatisticsHelper
{	
	public static double CalculateAverage(int[] values)
	{
		if (values.Length == 0)
		{
			throw new ArgumentException("Array cannot be empty");
		}

		return values.Average();
	}

	public static int CalculateMax(int[] values)
	{
		return values.Max();
	}
}