using System.Text.RegularExpressions;
class Employee 
{
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string Position {get; set;}
    public decimal MonthlySalary {get; set;}

    public Employee (string firstName, string lastName, string position, decimal monthlySalary)
    {
        if (!isValidFirstName(firstName))
        {
            throw new ArgumentException("Names must contain only letters");
        }
        if (!isValidLastName(lastName))
        {
            throw new ArgumentException("Names must contain only letters");
        }

        if (!isValidMonthlySalary(monthlySalary))
        {
            throw new ArgumentException("Salary must contain only numbers");
        }

        {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Position = position;
        this.MonthlySalary = monthlySalary;
        }
    }


    private bool isValidFirstName (string firstName)
    {
        string firstNamePattern = @"^[a-zA-Z\s]+$";
        return Regex.IsMatch(firstName, firstNamePattern);
    }
    private bool isValidLastName (string lastName)
    {
        string lastNamePattern = @"^[a-zA-Z\s]+$";
        return Regex.IsMatch(lastName, lastNamePattern);
    }
    private bool isValidMonthlySalary (decimal monthlySalary)
    {
        decimal monthlySalaryPattern = @"^\d+(\.\d+)?$";
        return monthlySalary > 0; //for decimal we only need to validate if it's bigger than 0
    }

    public abstract decimal calculateMonthlySalary(); //we declare the abstract method first in the base class

}