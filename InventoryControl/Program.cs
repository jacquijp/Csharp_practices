using System;
using InventoryControl.Models;

public static void Main[string[] args]
{
    Product fork = new product("Fork", 10, 100);
    PerishableProduct milk = new PerishableProduct("Milk", 25, 40, new DateTime(2025, 5, 10 ));
    ElectronicProduct tablet = new ElectronicProduct("Tablet", 2500, 4, new DateTime(2030, 10, 10));

    List<Product> products = new List<Product>(); //Initializing products list

    products.Add(fork);
    products.Add(milk);

}