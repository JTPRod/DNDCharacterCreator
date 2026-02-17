using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum ArmorWeight
{
    LIGHT,
    MEDIUM,
    HEAVY,
    SHIELDS
}

namespace D_D_Character_Creator
{
    internal class Armor : Item
    {
        public ArmorWeight weight;
        public string description = "";
        public int baseAC = 0;
        public bool AddDex = false;


        public Armor(string name, ArmorWeight armorWeight, string description, int baseAC,  bool addDex) : base(name)
        {
            this.weight = armorWeight;
            this.description = description;
            this.baseAC = baseAC;
            this.AddDex = addDex;
        }


        /// <summary>
        /// Calculates character AC based on Armor
        /// </summary>
        /// <param name="dexModifier">Character Dex Modifier</param>
        /// <returns>Calculated Character AC</returns>
        public int CalculateAC(int dexModifier)
        {
            if(AddDex)
            {
                return baseAC + dexModifier;
            }
            else
            {
                return baseAC;
            }
        }
    }
}
