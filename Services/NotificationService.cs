namespace RegisterAnimals.Services;

public class NotificationService
{
    public void NotifyCustomer(object? sender, EventArgs e)
    {
        Console.WriteLine("NotificationService: Customer has been notified.");
    }
}
