using System;

public class CharacterObject
{
	//basic stats
	public string name;
	public Race race;
	public CharacterClass characterClass;
	public int profBonus;
	public int AC;
	public int init;
	public int speed;
	public int maxHP;
	public int level;
	public string hitDice;

    //skills
    public int strScore;
    public int strMod;
    public int dexScore;
    public int dexMod;
    public int conScore;
    public int conMod;
    public int intScore;
    public int intMod;
    public int wisScore;
    public int wisMod;
    public int chaScore;
    public int chaMod;

    //other
    //skillList
    //featuresAndTraits
    //languages
    //toolProf
    //armorProf
    //weaponProf
    //weaponInv
    //equippedArmor
    //equippedShield
    //inventory
    public int spellAtkBonus;
    public int spellSaveDC;
    //spellSlots;
    //spells


    public CharacterObject()
	{
	}
}