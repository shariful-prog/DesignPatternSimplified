using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Structural.Facade;


// For simplicity, we will define all of the interfaces in a single file.

public interface IInventoryService
{
    bool IsInStock(int productId);
}
public interface IPaymentService
{
    bool ProcessPayment(Order order);
}
public interface IShippingService
{
    void ScheduleDelivery(Order order);
}
public interface INotificationService
{
    void SendOrderConfirmation(Order order);
}


public interface IOrderService
{
    void PlaceOrder(Order order);
    void RemoveOrder(Order order);

}
