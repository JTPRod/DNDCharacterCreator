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
        public static List<Skill> SkillDatabase = new List<Skill>();


        public Database()
        {
            CreateRaceDatabase();
            CreateClassDatabase();
            CreateSkillsDatabase();
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


        private void CreateSkillsDatabase()
        {
            //strength skills
            Skill strSavingThrow = new Skill("Strength Saving Throw", Stat.STRENGTH, true);
            SkillDatabase.Add(strSavingThrow);

            Skill athletics = new Skill("Athletics", Stat.STRENGTH, false);
            SkillDatabase.Add(athletics);

            //dexterity skills
            Skill dexSavingThrow = new Skill("Dexterity Saving Throw", Stat.DEXTERITY, true);
            SkillDatabase.Add(dexSavingThrow);

            Skill acrobatics = new Skill("Acrobatics", Stat.DEXTERITY, false);
            SkillDatabase.Add(acrobatics);

            Skill sleightOfHand = new Skill("Sleight Of Hand", Stat.DEXTERITY, false);
            SkillDatabase.Add(sleightOfHand);

            Skill stealth = new Skill("Stealth", Stat.DEXTERITY, false);
            SkillDatabase.Add(stealth);

            //constitution skills
            Skill conSavingThrow = new Skill("Constitution Saving Throw", Stat.CONSTITUTION, true);
            SkillDatabase.Add(conSavingThrow);


            //intelligence skills
            Skill intSavingThrow = new Skill("Intelligence Saving Throw", Stat.INTELLIGENCE, true);
            SkillDatabase.Add(intSavingThrow);

            Skill arcanca = new Skill("Arcana", Stat.INTELLIGENCE, false);
            SkillDatabase.Add(arcanca);

            Skill history = new Skill("History", Stat.INTELLIGENCE, false);
            SkillDatabase.Add(history);

            Skill investigation = new Skill("Investigation", Stat.INTELLIGENCE, false);
            SkillDatabase.Add(investigation);

            Skill nature = new Skill("Nature", Stat.INTELLIGENCE, false);
            SkillDatabase.Add(nature);

            Skill religioin = new Skill("Religion", Stat.INTELLIGENCE, false);
            SkillDatabase.Add(religioin);

            //wisdom skills
            Skill wisSavingThrow = new Skill("Wisdom Saving Throw", Stat.WISDOM, true);
            SkillDatabase.Add(wisSavingThrow);

            Skill animalHandling = new Skill("Animal Handling", Stat.WISDOM, false);
            SkillDatabase.Add(animalHandling);

            Skill insight = new Skill("Insight", Stat.WISDOM, false);
            SkillDatabase.Add(insight);

            Skill medicine = new Skill("Medicine", Stat.WISDOM, false);
            SkillDatabase.Add(medicine);

            Skill perception = new Skill("Perception", Stat.WISDOM, false);
            SkillDatabase.Add(perception);

            Skill survival = new Skill("Survival", Stat.WISDOM, false);
            SkillDatabase.Add(survival);


            //charisma skills
            Skill chaSavingThrow = new Skill("Charisma Saving Throw", Stat.CHARISMA, true);
            SkillDatabase.Add(chaSavingThrow);

            Skill deception = new Skill("Deception", Stat.CHARISMA, false);
            SkillDatabase.Add(deception);

            Skill intimidation = new Skill("Intimidation", Stat.CHARISMA, false);
            SkillDatabase.Add(intimidation);

            Skill performance = new Skill("Performance", Stat.CHARISMA, false);
            SkillDatabase.Add(performance);

            Skill pursuasion = new Skill("Persuasion", Stat.CHARISMA, false);
            SkillDatabase.Add(pursuasion);
        }
    }
}
