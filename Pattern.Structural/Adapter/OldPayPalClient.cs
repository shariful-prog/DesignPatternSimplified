using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Structural.Adapter;

public class OldPayPalClient
{
    public string MakePayment(string cardNumber, double total, string currency)
    {
        return $"ACK=SUCCESS&TRANSACTIONID=TX12345&AMOUNT={total}&CURRENCY={currency}";
    }

    public string RefundPayment(string transactionId, double total)
    {
        return $"ACK=SUCCESS&REFUNDTRANSACTIONID=RF12345&AMOUNT={total}";
    }
}