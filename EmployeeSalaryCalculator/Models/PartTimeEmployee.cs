using System;

namespace EmployeeCalculatorSalary.Models;

public class PartTimeEmployee : Employee
{
    public decimal HourlyRate {get; set;}
    public int HoursWorked {get; set;}

    public PartTimeEmployee (string firstName, string lastName, string position, decimal hourlyRate, int hoursWorked) base: (firstName, lastName, position, 0)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public override calculateMonthlySalary()
    {
        return HourlyRate * HoursWorked;
    }
}

