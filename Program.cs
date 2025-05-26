using RegisterAnimals.Data;
using RegisterAnimals.Entities;
using RegisterAnimals.Services;

namespace RegisterAnimals;

public class Program
{
    public static void Main(string[] args)
    {
        var animalRepository = new AnimalRepository();
        RunTracker(animalRepository);

        Console.WriteLine("\n--- Event Handling Demo ---");

        var orderService = new OrderService();
        var notificationService = new NotificationService();
        var deliveryService = new DeliveryService();

        orderService.OrderPlaced += notificationService.NotifyCustomer;
        orderService.OrderPlaced += deliveryService.DeliverArticles;

        orderService.PlaceOrder();
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
        var animals = animalRepository.GetAllAnimals();
        Console.WriteLine("\nWildlife Tracker Summary:");
        Console.WriteLine($"Number of Elephants: {animals.Count(a => a is Elephant)}");
        Console.WriteLine($"Number of Lions: {animals.Count(a => a is Lion)}");
        Console.WriteLine($"Total Animals: {animals.Count}");
        Console.WriteLine("Thank you for using the Wildlife Tracker!");
    }
}
