using System;
using EmployeeCalculatorSalary.Models;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        try
        {
            // try: first name error
            FullTimeEmployee employee1 = new FullTimeEmployee("Jacquelin3", "Jimenez", "Developer", 35000);
            employees.Add(employee1);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error creating name (invalid format) Use text only: {ex.Message}");
        }

        try
        {
            // try: last name error
            PartTimeEmployee employee2 = new PartTimeEmployee("Joe", "Do%%", "Designer", 50.50m, 80);
            employees.Add(employee2);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error creating name (invalid format) Use text only: {ex.Message}");
        }



        //Valid employees
        FullTimeEmployee employee3 = new FullTimeEmployee("Lola", "Young", "Manager", 60000);
        employees.Add(employee3);

        FullTimeEmployee employee4 = new FullTimeEmployee("Lana", "Del Rey", "Accountant", 55000);
        employees.Add(employee4);

        PartTimeEmployee employee5 = new PartTimeEmployee("Billie", "Eillish", "Designer UX/UI", 400, 80);
        employees.Add(employee5);

        // Print valid employees only - Only the valid employees can be listed
        foreach (var employee in employees)
        {
            employee.DisplayInfo();
        }
    }
}
