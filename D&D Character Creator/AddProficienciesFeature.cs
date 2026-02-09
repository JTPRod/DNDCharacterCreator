using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_Creator
{
    internal class AddProficienciesFeature : Feature
    {
        public List<Skill> skills;
        public List<WeaponType> weaponTypes;
        public List<Item> items;
        public List<ArmorWeight> armors;
        public List<string> tools;

        //Skills
        public AddProficienciesFeature(string name, string description, bool visible, int level, List <Skill> skills, int removeAtLevel = 100) : base(name, description, visible, level, removeAtLevel)
        {
            this.skills = skills;
        }

        //Weapons
        public AddProficienciesFeature(string name, string description, bool visible, int level, List<WeaponType> weapons, int removeAtLevel = 100) : base(name, description, visible, level, removeAtLevel)
        {
            this.weaponTypes = weaponTypes;
        }

        //items (ie shields)
        public AddProficienciesFeature(string name, string description, bool visible, int level, List<Item> items, int removeAtLevel = 100) : base(name, description, visible, level, removeAtLevel)
        {
            this.items = items;
        }

        //Armors
        public AddProficienciesFeature(string name, string description, bool visible, int level, List<ArmorWeight> armors, int removeAtLevel = 100) : base(name, description, visible, level, removeAtLevel)
        {
            this.armors = armors;
        }

        //Tools
        public AddProficienciesFeature(string name, string description, bool visible, int level, List<string> tools, int removeAtLevel = 100) : base(name, description, visible, level, removeAtLevel)
        {
            this.tools = tools;
        }

        //A combination
        public AddProficienciesFeature(string name, string description, bool visible, int level, List<Skill> skills, List<WeaponType> weapons, List<Item> items, List<ArmorWeight> armors, List<string> tools, int removeAtLevel = 100) : base(name, description, visible, level, removeAtLevel)
        {
            this.skills = skills;
            this.weaponTypes = weapons;
            this.items = items;
            this.armors = armors;
            this.tools = tools;
        }

        /// <summary>
        /// Adds all included proficiencys to the character
        /// </summary>
        /// <param name="character">The character this feature is being added to</param>
        public void AddProficiencies(CharacterObject character)
        {
            foreach (Skill skill in skills)
            {
                //Add skill proficiency for the given character
            }

            foreach(WeaponType weapon in weaponTypes)
            {
                //Add weapon proficiency to the given character
            }

            foreach (Item item in items)
            {
                //Add item proficieny to the given character
            }

            foreach(ArmorWeight armor in armors)
            {
                //Add armor proficiency to the given character
            }

            foreach(string tool in tools)
            {
                //Add tool proficiency to the given character
            }

            throw new NotImplementedException();
        }


        public override void ExecuteFunctionality(CharacterObject character)
        {
            AddProficiencies(character);
        }
    }
}
