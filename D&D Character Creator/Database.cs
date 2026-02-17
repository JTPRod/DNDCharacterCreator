using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_Creator
{
    internal class Database
    {
        public static List<Feature> featureDatabase = new List<Feature>();
        public static List<Race> RaceDatabase = new List<Race>();
        public static List<CharacterClass> ClassDatabase = new List<CharacterClass>();
        public static List<Skill> SkillDatabase = new List<Skill>();


        public Database()
        {
            CreateSkillsDatabase();
            CreateFeatureDatabase();
            CreateRaceDatabase();
            CreateClassDatabase();
        }


        private void CreateRaceDatabase()
        {
            Race aasimar = new Race();
            aasimar.race = Race.Races.AASIMAR;
            aasimar.raceName = "Aasimar";
            aasimar.movementSpeed = 30;
            aasimar.abilityScoreIncreases = new Dictionary<string, int>
            {
                { "Charisma", 2 }
            };
            RaceDatabase.Add(aasimar);

            //add chameleon

            Race dragonborn = new Race();
            dragonborn.race = Race.Races.DRAGONBORN;
            dragonborn.raceName = "Dragonborn";
            dragonborn.movementSpeed = 30;
            dragonborn.abilityScoreIncreases = new Dictionary<string, int>
            {
               { "Strength", 2 },
                { "Charisma", 1 }
            };
            RaceDatabase.Add(dragonborn);

            Race dwarf = new Race();
            dwarf.race = Race.Races.DWARF;
            dwarf.raceName = "Dwarf";
            dwarf.movementSpeed = 25;
            dwarf.abilityScoreIncreases = new Dictionary<string, int>
            {
                { "Constitution", 2 }
            };
            RaceDatabase.Add(dwarf);

            Race elf = new Race();
            elf.race = Race.Races.ELF;
            elf.raceName = "Elf";
            elf.movementSpeed = 30;
            elf.abilityScoreIncreases = new Dictionary<string, int>
            {
                { "Dexterity", 2 }
            };
            elf.racialTraits = new List<Feature> { Helpers.FindFeature("Keen Senses", featureDatabase), Helpers.FindFeature("Languages (elf)", featureDatabase) };
            RaceDatabase.Add(elf);

            Race gnome = new Race();
            gnome.race = Race.Races.GNOME;
            gnome.raceName = "Gnome";
            gnome.movementSpeed = 25;
            gnome.abilityScoreIncreases = new Dictionary<string, int>
            {
                { "Intelligence", 2 }
            };
            RaceDatabase.Add(gnome);

            Race goliath = new Race();
            goliath.race = Race.Races.GOLIATH;
            goliath.raceName = "Goliath";
            goliath.movementSpeed = 30;
            goliath.abilityScoreIncreases = new Dictionary<string, int>
            {
                { "Strength", 2 },
                { "Constitution", 1 }
            };
            RaceDatabase.Add(goliath);

            Race halfling = new Race();
            halfling.race = Race.Races.HALFLING;
            halfling.raceName = "Halfling";
            halfling.movementSpeed = 25;
            halfling.abilityScoreIncreases = new Dictionary<string, int>
            {
                { "Dexterity", 2 }
            };
            RaceDatabase.Add(halfling);

            Race human = new Race();
            human.race = Race.Races.HUMAN;
            human.raceName = "Human";
            human.movementSpeed = 30;
            human.abilityScoreIncreases = new Dictionary<string, int>
            {
                { "Strength", 1 },
                { "Dexterity", 1 },
                { "Constitution", 1 },
                { "Intelligence", 1 },
                { "Wisdom", 1 },
                { "Charisma", 1 }
            };
            RaceDatabase.Add(human);

            Race orc = new Race();
            orc.race = Race.Races.ORC;
            orc.raceName = "Orc";
            orc.movementSpeed = 30;
            orc.abilityScoreIncreases = new Dictionary<string, int>
            {
                { "Strength", 2 },
                { "Constitution", 1 }
            };
            RaceDatabase.Add(orc);

            Race tiefling = new Race();
            tiefling.race = Race.Races.TIEFLING;
            tiefling.raceName = "Tiefling";
            tiefling.movementSpeed = 30;
            tiefling.abilityScoreIncreases = new Dictionary<string, int>
            {
                { "Charisma", 2 },
                { "Intelligence", 1 }
            };
            RaceDatabase.Add(tiefling);

        }

        private void CreateClassDatabase()
        {
            CharacterClass artificer = new CharacterClass();
            artificer.classType = CharacterClass.Classes.ARTIFICER;
            artificer.className = "Artificer";
            artificer.hitDice = 8;
            artificer.savingThrows = new List<string> { "Constitution", "Intelligence" };
            artificer.skillNum = 2;
            artificer.features = new List<Feature> {Helpers.FindFeature("Artificer Skill Proficiencies", featureDatabase)};
            ClassDatabase.Add(artificer);


            CharacterClass barbarian = new CharacterClass();
            barbarian.classType = CharacterClass.Classes.BARBARIAN;
            barbarian.className = "Barbarian";
            barbarian.hitDice = 12;
            barbarian.savingThrows = new List<string> { "Strength", "Constitution" };
            barbarian.skillNum = 2;
            barbarian.features = new List<Feature> {Helpers.FindFeature("Barbarian Skill Proficiencies", featureDatabase)};
            ClassDatabase.Add(barbarian);


            CharacterClass bard = new CharacterClass();
            bard.classType = CharacterClass.Classes.BARD;
            bard.className = "Bard";
            bard.hitDice = 8;
            bard.savingThrows = new List<string> { "Dexterity", "Charisma" };
            bard.skillNum = 3;
            bard.features = new List<Feature> {Helpers.FindFeature("Bard Skill Proficiencies", featureDatabase)};
            ClassDatabase.Add(bard);


            CharacterClass cleric = new CharacterClass();
            cleric.classType = CharacterClass.Classes.CLERIC;
            cleric.className = "Cleric";
            cleric.hitDice = 8;
            cleric.savingThrows = new List<string> { "Wisdom", "Charisma" };
            cleric.skillNum = 2;
            cleric.features = new List<Feature> {Helpers.FindFeature("Cleric Skill Proficiencies", featureDatabase)};            ClassDatabase.Add(cleric);


            CharacterClass druid = new CharacterClass();
            druid.classType = CharacterClass.Classes.DRUID;
            druid.className = "Druid";
            druid.hitDice = 8;
            druid.savingThrows = new List<string> { "Intelligence", "Wisdom" };
            druid.skillNum = 2;
            druid.features = new List<Feature> {Helpers.FindFeature("Druid Skill Proficiencies", featureDatabase)};
            ClassDatabase.Add(druid);


            CharacterClass fighter = new CharacterClass();
            fighter.classType = CharacterClass.Classes.FIGHTER;
            fighter.className = "Fighter";
            fighter.hitDice = 10;
            fighter.savingThrows = new List<string> { "Strength", "Constitution" };
            fighter.skillNum = 2;
            fighter.features = new List<Feature> {Helpers.FindFeature("Fighter Skill Proficiencies", featureDatabase)};            ClassDatabase.Add(fighter);


            CharacterClass monk = new CharacterClass();
            monk.classType = CharacterClass.Classes.MONK;
            monk.className = "Monk";
            monk.hitDice = 8;
            monk.savingThrows = new List<string> { "Strength", "Dexterity" };
            monk.skillNum = 2;
            monk.features = new List<Feature> {Helpers.FindFeature("Monk Skill Proficiencies", featureDatabase)};            ClassDatabase.Add(monk);


            CharacterClass paladin = new CharacterClass();
            paladin.classType = CharacterClass.Classes.PALADIN;
            paladin.className = "Paladin";
            paladin.hitDice = 10;
            paladin.savingThrows = new List<string> { "Wisdom", "Charisma" };
            paladin.skillNum = 2;
            paladin.features = new List<Feature> {Helpers.FindFeature("Paladin Skill Proficiencies", featureDatabase)};
            ClassDatabase.Add(paladin);


            CharacterClass ranger = new CharacterClass();
            ranger.classType = CharacterClass.Classes.RANGER;
            ranger.className = "Ranger";
            ranger.hitDice = 10;
            ranger.savingThrows = new List<string> { "Strength", "Dexterity" };
            ranger.skillNum = 3;
            ranger.features = new List<Feature> {Helpers.FindFeature("Ranger Skill Proficiencies", featureDatabase)};            ClassDatabase.Add(ranger);


            CharacterClass rogue = new CharacterClass();
            rogue.classType = CharacterClass.Classes.ROGUE;
            rogue.className = "Rogue";
            rogue.hitDice = 8;
            rogue.savingThrows = new List<string> { "Dexterity", "Intelligence" };
            rogue.skillNum = 4;
            rogue.features = new List<Feature> {Helpers.FindFeature("Rogue Skill Proficiencies", featureDatabase), Helpers.FindFeature("Rogue Proficiencies", featureDatabase), Helpers.FindFeature("Thieves' Cant", featureDatabase) };
            ClassDatabase.Add(rogue);


            CharacterClass sorcerer = new CharacterClass();
            sorcerer.classType = CharacterClass.Classes.SORCERER;
            sorcerer.className = "Sorcerer";
            sorcerer.hitDice = 6;
            sorcerer.savingThrows = new List<string> { "Constitution", "Charisma" };
            sorcerer.skillNum = 2;
            sorcerer.features = new List<Feature> {Helpers.FindFeature("Sorcerer Skill Proficiencies", featureDatabase)};            ClassDatabase.Add(sorcerer);


            CharacterClass warlock = new CharacterClass();
            warlock.classType = CharacterClass.Classes.WARLOCK;
            warlock.className = "Warlock";
            warlock.hitDice = 8;
            warlock.savingThrows = new List<string> { "Wisdom", "Charisma" };
            warlock.skillNum = 2;
            warlock.features = new List<Feature> {Helpers.FindFeature("Warlock Skill Proficiencies", featureDatabase)};            ClassDatabase.Add(warlock);


            CharacterClass wizard = new CharacterClass();
            wizard.classType = CharacterClass.Classes.WIZARD;
            wizard.className = "Wizard";
            wizard.hitDice = 6;
            wizard.savingThrows = new List<string> { "Intelligence", "Wisdom" };
            wizard.skillNum = 2;
            wizard.features = new List<Feature> {Helpers.FindFeature("Wizard Skill Proficiencies", featureDatabase)};            ClassDatabase.Add(wizard);

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

            Skill sleightOfHand = new Skill("Sleight of Hand", Stat.DEXTERITY, false);
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


        public void CreateFeatureDatabase()
        {
            //Artificer Features
            Feature artificerSkillProficiencies = new SelectProficienciesFeature(
                "Artificer Skill Proficiencies",
                "Skills: Choose two from Arcana, History, Investigation, Medicine, Nature, Perception, Sleight of Hand",
                false,
                1,
                new List<Skill> { Helpers.FindSkill("Arcana", SkillDatabase), Helpers.FindSkill("History", SkillDatabase), Helpers.FindSkill("Investigation", SkillDatabase), Helpers.FindSkill("Medicine", SkillDatabase), Helpers.FindSkill("Nature", SkillDatabase), Helpers.FindSkill("Perception", SkillDatabase), Helpers.FindSkill("Sleight of Hand", SkillDatabase) },
                2);
            featureDatabase.Add(artificerSkillProficiencies);


            //Barbarian Features
            Feature barbarianSkillProficiencies = new SelectProficienciesFeature(
                "Barbarian Skill Proficiencies",
                "Skills: Choose two from Animal Handling, Athletics, Intimidation, Nature, Perception, Survival",
                false,
                1,
                new List<Skill> { Helpers.FindSkill("Animal Handling", SkillDatabase), Helpers.FindSkill("Athletics", SkillDatabase), Helpers.FindSkill("Intimidation", SkillDatabase), Helpers.FindSkill("Nature", SkillDatabase), Helpers.FindSkill("Perception", SkillDatabase), Helpers.FindSkill("Survival", SkillDatabase) },
                2);
            featureDatabase.Add(barbarianSkillProficiencies);


            //Bard Features
            Feature bardSkillProficiencies = new SelectProficienciesFeature(
                "Bard Skill Proficiencies",
                "Skills: Choose any three skills",
                false,
                1,
                new List<Skill> { Helpers.FindSkill("Acrobatics", SkillDatabase), Helpers.FindSkill("Animal Handling", SkillDatabase), Helpers.FindSkill("Arcana", SkillDatabase), Helpers.FindSkill("Athletics", SkillDatabase), Helpers.FindSkill("Deception", SkillDatabase), Helpers.FindSkill("History", SkillDatabase), Helpers.FindSkill("Insight", SkillDatabase), Helpers.FindSkill("Intimidation", SkillDatabase), Helpers.FindSkill("Investigation", SkillDatabase), Helpers.FindSkill("Medicine", SkillDatabase), Helpers.FindSkill("Nature", SkillDatabase), Helpers.FindSkill("Perception", SkillDatabase), Helpers.FindSkill("Performance", SkillDatabase), Helpers.FindSkill("Persuasion", SkillDatabase), Helpers.FindSkill("Religion", SkillDatabase), Helpers.FindSkill("Sleight of Hand", SkillDatabase), Helpers.FindSkill("Stealth", SkillDatabase), Helpers.FindSkill("Survival", SkillDatabase) },
                3);
            featureDatabase.Add(bardSkillProficiencies);


            //Cleric Features
            Feature clericSkillProficiencies = new SelectProficienciesFeature(
                "Cleric Skill Proficiencies",
                "Skills: Choose two from History, Insight, Medicine, Persuasion, Religion",
                false,
                1,
                new List<Skill> { Helpers.FindSkill("History", SkillDatabase), Helpers.FindSkill("Insight", SkillDatabase), Helpers.FindSkill("Medicine", SkillDatabase), Helpers.FindSkill("Persuasion", SkillDatabase), Helpers.FindSkill("Religion", SkillDatabase) },
                2);
            featureDatabase.Add(clericSkillProficiencies);


            //Druid Features
            Feature druidSkillProficiencies = new SelectProficienciesFeature(
                "Druid Skill Proficiencies",
                "Skills: Choose two from Arcana, Animal Handling, Insight, Medicine, Nature, Perception, Religion, Survival",
                false,
                1,
                new List<Skill> { Helpers.FindSkill("Arcana", SkillDatabase), Helpers.FindSkill("Animal Handling", SkillDatabase), Helpers.FindSkill("Insight", SkillDatabase), Helpers.FindSkill("Medicine", SkillDatabase), Helpers.FindSkill("Nature", SkillDatabase), Helpers.FindSkill("Perception", SkillDatabase), Helpers.FindSkill("Religion", SkillDatabase), Helpers.FindSkill("Survival", SkillDatabase) },
                2);
            featureDatabase.Add(druidSkillProficiencies);


            //Fighter Features
            Feature fighterSkillProficiencies = new SelectProficienciesFeature(
                "Fighter Skill Proficiencies",
                "Skills: Choose two from Acrobatics, Animal Handling, Athletics, History, Insight, Intimidation, Perception, Survival",
                false,
                1,
                new List<Skill> { Helpers.FindSkill("Acrobatics", SkillDatabase), Helpers.FindSkill("Animal Handling", SkillDatabase), Helpers.FindSkill("Athletics", SkillDatabase), Helpers.FindSkill("History", SkillDatabase), Helpers.FindSkill("Insight", SkillDatabase), Helpers.FindSkill("Intimidation", SkillDatabase), Helpers.FindSkill("Perception", SkillDatabase), Helpers.FindSkill("Survival", SkillDatabase) },
                2);
            featureDatabase.Add(fighterSkillProficiencies);


            //Monk Features
            Feature monkSkillProficiencies = new SelectProficienciesFeature(
                "Monk Skill Proficiencies",
                "Skills: Choose two from Acrobatics, Athletics, History, Insight, Religion, Stealth",
                false,
                1,
                new List<Skill> { Helpers.FindSkill("Acrobatics", SkillDatabase), Helpers.FindSkill("Athletics", SkillDatabase), Helpers.FindSkill("History", SkillDatabase), Helpers.FindSkill("Insight", SkillDatabase), Helpers.FindSkill("Religion", SkillDatabase), Helpers.FindSkill("Stealth", SkillDatabase) },
                2);
            featureDatabase.Add(monkSkillProficiencies);


            //Paladin Features
            Feature paladinSkillProficiencies = new SelectProficienciesFeature(
                "Paladin Skill Proficiencies",
                "Skills: Choose two from Athletics, Insight, Intimidation, Medicine, Persuasion, Religion",
                false,
                1,
                new List<Skill> { Helpers.FindSkill("Athletics", SkillDatabase), Helpers.FindSkill("Insight", SkillDatabase), Helpers.FindSkill("Intimidation", SkillDatabase), Helpers.FindSkill("Medicine", SkillDatabase), Helpers.FindSkill("Persuasion", SkillDatabase), Helpers.FindSkill("Religion", SkillDatabase) },
                2);
            featureDatabase.Add(paladinSkillProficiencies);


            //Ranger Features
            Feature rangerSkillProficiencies = new SelectProficienciesFeature(
                "Ranger Skill Proficiencies",
                "Skills: Choose three from Animal Handling, Athletics, Insight, Investigation, Nature, Perception, Stealth, Survival",
                false,
                1,
                new List<Skill> { Helpers.FindSkill("Animal Handling", SkillDatabase), Helpers.FindSkill("Athletics", SkillDatabase), Helpers.FindSkill("Insight", SkillDatabase), Helpers.FindSkill("Investigation", SkillDatabase), Helpers.FindSkill("Nature", SkillDatabase), Helpers.FindSkill("Perception", SkillDatabase), Helpers.FindSkill("Stealth", SkillDatabase), Helpers.FindSkill("Survival", SkillDatabase) },
                3);
            featureDatabase.Add(rangerSkillProficiencies);


            //Rogue Features
            Feature rogueSkillProficiencies = new SelectProficienciesFeature(
                "Rogue Skill Proficiencies",
                "Skills: Choose four from Acrobatics, Athletics, Deception, Insight, Intimidation, Investigation, Perception, Performance, Persuasion, Sleight of Hand, and Stealth",
                false,
                1,
                new List<Skill> { Helpers.FindSkill("Acrobatics", SkillDatabase), Helpers.FindSkill("Athletics", SkillDatabase), Helpers.FindSkill("Deception", SkillDatabase), Helpers.FindSkill("Insight", SkillDatabase), Helpers.FindSkill("Intimidation", SkillDatabase), Helpers.FindSkill("Investigation", SkillDatabase), Helpers.FindSkill("Perception", SkillDatabase), Helpers.FindSkill("Performance", SkillDatabase), Helpers.FindSkill("Persuasion", SkillDatabase), Helpers.FindSkill("Sleight of Hand", SkillDatabase), Helpers.FindSkill("Stealth", SkillDatabase) },
                4);
            featureDatabase.Add(rogueSkillProficiencies);

            Feature rogueProficiencies = new AddProficienciesFeature(
                "Rogue Proficiencies",
                "Armor: Light armor\nWeapons: Simple weapons, hand crossbows, longswords, rapiers, shortswords\nTools: Thieves' tools\nSaving Throws: Dexterity, Intelligence",
                false,
                1,
                new List<Skill> { Helpers.FindSkill("Dexterity Saving Throw", SkillDatabase), Helpers.FindSkill("Intelligence Saving Throw", SkillDatabase) },
                new List<WeaponType> { WeaponType.SIMPLE, WeaponType.HANDCROSSBOW, WeaponType.LONGSWORD, WeaponType.RAPIER, WeaponType.SHORTSWORD },
                new List<Item> { },
                new List<ArmorWeight> { ArmorWeight.LIGHT },
                new List<string> { "Thieves' tools" }
                );
            featureDatabase.Add(rogueProficiencies);

            Feature ThievesCant = new AddLanguagesFeature(
                "Thieves' Cant",
                "During your rogue training you learned thieves' cant, a secret mix of dialect, jargon, and code that allows you to hide messages in seemingly normal conversation. Only another creature that knows thieves' cant understands such messages. It takes four times longer to convey such a message than it does to speak the same idea plainly.\n\nIn addition, you understand a set of secret signs and symbols used to convey short, simple messages, such as whether an area is dangerous or the territory of a thieves' guild, whether loot is nearby, or whether the people in an area are easy marks or will provide a safe house for thieves on the run.",
                true,
                1,
                new List<string> { "Thieves' Cant" }
                );
            featureDatabase.Add(ThievesCant);


            //Sorcerer Features
            Feature sorcererSkillProficiencies = new SelectProficienciesFeature(
                "Sorcerer Skill Proficiencies",
                "Skills: Choose two from Arcana, Deception, Insight, Intimidation, Persuasion, Religion",
                false,
                1,
                new List<Skill> { Helpers.FindSkill("Arcana", SkillDatabase), Helpers.FindSkill("Deception", SkillDatabase), Helpers.FindSkill("Insight", SkillDatabase), Helpers.FindSkill("Intimidation", SkillDatabase), Helpers.FindSkill("Persuasion", SkillDatabase), Helpers.FindSkill("Religion", SkillDatabase) },
                2);
            featureDatabase.Add(sorcererSkillProficiencies);


            //Warlock Features
            Feature warlockSkillProficiencies = new SelectProficienciesFeature(
                "Warlock Skill Proficiencies",
                "Skills: Choose two from Arcana, Deception, History, Intimidation, Investigation, Nature, Religion",
                false,
                1,
                new List<Skill> { Helpers.FindSkill("Arcana", SkillDatabase), Helpers.FindSkill("Deception", SkillDatabase), Helpers.FindSkill("History", SkillDatabase), Helpers.FindSkill("Intimidation", SkillDatabase), Helpers.FindSkill("Investigation", SkillDatabase), Helpers.FindSkill("Nature", SkillDatabase), Helpers.FindSkill("Religion", SkillDatabase) },
                2);
            featureDatabase.Add(warlockSkillProficiencies);


            //Wizard Features
            Feature wizardSkillProficiencies = new SelectProficienciesFeature(
                "Wizard Skill Proficiencies",
                "Skills: Choose two from Arcana, History, Insight, Investigation, Medicine, Religion",
                false,
                1,
                new List<Skill> { Helpers.FindSkill("Arcana", SkillDatabase), Helpers.FindSkill("History", SkillDatabase), Helpers.FindSkill("Insight", SkillDatabase), Helpers.FindSkill("Investigation", SkillDatabase), Helpers.FindSkill("Medicine", SkillDatabase), Helpers.FindSkill("Religion", SkillDatabase) },
                2);
            featureDatabase.Add(wizardSkillProficiencies);


            //Elf Features
            Feature keenSenses = new AddProficienciesFeature(
               "Keen Senses",
               "You have proficiency in the Perception skill.",
               true,
               1,
               new List<Skill> { Helpers.FindSkill("Perception", SkillDatabase) }
               );
            featureDatabase.Add(keenSenses);

            Feature ElfLanguages = new AddLanguagesFeature(
               "Languages (elf)",
               "You can speak, read, and write Common and Elven.",
               false,
               1,
               new List<string> { "Common", "Elven" }
               );
            featureDatabase.Add(ElfLanguages);
        }
    }

    internal static class Helpers
    {
        public static Skill FindSkill(string name, List<Skill> list)
        {
            Skill s = null;
            foreach(Skill skill in list)
            {
                if(skill.getName().Equals(name)) s = skill;
            }

            return s;
        }

        public static Feature FindFeature(string name, List<Feature> list)
        {
            Feature f = null;
            foreach (Feature feature in list)
            {
                if (feature.name.Equals(name)) f = feature;
            }

            return f;
        }

        public static string GetWeaponTypeString(WeaponType type)
        {
            string weaponName = null;
            switch (type)
            {
                case WeaponType.SIMPLE:
                    weaponName = "Simple Weapon";
                    break;
                case WeaponType.MARTIAL:
                    weaponName = "Martial Weapon";
                    break;
                case WeaponType.CLUB:
                    weaponName = "Club";
                    break;
                case WeaponType.DAGGER:
                    weaponName = "Dagger";
                    break;
                case WeaponType.GREATCLUB:
                    weaponName = "Great Club";
                    break;
                case WeaponType.HANDAX:
                    weaponName = "Handaxe";
                    break;
                case WeaponType.JAVELIN:
                    weaponName = "Javelin";
                    break;
                case WeaponType.LIGHTHAMMER:
                    weaponName = "Light Hammer";
                    break;
                case WeaponType.MACE:
                    weaponName = "Mace";
                    break;
                case WeaponType.QUARTERSTAFF:
                    weaponName = "Quarterstaff";
                    break;
                case WeaponType.SICKLE:
                    weaponName = "Sickle";
                    break;
                case WeaponType.SPEAR:
                    weaponName = "Spear";
                    break;
                case WeaponType.LIGHTCROSSBOW:
                    weaponName = "Light Crossbow";
                    break;
                case WeaponType.DART:
                    weaponName = "Dart";
                    break;
                case WeaponType.SHORTBOW:
                    weaponName = "Shortbow";
                    break;
                case WeaponType.SLING:
                    weaponName = "Sling";
                    break;
                case WeaponType.BATTLEAX:
                    weaponName = "Battleaxe";
                    break;
                case WeaponType.FLAIL:
                    weaponName = "Flail";
                    break;
                case WeaponType.GLAVE:
                    weaponName = "Glave";
                    break;
                case WeaponType.GREATAX:
                    weaponName = "Greataxe";
                    break;
                case WeaponType.GREATSWORD:
                    weaponName = "Greatsword";
                    break;
                case WeaponType.HALBERD:
                    weaponName = "Halberd";
                    break;
                case WeaponType.LANCE:
                    weaponName = "Lance";
                    break;
                case WeaponType.LONGSWORD:
                    weaponName = "Longsword";
                    break;
                case WeaponType.MAUL:
                    weaponName = "Maul";
                    break;
                case WeaponType.MORNINGSTAR:
                    weaponName = "Morningstar";
                    break;
                case WeaponType.PIKE:
                    weaponName = "Pike";
                    break;
                case WeaponType.RAPIER:
                    weaponName = "Rapier";
                    break;
                case WeaponType.SCIMITAR:
                    weaponName = "Scimitar";
                    break;
                case WeaponType.SHORTSWORD:
                    weaponName = "Shortsword";
                    break;
                case WeaponType.TRIDENT:
                    weaponName = "Trident";
                    break;
                case WeaponType.WARPICK:
                    weaponName = "Warpick";
                    break;
                case WeaponType.WARHAMMER:
                    weaponName = "Warhammer";
                    break;
                case WeaponType.WHIP:
                    weaponName = "Whip";
                    break;
                case WeaponType.BLOWGUN:
                    weaponName = "Blowgun";
                    break;
                case WeaponType.HANDCROSSBOW:
                    weaponName = "Hand Crossbow";
                    break;
                case WeaponType.HEAVYCROSSBOW:
                    weaponName = "Heavy Crossbow";
                    break;
                case WeaponType.LONGBOW:
                    weaponName = "Longbow";
                    break;
                case WeaponType.NET:
                    weaponName = "Net";
                    break;
                default:
                    break;
            }
            return weaponName;
        }


        public static string GetArmorWeightString(ArmorWeight armor)
        {
            string armorName = null;

            switch (armor)
            {
                case ArmorWeight.LIGHT:
                    armorName = "Light Armor";
                    break;
                case ArmorWeight.MEDIUM:
                    armorName = "Medium Armor";
                    break;
                case ArmorWeight.HEAVY:
                    armorName = "Heavy Armor";
                    break;
                case ArmorWeight.SHIELDS:
                    armorName = "Shields";
                    break;
                default:
                    break;
            }
            return armorName;
        }
    }
}
