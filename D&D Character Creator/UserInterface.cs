using System;

public class UserInterface
{
    public static void MainMenu()
    {
        Console.WriteLine("\nWelcome to DND! We have dungeons AND dragons, can you believe it?\n");
        Console.WriteLine("(1) - Create a Character");
        Console.WriteLine("(2) - View Existing Characters");
        Console.WriteLine("(3) - Delete a Character");
        Console.WriteLine("(0) - Exit");
        Console.Write("\nEnter a number: ");

        string input = Console.ReadLine();
        int response;

        if (int.TryParse(input, out response))
        {
            switch (response)
            {
                case 1:
                    promptCreateCharacter();
                    break;

                case 2:
                    promptViewCharacter();
                    break;

                case 3:
                    promptDeleteCharacter();
                    break;

                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }

    public static void promptCreateCharacter()
	{
	}

public static void PromptDeleteCharacter()
{
    // If there are no characters, stop
    if (characterList.Count == 0)
    {
        Console.WriteLine("There are no characters to delete.");
        return;
    }

    // Show the characters with numbers
    for (int i = 0; i < characterList.Count; i++)
    {
        Console.WriteLine((i + 1) + ". " + characterList[i].name);
    }

    Console.Write("Type the number of the character to delete: ");
    string input = Console.ReadLine();
    int number;

    if (int.TryParse(input, out number))
    {
        int index = number - 1;
        if (index >= 0 && index < characterList.Count)
        {
            deleteCharacter(characterList[index]);
            Console.WriteLine("Character deleted!");
        }
        else
        {
            Console.WriteLine("That number is not on the list.");
        }
    }
    else
    {
        Console.WriteLine("You must type a number.");
    }
}



public static void promptViewCharacter()
{
    // If there are no characters, stop
    if (characterList.Count == 0)
    {
        Console.WriteLine("There are no characters to delete.");
        return;
    }

    // Show the characters with numbers
    for (int i = 0; i < characterList.Count; i++)
    {
        Console.WriteLine((i + 1) + ". " + characterList[i].name);
    }

    Console.Write("Type the number of the character to view: ");
    string input = Console.ReadLine();
    int number;

    if (int.TryParse(input, out number))
    {
        int index = number - 1;
        if (index >= 0 && index < characterList.Count)
        {
            viewCharacter(characterList[index]);
            Console.WriteLine("Character deleted!");
        }
        else
        {
            Console.WriteLine("That number is not on the list.");
        }
    }
    else
    {
        Console.WriteLine("You must type a number.");
    }
}

	public static void createCharacter()
	{
		CharacterObject character = new CharacterObject();
		characterList.add(character);
	}
    
	public static void viewCharacter(character character)
    {
		Console.WriteLine(character.ToString());
    }

	public static void deleteCharacter(character character)
    {
		characterList.remove(character);
    }

    public static void exit()
    {
		
    }

    public UserInterface()
	{
	}
}