using System;

namespace EmployeeCalculatorSalary.Models;

public class FullTimeEmployee : Employee
{
    public FullTimeEmployee(string firstName, string lastName, string position, decimal monthlySalary)
        : base(firstName, lastName, position, monthlySalary) { } //empty curly braces are used cause the Employee instances and FullTimeEmployee are the same

    // Abstract method to calculate monthly salary
    public override decimal CalculateMonthlySalary()
    {
        return MonthlySalary; // Since it's a fulltime employee and the salary is static, we don't need to do anything else but return the value
    }

    // Abstract method to show employee info
    public override void DisplayInfo()
    {
        Console.WriteLine($"Full-Time Employee: {FirstName} {LastName}, Position: {Position}, Monthly Salary: {MonthlySalary:C}"); //:C makes the number in the money format of the region i'm located
    }
}
