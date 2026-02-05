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

        public AddProficienciesFeature(string name, string description, int level, List <Skill> skills, int removeAtLevel = 100) : base(name, description, level, removeAtLevel)
        {
            this.skills = skills;
        }

        /// <summary>
        /// Adds proficiency for all included skills to the character
        /// </summary>
        /// <param name="character">The character this feature is being added to</param>
        public void AddProficiencies(CharacterObject character)
        {
            foreach (Skill skill in skills)
            {
                //Add skill proficiency for the given character
            }
            throw new NotImplementedException();
        }


        public override void ExecuteFunctionality(CharacterObject character)
        {
            AddProficiencies(character);
        }
    }
}
