using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_Creator
{
    internal class SelectProficienciesFeature : Feature
    {
        public List<Skill> skills;
        public int numberSkills = 0;
        public List<WeaponType> weaponTypes;
        public int numberWeapons = 0;
        public List<Item> items;
        public int numberItems = 0;
        public List<ArmorWeight> armors;
        public int numberArmor = 0;
        public List<string> tools;
        public int numberTools = 0;

        //for skills
        public SelectProficienciesFeature(string name, string description, bool visible, int level, List<Skill> skills, int numberToSelect, int removeAtLevel = 100) : base(name, description, visible, level, removeAtLevel)
        {
            this.skills = skills;
            this.numberSkills = numberToSelect;
        }

        //for weapons
        public SelectProficienciesFeature(string name, string description, bool visible, int level, List<WeaponType> weapons, int numberToSelect, int removeAtLevel = 100) : base(name, description, visible, level, removeAtLevel)
        {
            this.weaponTypes = weapons;
            this.numberWeapons = numberToSelect;
        }

        //for items
        public SelectProficienciesFeature(string name, string description, bool visible, int level, List<Item> items, int numberToSelect, int removeAtLevel = 100) : base(name, description, visible, level, removeAtLevel)
        {
            this.items = items;
            this.numberItems = numberToSelect;
        }

        //for armors
        public SelectProficienciesFeature(string name, string description, bool visible, int level, List<ArmorWeight> armors, int numberToSelect, int removeAtLevel = 100) : base(name, description, visible, level, removeAtLevel)
        {
            this.armors = armors;
            this.numberArmor = numberToSelect;
        }

        //for tools
        public SelectProficienciesFeature(string name, string description, bool visible, int level, List<string> tools, int numberToSelect, int removeAtLevel = 100) : base(name, description, visible, level, removeAtLevel)
        {
            this.tools = tools;
            this.numberTools = numberToSelect;
        }

        //A combination
        public SelectProficienciesFeature(string name, string description, bool visible, int level, List<Skill> skills, int skillSelectionLimit, List<WeaponType> weapons, int weaponSelectionLimit, List<Item> items, int itemSelectionLimit, List<ArmorWeight> armors, int armorSelectionLimit, List<string> tools, int toolSelectionLimit, int removeAtLevel = 100) : base(name, description, visible, level, removeAtLevel)
        {
            this.skills = skills;
            this.numberSkills = skillSelectionLimit;
            this.weaponTypes = weapons;
            this.numberWeapons = weaponSelectionLimit;
            this.items = items;
            this.numberItems = itemSelectionLimit;
            this.armors = armors;
            this.numberArmor = armorSelectionLimit;
            this.tools = tools;
            this.numberTools = toolSelectionLimit;
        }

        /// <summary>
        /// Allows user to select a certain number of skills from a list to obtain proficiency in
        /// </summary>
        /// <param name="characterObject">Character that this feature is being applied to</param>
        public void SelectProficienciesFromList(CharacterObject character)
        {
            Console.WriteLine("\n=============================================");

            //skills
            if (skills.Count > 0)
            {
                //Let user select skill from remaining skills on the list
                //Add proficiency in that skill for the character
                //Decrement number of skill that the user can choose

                for (int i = 0; i < numberSkills; i++)
                {
                    int numLeft = 0;
                    StringBuilder sb = new StringBuilder();
                    sb.Append("\nSelect Skill Proficiencies (" + (numberSkills - i) + " selections remaining)");
                    sb.Append("\n Skills: ");
                    foreach(Skill skill in this.skills)
                    {
                        Skill playerSkill = Helpers.FindSkill(skill.getName(), character.skills);
                        if(!playerSkill.getProficient())    //don't display skills the character is already proficient in
                        {
                            sb.Append(skill.getName() + "  ");
                            numLeft++;
                        }
                    }

                    if(numLeft == 0)
                    {
                        Console.WriteLine("You cannot gain any new proficiencies (All available skills already have proficiency)");
                    }
                    else if(numLeft > 1)
                    {
                        sb.Append("\nPlease select a proficiency  ");
                        string prompt = sb.ToString();
                        Console.Write(prompt);

                        string input = Console.ReadLine();

                        if(Helpers.FindSkill(input, this.skills) != null)   //if user inputs valid skill, set proficiency for skill
                        {
                            Skill selectedSkill = Helpers.FindSkill(input, character.skills);

                            selectedSkill.setProficient(true);
                        }
                        else
                        {
                            Console.WriteLine("\nThat was not a valid selection! (must input name of skill case sensitive)");
                        }
                    }
                    
                }
            }

            //weapons
            while (numberWeapons > 0)
            {
                //Let user select weapon from remaining skills on the list
                //Add proficiency in that weapon for the character
                //Decrement number of weapons that the user can choose
            }

            //items
            while (numberItems > 0)
            {
                //Let user select item from remaining skills on the list
                //Add proficiency in that item for the character
                //Decrement number of items that the user can choose
            }

            //armors
            while (numberArmor > 0)
            {
                //Let user select armor from remaining skills on the list
                //Add proficiency in that armor for the character
                //Decrement number of armors that the user can choose
            }

            //tools
            while (numberTools > 0)
            {
                //Let user select tool from remaining skills on the list
                //Add proficiency in that tool for the character
                //Decrement number of tools that the user can choose
            }

        }


        public override void ExecuteFunctionality(CharacterObject character)
        {
            SelectProficienciesFromList(character);
        }
    }
}
