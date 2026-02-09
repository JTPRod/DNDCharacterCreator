using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_Creator
{
    internal class BaseWalkSpeedFeature : Feature
    {
        public int baseWalkSpeed = 0;

        public BaseWalkSpeedFeature(string name, string description, bool visible, int level, int baseWalkSpeed, int removeAtLevel = 100) : base(name, description, visible, level, removeAtLevel)
        {
            baseWalkSpeed = baseWalkSpeed;
        }

        /// <summary>
        /// Sets the base walk speed of the character this feature belongs to
        /// </summary>
        /// <param name="character">Character this feature belongs to</param>
        public void SetBaseWalkSpeed(CharacterObject character)
        {
            //Set character base walk speed

            throw new NotImplementedException();
        }

        public override void ExecuteFunctionality(CharacterObject character)
        {
            SetBaseWalkSpeed(character);
        }
    }


    internal class AdditionalWalkSpeedFeature : Feature
    {
        public int additionalWalkSpeed = 0;

        public AdditionalWalkSpeedFeature(string name, string description, bool visible, int level, int additionalWalkSpeed, int removeAtLevel = 100) : base(name, description, visible, level, removeAtLevel)
        {
            this.additionalWalkSpeed = additionalWalkSpeed;
        }

        /// <summary>
        /// Adds additional walk speed to the character this feature belongs to
        /// </summary>
        /// <param name="character">Character this feature belongs to</param>
        public void AddAdditionalWalkSpeed(CharacterObject character)
        {
            //Add additional walk speed to the character

            throw new NotImplementedException();
        }

        public override void ExecuteFunctionality(CharacterObject character)
        {
            AddAdditionalWalkSpeed(character);
        }
    }
}
