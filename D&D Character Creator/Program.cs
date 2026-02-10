// See https://aka.ms/new-console-template for more information
using D_D_Character_Creator;

Console.WriteLine("Hello, World!");


Console.WriteLine("this D&D Project is working and is now pushed");

Database database = new Database();

CharacterObject c = new CharacterObject("Marquacy");
c.CreateCharacter();

Console.WriteLine("\n\n" + c.ToString());