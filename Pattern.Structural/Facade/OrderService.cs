using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Structural.Facade;


public class OrderService : IOrderService
{
    public void PlaceOrder(Order order)
    {
        throw new NotImplementedException();
    }

    public void RemoveOrder(Order order)
    {
        Console.WriteLine($"Order Id {order.Id} is removed");
    }
}




// Implementations
public class InventoryService : IInventoryService
{
    public bool IsInStock(int productId) => true;
}

public class PaymentService : IPaymentService
{
    public bool ProcessPayment(Order order) => true;
}

public class ShippingService : IShippingService
{
    public void ScheduleDelivery(Order order) => Console.WriteLine("Delivery scheduled.");
}

public class NotificationService : INotificationService
{
    public void SendOrderConfirmation(Order order) => Console.WriteLine("Order confirmed.");
}

