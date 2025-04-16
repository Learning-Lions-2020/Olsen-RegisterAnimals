using System;

public class Program
{
    public static void Main(string[] args)
    {
        AnimalRepository repository = new AnimalRepository();
        bool continueRunning = true;

        Console.WriteLine("Welcome to the Wildlife Tracker!");
        Console.WriteLine("Record sightings of elephants and lions in the national park.\n");

        while (continueRunning)
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Add an Elephant");
            Console.WriteLine("2. Add a Lion");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice (1-3): ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    repository.AddElephant();
                    Console.WriteLine("Elephant added!\n");
                    break;
                case "2":
                    repository.AddLion();
                    Console.WriteLine("Lion added!\n");
                    break;
                case "3":
                    continueRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please enter 1, 2, or 3.\n");
                    break;
            }
        }

        // Display final counts
        Console.WriteLine("\nWildlife Tracker Summary:");
        Console.WriteLine($"Number of Elephants: {repository.GetElephantCount()}");
        Console.WriteLine($"Number of Lions: {repository.GetLionCount()}");
        Console.WriteLine($"Total Animals: {repository.GetTotalAnimalCount()}");
        Console.WriteLine("Thank you for using the Wildlife Tracker!");
    }
}