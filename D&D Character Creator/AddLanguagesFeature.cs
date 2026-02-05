using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_Creator
{
    internal class AddLanguagesFeature : Feature
    {
        public List<string> Languages;

        public AddLanguagesFeature(string name, string description, int level, List<string> languages, int removeAtLevel = 100) : base(name, description, level, removeAtLevel)
        {
            Languages = languages;
        }

        /// <summary>
        /// Adds languages to a character
        /// </summary>
        /// <param name="character">The character that this feature belongs to</param>
        public void AddLanguages(CharacterObject character)
        {
            foreach (var language in Languages)
            {
                //Add language to character
            }

            throw new NotImplementedException();
        }

        public override void ExecuteFunctionality(CharacterObject character)
        {
            AddLanguages(character);
        }
    }




    internal class SelectLanguagesFeature : Feature
    {
        public List<string> Languages;
        public int numLanguagesToSelect = 0;

        public SelectLanguagesFeature(string name, string description, int level, List<string> languages, int numLanguagesToSelect, int removeAtLevel = 100) : base(name, description, level, removeAtLevel)
        {
            Languages = languages;
            this.numLanguagesToSelect = numLanguagesToSelect;
        }

        /// <summary>
        /// Allows user to select a number of languages from a list for the character to know
        /// </summary>
        /// <param name="character">The character that this feature belongs to</param>
        public void SelectLanguages(CharacterObject character)
        {
            while(numLanguagesToSelect > 0)
            {
                //Allow users to select a language from the list
                //Add laguage to character sheet
                //Decrement numLanguagesToLearn
            }

            throw new NotImplementedException();
        }

        public override void ExecuteFunctionality(CharacterObject character)
        {
            SelectLanguages(character);
        }
    }
}
