using PetStore;
using System.Text.Json;
using System.Text.Json.Serialization;

Console.WriteLine("Press 1 to add a product");
Console.WriteLine("Type 'exit' to quit");

string userInput = Console.ReadLine();

while (userInput.ToLower() != "exit")
{
    if (userInput == "1")
    {
        var dogLeash = new DogLeash();

        Console.WriteLine("Creating a dog leash...");

        Console.Write("Enter the material the leash is made out of: ");
        dogLeash.Material = Console.ReadLine();

        Console.Write("Enter the length in inches: ");
        dogLeash.LengthInches = int.Parse(Console.ReadLine());

        Console.Write("Enter the name of the leash: ");
        dogLeash.Name = Console.ReadLine();

        Console.Write("Give the product a short description: ");
        dogLeash.Description = Console.ReadLine();

        Console.Write("Give the product a price: ");
        dogLeash.Price = decimal.Parse(Console.ReadLine());

        Console.Write("How many products do you have on hand? ");
        dogLeash.Quantity = int.Parse(Console.ReadLine());

        Console.WriteLine(JsonSerializer.Serialize(dogLeash));
    }

    Console.WriteLine("Press 1 to add a product");
    Console.WriteLine("Type 'exit' to quit");
    userInput = Console.ReadLine();
}
