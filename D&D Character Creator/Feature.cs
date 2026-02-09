using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_Creator
{
    internal class Feature
    {
        public string name = "";
        public string description = "";
        public bool visible = false;    //Is this feature visible in the character sheet
        public int level = -1;  //at what level does this take effect?
        public int removeAtLevel = 100;   //at what level is this effect removed? (if applicable)

        public Feature(string name, string description, bool visible, int level, int removeAtLevel = 100) 
        {
            this.name = name;
            this.description = description;
            this.visible = visible;
            this.level = level;
            this.removeAtLevel = removeAtLevel;
        }

        /// <summary>
        /// Allows Feature Subclasses to make necessary changes to the CharacterObject class when added.
        /// </summary>
        public virtual void ExecuteFunctionality(CharacterObject character)
        {
            return;
        }
    }
}
