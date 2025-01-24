using System;

namespace EmployeeCalculatorSalary.Models;

public class FullTimeEmployee : Employee
{
    public FullTimeEmployee (string firstName, string lastName, string position, decimal monthlySalary) : base (firstName, lastName, position, monthlySalary) {}

    public override calculateMonthlySalary()
    {
        return MonthlySalary();
    }
}