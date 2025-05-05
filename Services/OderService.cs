using System;

namespace RegisterAnimals.Services;

public class OrderService
{
    public event EventHandler OrderPlaced;

    public void PlaceOrder()
    {
        OnOrderPlaced(EventArgs.Empty);
    }

    protected virtual void OnOrderPlaced(EventArgs e)
    {
        OrderPlaced?.Invoke(this, e);
    }
}