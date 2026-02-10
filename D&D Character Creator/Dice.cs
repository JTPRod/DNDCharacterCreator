using System;

public class Dice
{
	private static Random rand = new Random();
    private static int result;

	public static int Roll(int faces)
	{
		int min = 1;
		int max = faces + 1;
		result = rand.Next(min, max);
        return result;
    }

	public static int getResult()
	{
		return result;
	}

}