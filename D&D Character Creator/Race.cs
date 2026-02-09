using System;
using System.Collections.Generic;

public class Race
{
	public Races raceName;
	public int movementSpeed;
	public Dictionary<string, int> abilityScoreIncreases = new Dictionary<string, int>();
    public List<string> languages = new List<string>();
    public List<string> racialTraits = new List<string>();


    public Race()
	{
	}

	public enum Races
	{
		AASIMAR,
		CHAMELEON,
		DRAGONBORN,
		DWARF,
		ELF,
		GNOME,
		GOLIATH,
		HALFLING,
		HUMAN,
		ORC,
		TIEFLING
	}
}
