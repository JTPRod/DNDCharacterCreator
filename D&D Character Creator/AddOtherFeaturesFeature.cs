using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_Creator
{
    internal class AddOtherFeaturesFeature : Feature
    {
        public List<Feature> Features;

        public AddOtherFeaturesFeature(string name, string description, int level, List<Feature> features, int removeAtLevel = 100) : base(name, description, level, removeAtLevel)
        {
            Features = features;
        }
        
        
        /// <summary>
        /// Adds all features to a character
        /// </summary>
        /// <param name="character">The character that this feature is beinga applied to</param>
        public void AddFeatures(CharacterObject character)
        {
            //Add all features to character
            throw new NotImplementedException();
        }


        public override void ExecuteFunctionality(CharacterObject character)
        {
            AddFeatures(character);
        }

    }
}
