using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_Creator
{
    internal class Database
    {
        public static List<Race> RaceDatabase = new List<Race>();
        public static List<CharacterClass> ClassDatabase = new List<CharacterClass>();


        public Database()
        {
            CreateRaceDatabase();
            CreateClassDatabase();
        }


        private void CreateRaceDatabase()
        {
            Race elf = new Race();
            elf.race = Race.Races.ELF;
            elf.raceName = "Elf";
            elf.movementSpeed = 30;
            elf.abilityScoreIncreases = new Dictionary<string, int>
            {
                { "Dexterity", 2 }
            };

            RaceDatabase.Add(elf);
        }

        private void CreateClassDatabase()
        {
            CharacterClass rogue = new CharacterClass();
            rogue.classType = CharacterClass.Classes.ROGUE;
            rogue.className = "Rogue";
            rogue.hitDice = 8;
            rogue.savingThrows = new List<string> { "Dexterity", "Intelligence" };
            rogue.skillNum = 4;

            ClassDatabase.Add(rogue);

          

        }

    }
}
