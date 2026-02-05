using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_Creator
{
    public enum WeaponType
    {
        SIMPLE,
        MARTIAL,
        CLUB,
        DAGGER,
        GREATCLUB,
        HANDAX,
        JAVELIN,
        LIGHTHAMMER,
        MACE,
        QUARTERSTAFF,
        SICKLE,
        SPEAR,
        LIGHTCROSSBOW,
        DART,
        SHORTBOW,
        SLING,
        BATTLEAX,
        FLAIL,
        GLAVE,
        GREATAX,
        GREATSWORD,
        HALBERD,
        LANCE,
        LONGSWORD,
        MAUL,
        MORNINGSTAR,
        PIKE,
        RAPIER,
        SCIMITAR,
        SHORTSWORD,
        TRIDENT,
        WARPICK,
        WARHAMMER,
        WHIP,
        BLOWGUN,
        HANDCROSSBOW,
        HEAVYCROSSBOW,
        LONGBOW,
        NET
    }

    public enum AttackRange
    {
        MELEE,
        RANGED
    }

    internal class Weapon : Item
    {
        public WeaponType category; //simple/martial/special
        public WeaponType type; //ie shortsword, longbow, quarterstaff, etc
        public AttackRange range;
        public int damageBonus = 0; //???
        public int damageDice = 0;
        public int numberOfDice = 0;
        public string damageType = "";
        public List<string> properties = new List<string>();
        public string description = "";


        public Weapon(string name, WeaponType category, WeaponType type, AttackRange range, int damageDice, int numberOfDice, string damageType, List<string> properties, string description) : base(name)
        {
            this.category= category;
            this.type = type;
            this.range = range;
            this.damageDice = damageDice;
            this.numberOfDice = numberOfDice;
            this.damageType = damageType;
            this.properties = properties;
            this.description = description;
        }

        /// <summary>
        /// Calculates the Damage Bonus of this weapon when used by an Equipping Character
        /// </summary>
        /// <param name="StrModifier">Equipping Character Strength Modifier</param>
        /// <param name="DexModifier">Equipping Character Dextarity Modifier</param>
        /// <param name="proficiencyBonus">Equipping Character Proficiency Bonus</param>
        /// <param name="weaponProficiencies">Equipping Character Weapon Proficiencies</param>
        /// <param name="additionalBonus">Any additional damage bonus that needs to be added on after (case by case). Defaults to zero.</param>
        public void calculateDamageBonus(int StrModifier, int DexModifier, int proficiencyBonus, List<WeaponType> weaponProficiencies, int additionalBonus = 0)
        {
            if(range == AttackRange.RANGED || ((properties.Contains("finesse") || properties.Contains("Finesse")) && DexModifier > StrModifier))
            {
                damageBonus = DexModifier;
            }
            else
            {
                damageBonus = StrModifier;
            }

            if(weaponProficiencies.Contains(category) || weaponProficiencies.Contains(type))
            {
                damageBonus += proficiencyBonus;
            }

            damageBonus += additionalBonus;
        }

        /// <summary>
        /// Allows other classes to see the damage bonus of this weapon.
        /// </summary>
        /// <returns>This weapon's current damage bonus</returns>
        public int getDamageBonus() { return damageBonus; }
    }
}
