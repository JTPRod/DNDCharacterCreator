using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_Creator
{
    public enum SpellLevel
    {
        CANTRIP,
        LEVEL1,
        LEVEL2,
        LEVEL3,
        LEVEL4,
        LEVEL5,
        LEVEL6,
        LEVEL7,
        LEVEL8,
        LEVEL9
    }


    internal class Spell
    {
        public string name = "";
        public string spellcastingAbility = "";
        public SpellLevel level;


        public Spell(string name, SpellLevel level)
        {
            this.name = name;
            this.level = level;
        }

        public void AddSpellcastingAbility(string spellcastingAbility)
        {
            this.spellcastingAbility = spellcastingAbility;
        }
    }
}
