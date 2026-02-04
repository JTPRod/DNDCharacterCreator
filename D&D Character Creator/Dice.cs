using System;

public class Dice
{
	private static Random rand = new Random();
    private int result;

	public int Roll(int faces)
	{
		int min = 1;
		int max = faces + 1;
		result = rand.Next(min, max);
        return result;
    }

	public int getResult()
	{
		return result;
	}

}