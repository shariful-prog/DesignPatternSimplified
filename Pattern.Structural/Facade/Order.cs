using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Structural.Facade;

public class Order
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public double Amount { get; set; }
}