using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_Creator
{
    internal class AddSpellFeature : Feature
    {
        public List<Spell> spells = new List<Spell>();
        public string modifier = "";

        public AddSpellFeature(string name, string description, int level, List<Spell> spells, string modifier, int removeAtLevel = 100) : base(name, description, level, removeAtLevel)
        {
            this.spells = spells;
            this.modifier = modifier;
        }

        
        
        /// <summary>
        /// Adds included spells to character spell list
        /// </summary>
        /// <param name="character">Character that this feature is being applied to</param>
        public void AddSpells(CharacterObject character)
        {
            if (character == null) return;

            foreach (Spell spell in spells)
            {
                spell.AddSpellcastingAbility(modifier);

                /////////////////Add spell to character spell list
            }

            throw new NotImplementedException();
        }


        public override void ExecuteFunctionality(CharacterObject character)
        {
            AddSpells(character);
        }

    }
}
