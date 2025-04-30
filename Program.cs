using Microsoft.EntityFrameworkCore;
using RegisterAnimals.Data;
using RegisterAnimals.Entities;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Test with AnimalSqlRepository
        Console.WriteLine("Testing with AnimalSqlRepository:");
        var sqlOptions = new DbContextOptionsBuilder<AnimalDbContext>()
            .UseInMemoryDatabase(databaseName: "WildlifeTrackerSql")
            .Options;
        var sqlRepository = new AnimalSqlRepository<Animal>(new AnimalDbContext(sqlOptions));
        RunTracker(sqlRepository);

        // Test with AnimalRepository
        Console.WriteLine("\nTesting with AnimalRepository:");
        var inMemoryRepository = new AnimalRepository();
        RunTracker(inMemoryRepository);
    }

    private static void RunTracker(IAnimalRepository<Animal> animalRepository)
    {
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
                    animalRepository.AddAnimal(new Elephant());
                    Console.WriteLine("Elephant added!\n");
                    break;
                case "2":
                    animalRepository.AddAnimal(new Lion());
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

        OutputAnimalCounts(animalRepository);
    }

    public static void OutputAnimalCounts(IAnimalRepository<Animal> animalRepository)
    {
        Console.WriteLine("\nWildlife Tracker Summary:");
        Console.WriteLine($"Number of Elephants: {animalRepository.GetElephantCount()}");
        Console.WriteLine($"Number of Lions: {animalRepository.GetLionCount()}");
        Console.WriteLine($"Total Animals: {animalRepository.GetTotalAnimalCount()}");
        Console.WriteLine("Thank you for using the Wildlife Tracker!");
    }
}