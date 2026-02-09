using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_Creator
{
    internal class ExpertiseFeature : Feature
    {
        public int numberOfExpertise = 0;

        public ExpertiseFeature(string name, string description, bool visible, int level, int numberOfExpertise, int removeAtLevel = 100) : base(name, description, visible, level, removeAtLevel)
        {
            this.numberOfExpertise = numberOfExpertise;
        }

        /// <summary>
        /// Gives the character expertise in a certain number of skills
        /// </summary>
        /// <param name="character">The character that this trait belongs to</param>
        public void ChooseExperties(CharacterObject character)
        {
            while(numberOfExpertise > 0)
            {
                //Select one skill that the character is proficient in and does not already have expertise in and add expertise to that skill
                //decrement numberOfExpertise
            }

            throw new NotImplementedException();
        }

        public override void ExecuteFunctionality(CharacterObject character)
        {
            ChooseExperties(character);
        }

    }
}
