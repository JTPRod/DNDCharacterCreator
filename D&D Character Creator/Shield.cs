using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_Creator
{
    internal class Shield : Item
    {
        public int acIncrease = 0;


        public Shield(string name, int increaseInAC) : base(name)
        {
            acIncrease = increaseInAC;
        }

        /// <summary>
        /// Adds shield modifier to current character AC. Shield AC calculation should be executed after Armor AC calculation.
        /// </summary>
        /// <param name="currentAC">Current Character AC</param>
        /// <returns>Adjusted character AC</returns>
        public int AddToAC(int currentAC)
        {
            return acIncrease + currentAC;
        }
    }
}
