namespace RegisterAnimals.Services;

public class OrderService
{
    public event EventHandler OrderPlaced;

    public void PlaceOrder()
    {
        Console.WriteLine("Order has been placed.");
        OnOrderPlaced();
    }

    protected virtual void OnOrderPlaced()
    {
        OrderPlaced?.Invoke(this, EventArgs.Empty);
    }
}