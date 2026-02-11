using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_Creator
{
    public enum Stat
    {
        STRENGTH,
        DEXTERITY,
        CONSTITUTION,
        INTELLIGENCE,
        WISDOM,
        CHARISMA
    }

    internal class Skill
    {
        private string name = "";
        private Stat Stat;
        private int modifier = 0;
        private bool proficient = false;
        private bool expertise = false;
        private bool isSavingThrow = false;

        public Skill(string name,  Stat stat, bool isSavingThrow) //proficiency, expertise, and modifiers will not be added in constructor since they must be calculated later
        {
            this.name = name;
            this.Stat = stat;
            this.isSavingThrow = isSavingThrow;
        }

        /// <summary>
        /// Allows other classes to see the name of this skill
        /// </summary>
        /// <returns>The name of this skill</returns>
        public string getName()
        {
            return name;
        }

        /// <summary>
        /// Allows other classes to see the stat of this skill
        /// </summary>
        /// <returns>The Stat this skill uses</returns>
        public Stat getStat()
        {
            return Stat;
        }

        /// <summary>
        /// Allow other classes to see what this skill's modifier is
        /// </summary>
        /// <returns>Modifier</returns>
        public int getModifier()
        {
            return modifier;
        }

        /// <summary>
        /// Allows other classes to see if the character is proficient in this skill
        /// </summary>
        /// <returns>If the character is proficient in this skill</returns>
        public bool getProficient()
        {
            return proficient;
        }

        /// <summary>
        /// Allows other classes to see if the character has expertise in this skill
        /// </summary>
        /// <returns>If the character has expertise in this skill</returns>
        public bool getExpertise()
        {
            return this.expertise;
        }

        /// <summary>
        /// Allows other classes to see if this skill is a saving throw
        /// </summary>
        /// <returns>If this skill is a saving throw</returns>
        public bool getIsSavingThrow()
        {
            return isSavingThrow;
        }

        /// <summary>
        /// Allows other classes to set whether the character is proficient in this skill
        /// </summary>
        /// <param name="isProficient">is the character proficient in this skill</param>
        public void setProficient(bool isProficient)
        {
            this.proficient = isProficient;
        }

        /// <summary>
        /// Sets skill as having/not having expertise. Can only set as having expertise if the stat has proficienty and is not a Saving Throw.
        /// </summary>
        /// <param name="isExpertise">Does the character have expertise in this skill</param>
        /// <returns>If the Expertise stat was successfully changed</returns>
        public bool setExpertise(bool isExpertise)
        {
            if(isExpertise && (isSavingThrow || !proficient))
            {
                return false;
            }
            else
            {
                this.expertise = isExpertise;
                return true;
            }
        }



        /// <summary>
        /// Calculates the modifier for this skill
        /// </summary>
        /// <param name="statScore">Character's modifier for this stat</param>
        /// <param name="proficiencyBonus">Character's current proficiency bonus</param>
        public void CalculateModifier(int statModifier, int proficiencyBonus)
        {
            //Base modifier before adjusting for proficiency and expertise
           modifier = statModifier;


            //Adjust for proficiency
            if(proficient)
            {
                modifier += proficiencyBonus;
            }

            //Adjust for Expertise
            if(expertise)
            {
                modifier += proficiencyBonus;
            }
        }
    }
}
