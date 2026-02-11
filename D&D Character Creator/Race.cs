using D_D_Character_Creator;
using System;
using System.Collections.Generic;

public class Race
{
	public Races race;
	public string raceName;
	public int movementSpeed;
	public Dictionary<string, int> abilityScoreIncreases = new Dictionary<string, int>();
    public List<string> languages = new List<string>();
    internal List<Feature> racialTraits = new List<Feature>();


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
