using D_D_Character_Creator;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class CharacterObject
{
	//basic stats
	public string name = "";
	public Race race = null;
	public CharacterClass characterClass = null;
	public int profBonus = 0;
	public int AC = 0;
	public int init = 0;
	public int speed = 0;
	public int maxHP = 0;
	public int level = 0;
	public int hitDice = 0;

    //skills
    public int strScore = 0;
    public int strMod = 0;
    public int dexScore = 0;
    public int dexMod = 0;
    public int conScore = 0;
    public int conMod = 0;
    public int intScore = 0;
    public int intMod = 0;
    public int wisScore = 0;
    public int wisMod = 0;
    public int chaScore = 0;
    public int chaMod = 0;

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


    public CharacterObject(string name)
	{
        this.name = name;
	}

    public void CreateCharacter()
    {
        SelectRace();
        SelectedClass();

        this.level = 1;
    }

    public void SelectRace()
    {
        bool validAnser = false;

        while (!validAnser)
        {
            Console.WriteLine("\n=============================================");
            Console.WriteLine("_____Races_____");

            int i = 0;
            foreach (Race r in Database.RaceDatabase)
            {
                i++;
                Console.WriteLine("   " + i + ".) " + r.raceName);
            }
            Console.Write("Please Select a Race: ");
            string input = Console.ReadLine();

            int intInput = -1;
            int.TryParse(input, out intInput);

            if (!(intInput > 0))
            {
                Console.WriteLine("\n That is not a valid input! Input must be a non-negative integer!");
                continue;
            }
            else if (intInput > i)
            {
                Console.WriteLine("\n That is not a valid input!");
                continue;
            }
            else if(intInput == 0)
            {
                Console.WriteLine("Selected 0; Returning to Main");
                //Logic to return to main
            }
            else
            {
                validAnser = true;

                Race selectedRace = Database.RaceDatabase[intInput - 1];
                Console.WriteLine("\n Race (" + selectedRace.raceName + ") Selected!");

                this.race = selectedRace;
                this.speed = this.race.movementSpeed;


                //Add ability score modifiers
                foreach(string s in this.race.abilityScoreIncreases.Keys)
                {
                    if (s == "Strength") this.strScore += this.race.abilityScoreIncreases[s];
                    if (s == "Dexterity") this.dexScore += this.race.abilityScoreIncreases[s];
                    if (s == "Constitution") this.conScore += this.race.abilityScoreIncreases[s];
                    if (s == "Intelligence") this.intScore += this.race.abilityScoreIncreases[s];
                    if (s == "Wisdom") this.wisScore += this.race.abilityScoreIncreases[s];
                    if (s == "Charisma") this.chaScore += this.race.abilityScoreIncreases[s];
                }
            }
        }
    }


    public void SelectedClass()
    {
        bool validAnser = false;

        while (!validAnser)
        {
            Console.WriteLine("\n=============================================");
            Console.WriteLine("_____Classes_____");

            int i = 0;
            foreach (CharacterClass c in Database.ClassDatabase)
            {
                i++;
                Console.WriteLine("   " + i + ".) " + c.className);
            }
            Console.Write("Please Select a Race: ");
            string input = Console.ReadLine();

            int intInput = -1;
            int.TryParse(input, out intInput);

            if (!(intInput > 0))
            {
                Console.WriteLine("\n That is not a valid input! Input must be a non-negative integer!");
                continue;
            }
            else if (intInput > i)
            {
                Console.WriteLine("\n That is not a valid input!");
                continue;
            }
            else if (intInput == 0)
            {
                Console.WriteLine("Selected 0; Returning to Main");
                //Logic to return to main
            }
            else
            {
                validAnser = true;

                CharacterClass selectedClass = Database.ClassDatabase[intInput - 1];
                Console.WriteLine("\n Class (" + selectedClass.className + ") Selected!");

                this.characterClass = selectedClass;
                this.hitDice = characterClass.hitDice;

                //Roll Stats
                List<int> statRolls = new List<int>();
                for (int j = 0; j < 6; j++)
                {
                    int score = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        int roll = Dice.Roll(6);
                        if (roll < 1 || roll > 6) throw new ArgumentOutOfRangeException();  //verify that all rolls are valid
                        if (roll == 1) roll = Dice.Roll(6);
                        score += roll;
                    }
                    statRolls.Add(score);
                }

                //Assign Stats
                strScore += StatAssignment(statRolls, "Strength", strScore);
                dexScore += StatAssignment(statRolls, "Dexterity", dexScore);
                conScore += StatAssignment(statRolls, "Constitution", conScore);
                intScore += StatAssignment(statRolls, "Intelligence", intScore);
                wisScore += StatAssignment(statRolls, "Wisdom", wisScore);
                chaScore += StatAssignment(statRolls, "Charisma", chaScore);

                strMod = CalculateStatModifier(strScore);
                dexMod = CalculateStatModifier(dexScore);
                conMod = CalculateStatModifier(conScore);
                intMod = CalculateStatModifier(intScore);
                wisMod = CalculateStatModifier(wisScore);
                chaMod = CalculateStatModifier(chaScore);
            }
        }
    }

    private int StatAssignment(List<int> statRolls, string statName, int currentScore)
    {
        bool validStatInput = false;
        int statRoll = 0;

        while (!validStatInput)
        {
            Console.Write("\nUnallocated Stat Scores: ");
            foreach (int score in statRolls)
            {
                Console.Write(score + "  ");
            }

            if(currentScore > 0)
            {
                Console.Write("(" + statName + " already has a +" + currentScore +  ")");
            }

            Console.Write("\n Which score should be Assigned to " + statName + "? ");
            string scoreInput = Console.ReadLine();

            int intInput = -1;
            int.TryParse(scoreInput, out intInput);

            if (!statRolls.Contains(intInput))
            {
                Console.WriteLine("\n That is not a valid input! Input must be one of the Unallocated Stat Scores!");
            }
            else
            {
                validStatInput = true;
                statRoll = intInput;
            }

        }
                statRolls.Remove(statRoll);
                return statRoll;
    }


    public int CalculateStatModifier(int statScore)
    {
        int modifier = -88;

        if (statScore <= 1)
        {
            modifier = -5;
        }
        else if (statScore <= 3)
        {
            modifier = -4;
        }
        else if (statScore <= 5)
        {
            modifier = -3;
        }
        else if (statScore <= 7)
        {
            modifier = -2;
        }
        else if (statScore <= 9)
        {
            modifier = -1;
        }
        else if (statScore <= 11)
        {
            modifier = 0;
        }
        else if (statScore <= 13)
        {
            modifier = 1;
        }
        else if (statScore <= 15)
        {
            modifier = 2;
        }
        else if (statScore <= 17)
        {
            modifier = 3;
        }
        else if (statScore <= 19)
        {
            modifier = 4;
        }
        else if (statScore >= 20)
        {
            modifier = 5;
        }

        return modifier;
    }






    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("_____" + this.name + "_____");
        sb.Append("\n  Race: " + this.race.raceName);
        sb.Append("\n  Class: " + this.characterClass.className);
        sb.Append("\n  Level: " + this.level);
        sb.Append("\n  Base Speed: " + this.speed + "ft");
        sb.Append("\n  Hit Dice: " + this.level + "D" + this.hitDice);
        sb.Append("\n  ___Stats___");
        sb.Append("\n    Strength Score: " + this.strScore + " ( +" + this.strMod + " )");
        sb.Append("\n    Dexterity Score: " + this.dexScore + " ( +" + this.dexMod + " )");
        sb.Append("\n    Constitution Score: " + this.conScore + " ( +" + this.conMod + " )");
        sb.Append("\n    Intelligence Score: " + this.intScore + " ( +" + this.intMod + " )");
        sb.Append("\n    Wisdom Score: " + this.wisScore + " ( +" + this.wisMod + " )");
        sb.Append("\n    Charisma Score: " + this.chaScore + " ( +" + this.chaMod + " )");



        string characterDisplayString = sb.ToString();
        return characterDisplayString;
    }
}