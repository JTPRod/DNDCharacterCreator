using System;

public class UserInterface
{
    public static List<CharacterObject> characterList = new List<CharacterObject>();

    public static void MainMenu()
    {
        bool exitProgram = false;
        while (!exitProgram)
        {
            Console.WriteLine("\n=============================================");
            Console.WriteLine("\nWelcome to DND! We have dungeons AND dragons, can you believe it?\n");
            Console.WriteLine("(1) - Create a Character");
            Console.WriteLine("(2) - View Existing Characters");
            Console.WriteLine("(3) - Delete a Character");
            Console.WriteLine("(0) - Exit");
            Console.WriteLine("Enter a number\n> ");

            string input = Console.ReadLine();
            int response;

            if (int.TryParse(input, out response))
            {
                switch (response)
                {
                    case 0:
                        exitProgram = true;
                        break;
                    case 1:
                        promptCreateCharacter();
                        break;

                    case 2:
                        promptViewCharacter();
                        break;

                    case 3:
                        PromptDeleteCharacter();
                        break;

                    default:
                        break;
                }
            }
        }
    }

    public static void promptCreateCharacter()
	{
        Console.WriteLine("\n=============================================");
        Console.WriteLine("\nWelcome to the Character Creator!");
        Console.WriteLine("Please enter a name for your character:\n> ");
        string characterName = Console.ReadLine();
        CharacterObject character = new CharacterObject(characterName);
        character.CreateCharacter();
        characterList.Add(character);
	}

    public static void PromptDeleteCharacter()
{
        Console.WriteLine("\n=============================================");
        // If there are no characters, stop
        if (characterList.Count == 0)
    {
        Console.WriteLine("\nThere are no characters to delete.");
        return;
    }

    // Show the characters with numbers
    for (int i = 0; i < characterList.Count; i++)
    {
        Console.WriteLine((i + 1) + ". " + characterList[i].name);
    }
        Console.WriteLine("Enter to Return to Main Menu");


        Console.Write("\nType the number of the character to delete: ");
    string input = Console.ReadLine();
    int number;

    if (int.TryParse(input, out number))
    {
        int index = number - 1;
        if (index >= 0 && index < characterList.Count)
        {
            deleteCharacter(characterList[index]);
            Console.WriteLine("\nCharacter deleted!\n");
        }
        else
        {
            Console.WriteLine("\nThat number is not on the list.\n");
        }
    }
    else
    {
        Console.WriteLine("\nYou must type a number.\n");
    }
}

    public static void promptViewCharacter()
{
        Console.WriteLine("\n=============================================");

        // If there are no characters, stop
        if (characterList.Count == 0)
    {
        Console.WriteLine("\nThere are no characters to view.\n");
        return;
    }

    // Show the characters with numbers
    for (int i = 0; i < characterList.Count; i++)
    {
        Console.WriteLine((i + 1) + ". " + characterList[i].name);
    }

    Console.WriteLine("Enter to Return to Main Menu");

    Console.Write("\nType the number of the character to view: ");
    string input = Console.ReadLine();
    int number;

    if (int.TryParse(input, out number))
    {
        int index = number - 1;
        if (index >= 0 && index < characterList.Count)
        {
                Console.WriteLine("\n=============================================\n");

                viewCharacter(characterList[index]);
        }
        else
        {
            Console.WriteLine("\nThat number is not on the list.\n");
        }
    }
    else
    {
        Console.WriteLine("\nYou must type a number.\n");
    }
}
    
	public static void viewCharacter(CharacterObject character)
    {
		Console.WriteLine(character.ToString());
    }

	public static void deleteCharacter(CharacterObject character)
    {
        characterList.Remove(character);
    }

    public UserInterface()
	{
	}
}