using System;

public class CharacterClass
{
	public CharacterClass()
	{
	//Basic stats
	public Classes className;
	public int hitDice;
    public int savingThrows;
	public int skillNum;
	public List<string> skills = new List<string> ();
	public List<string> features = new List<string> ();
	public List<Classes> subclasses = new List<Classes> ();


    //Proficiencies
    public List<string> armorProf = new List<string>();
    public List<string> weaponProf = new List<string>();
    public List<string> toolProf = new List<string>();


    //Equipment
    public static void listAllEquipment { }

	//Class Specific Displays
	}

	public enum Classes
	{
		ARTIFICER,
		BARBARIAN,
		BARD,
		CLERIC,
		DRUID,
		FIGHTER,
		MONK,
		PALADIN,
		RANGER,
		ROGUE,
		SORCERER,
		WARLOCK,
		WIZARD
	}
}
