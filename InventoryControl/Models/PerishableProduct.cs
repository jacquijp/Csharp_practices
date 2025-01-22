using System;

namespace InventoryControl.Models
    public class PerishableProduct : Product
    {
        public dateTime ExpirationDate {get; set;}

        public PerishableProduct(string name, decimal price, int quantity, DateTime expirationDate) : base (name, price, quantity)
        {
            ExpirationDate = expirationDate;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Product: {Name}\n Price: {Price}\n Quantity: {Quantity}\n Expiration Date {ExpirationDate.ToShortDateString()}");
        }
    }

