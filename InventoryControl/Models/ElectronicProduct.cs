using System;

namespace InventoryControl.Models
{
    public class ElectronicProduct : Product
    {
        public DateTime WarrantyDate { get; set; }

        public ElectronicProduct(string name, decimal price, int quantity, DateTime warrantyDate) : base (name, price, quantity)
        {
            this.WarrantyDate = warrantyDate;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Product: {Name}\n Price: {Price}\n Quantity: {Quantity}\n Warranty Date: {WarrantyDate.ToShortDateString()}");
        }
    }
}
