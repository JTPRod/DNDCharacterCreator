using System;

public class CharacterClass
{
    //Basic stats
    public Classes classType;
    public string className;
    public int hitDice;
    public List<string> savingThrows = new List<string>();
    public int skillNum;
    public List<string> skills = new List<string>();
    public List<string> features = new List<string>();
    public List<Classes> subclasses = new List<Classes>();


    //Proficiencies
    public List<string> armorProf = new List<string>();
    public List<string> weaponProf = new List<string>();
    public List<string> toolProf = new List<string>();


    //Equipment
    //public static void listAllEquipment { }

    //Class Specific Displays

    public CharacterClass()
	{
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
