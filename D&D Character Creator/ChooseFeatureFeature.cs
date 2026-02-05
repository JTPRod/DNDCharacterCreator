using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_Creator
{
    internal class ChooseFeatureFeature : Feature
    {
        public List<Feature> Features;
        public int numberToBeChoosen = 1;

        public ChooseFeatureFeature(string name, string description, int level, List<Feature> features, int numberToBeChoosen, , int removeAtLevel = 100) : base(name, description, level, removeAtLevel)
        {
            Features = features;
            this.numberToBeChoosen = numberToBeChoosen;
        }

        /// <summary>
        /// Allows user to select a certain number of features from a list and add them to the character
        /// </summary>
        /// <param name="characterObject">Character that this feature is being applied to</param>
        public void SelectFeaturesFromList(CharacterObject characterObject)
        {
            while(numberToBeChoosen > 0)
            {
                //Let user select feature from remaining features on the list
                //Add that Feature to the character
                //Decrement number of features that the user can choose
            }

            throw new NotImplementedException();
        }

        public override void ExecuteFunctionality(CharacterObject character)
        {
            SelectFeaturesFromList(character);  
        }
    }
}
