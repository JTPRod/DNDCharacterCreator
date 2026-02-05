using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_Creator
{
    internal class SpellcastingFeature : Feature
    {
        public List<Spell> spellList;
        public int numCantripsToLearn = 0;
        public int numSpellsToLearn = 0;
        public Dictionary<SpellLevel, int> spellSlotsGained;
        public string spellcastingAbility = "";

        public SpellcastingFeature(string name, string description, int level, List<Spell> spellList, int numCantripsToLearn, int numSpellsTolearn, Dictionary<SpellLevel, int> spellSlotsGained, string spellcastingAbility, int removeAtLevel = 100) : base(name, description, level, removeAtLevel)
        {
            this.spellList = spellList;
            this.numCantripsToLearn = numCantripsToLearn;
            this.numSpellsToLearn = numSpellsTolearn;
            this.spellSlotsGained = spellSlotsGained;
            this.spellcastingAbility = spellcastingAbility;
        }

        /// <summary>
        /// Applies Spellcasting addition/changes to character
        /// </summary>
        /// <param name="character">Character that this feature belongs to</param>
        public void ApplySpellcasting(CharacterObject character)
        {
            while(numCantripsToLearn > 0)
            {
                //allow user to select additional cantrips 
                //decrement numCantripsToLearn
            }

            while (numSpellsToLearn > 0)
            {
                //allow user to select additional spells from any level that they are able to learn spells of 
                //decrement numSpellsTolearn
            }

            //Apply spellcasting ability

            //Apply additional Spell Slots


            throw new NotImplementedException();
        }


        public override void ExecuteFunctionality(CharacterObject character)
        {
            ApplySpellcasting(character);
        }
    }
}
