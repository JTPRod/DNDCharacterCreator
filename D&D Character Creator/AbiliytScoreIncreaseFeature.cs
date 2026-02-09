using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_Creator
{
    internal class AbiliytScoreIncreaseFeature : Feature
    {
        public int pointsToAdd = 0;

        public AbiliytScoreIncreaseFeature(string name, string description, bool visible, int level, int pointsToAdd, int removeAtLevel = 100) : base(name, description, visible, level, removeAtLevel)
        {
            this.pointsToAdd = pointsToAdd;
        }


        /// <summary>
        /// Allows user to add ability score increases to the character
        /// </summary>
        /// <param name="character">Character that this feature belongs to</param>
        public void SelectAbilityScoreIncreases(CharacterObject character)
        {
            //Allow user to select where to add all ability score increase(s)

            throw new NotImplementedException();
        }

        public override void ExecuteFunctionality(CharacterObject character)
        {
            SelectAbilityScoreIncreases(character);
        }
    }

    internal class SetAbiliytScoreIncreaseFeature : Feature
    {
        public Dictionary<string, int> setScoreImprovemts = new Dictionary<string, int>();

        public SetAbiliytScoreIncreaseFeature(string name, string description, bool visible, int level, Dictionary<string, int> setScoreImprovements, int removeAtLevel = 100) : base(name, description, visible, level, removeAtLevel)
        {
            this.setScoreImprovemts = setScoreImprovements;
        }


        /// <summary>
        /// Adds all specified ability score improvements to the character
        /// </summary>
        /// <param name="character">Character that this feature belongs to</param>
        public void AddAbilityScoreImprovements(CharacterObject character)
        {
            //Add all specified ability score improvements to the character

            throw new NotImplementedException();
        }

        public override void ExecuteFunctionality(CharacterObject character)
        {
            AddAbilityScoreImprovements(character);
        }
    }
}
