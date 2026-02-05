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
        int numberToSelect = 0;

        public SelectProficienciesFeature(string name, string description, int level, List<Skill> skills, int numberToSelect, int removeAtLevel = 100) : base(name, description, level, removeAtLevel)
        {
            this.skills = skills;
            this.numberToSelect = numberToSelect;
        }

        /// <summary>
        /// Allows user to select a certain number of skills from a list to obtain proficiency in
        /// </summary>
        /// <param name="characterObject">Character that this feature is being applied to</param>
        public void SelectProficienciesFromList(CharacterObject character)
        {
            while (numberToSelect > 0)
            {
                //Let user select skill from remaining skills on the list
                //Add proficiency in that skill for the character
                //Decrement number of skill that the user can choose
            }

            throw new NotImplementedException();
        }


        public override void ExecuteFunctionality(CharacterObject character)
        {
            SelectProficienciesFromList(character);
        }
    }
}
