# Adapter Pattern

The **Adapter Pattern** is a structural design pattern that allows objects with incompatible interfaces to collaborate. It acts as a wrapper between two objects, catching calls for one object and transforming them to a format and interface recognizable by the second object.

## Problem

In this project, we have a modern payment processing system that uses the `IPaymentProcessor` interface. However, we need to integrate a legacy `OldPayPalClient` that has a completely different interface (uses strings, different method names, and double for amounts).

## Solution

We use the **Adapter Pattern** to create a `PayPalAdapter`. This adapter implements the `IPaymentProcessor` interface and wraps the `OldPayPalClient`. It translates the modern calls into a format the legacy client understands and parses the legacy responses back into our modern models.

## Components

1.  **Target (`IPaymentProcessor`)**: The interface used by the client code.
2.  **Adaptee (`OldPayPalClient`)**: The legacy class with an incompatible interface that needs adapting.
3.  **Adapter (`PayPalAdapter`)**: The class that implements the Target interface and translates calls to the Adaptee.
4.  **Client**: The code that uses the `IPaymentProcessor` to process payments (e.g., `PaymentProcessorFactory` consumers).

## Implementation Details

### Target Interface
```csharp
public interface IPaymentProcessor
{
    Task<PaymentResult> ProcessAsync(PaymentRequest request, CancellationToken ct = default);
    Task<RefundResult> RefundAsync(string transactionId, decimal amount, CancellationToken ct = default);
}
```

### Adaptee (Legacy)
```csharp
public class OldPayPalClient
{
    public string MakePayment(string cardNumber, double total, string currency) { ... }
    public string RefundPayment(string transactionId, double total) { ... }
}
```

### Adapter
The `PayPalAdapter` bridges the gap:
```csharp
public class PayPalAdapter : IPaymentProcessor
{
    private readonly OldPayPalClient _legacyClient;

    public Task<PaymentResult> ProcessAsync(PaymentRequest request, CancellationToken ct = default)
    {
        // 1. Convert modern request to legacy parameters
        var response = _legacyClient.MakePayment(request.CardNumber, (double)request.Amount, request.Currency);
        // 2. Parse legacy string response into modern PaymentResult
        return Task.FromResult(ParsePaymentResult(response));
    }
}
```

## When to use
- Use the Adapter class when you want to use some existing class, but its interface isn’t compatible with the rest of your code.
- Use the pattern when you want to reuse several existing subclasses that lack some common functionality that can’t be added to the superclass.