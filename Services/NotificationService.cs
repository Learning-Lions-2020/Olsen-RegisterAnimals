using System;

namespace RegisterAnimals.Services;

public class NotificationService
{
    public void NotifyCustomer(object? sender, EventArgs e)
    {
        Console.WriteLine("Customer has been notified.");
    }
}