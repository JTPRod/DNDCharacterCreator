using System;

public class UserInterface
{
	public static void mainMenu()
	{

		public List<CharacterObject> characterList = new List<CharacterObject>();
		Console.WriteLine("\nWelcome to DND! We have dungeons AND dragons, can you believe it?\n\nWould you like to\n" +
			"(1) - Create a Character\n" +
			"(2) - View Existing Characters\n" +
			"(3) - Delete a Character\n" +
			"(0) - Exit\n" +
			"\nPlease enter the corresponding number to select\n> ");
		int response = Console.ReadLine();
	}

	switch (response){
		case 1:
			promptCreateCharacter();
		case 2:
			promptViewCharacter();
		case 3:
			promptDeleteCharacter();
		default:
			exit();
	}


	public static void promptCreateCharacter()
	{
	}

	public static void promptDeleteCharacter(character)
    {
	//print out only character NAMES, pick one to delete
    }
	
public static void promptViewCharacter(character)
    {
	//print out only character NAMES, pick one to see full sheet
    }

	public static void createCharacter()
	{
		CharacterObject character = new CharacterObject();
		characterList.add(character);
	}
    
	public static void viewCharacters()
    {
		Console.WriteLine(characterList);
    }

	public static void deleteCharacter(character)
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