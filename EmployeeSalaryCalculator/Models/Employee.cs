using System.Text.RegularExpressions;

public abstract class Employee // Only abstract classes can create abstract methods and give them to dependant classes later
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Position { get; set; }
    public decimal MonthlySalary { get; set; }

    // Constructor
    public Employee(string firstName, string lastName, string position, decimal monthlySalary)
    {
        if (!IsValidFirstName(firstName))
        {
            throw new ArgumentException("First name must contain only letters and spaces.");
        }
        if (!IsValidLastName(lastName))
        {
            throw new ArgumentException("Last name must contain only letters and spaces.");
        }

        FirstName = firstName;
        LastName = lastName;
        Position = position;
        MonthlySalary = monthlySalary;
    }

    // Validating name
    private bool IsValidFirstName(string firstName)
    {
        string firstNamePattern = @"^[a-zA-Z\s]+$";
        return Regex.IsMatch(firstName, firstNamePattern);
    }

    // Validating last name
    private bool IsValidLastName(string lastName)
    {
        string lastNamePattern = @"^[a-zA-Z\s]+$";
        return Regex.IsMatch(lastName, lastNamePattern);
    }

    // Abstract methods
    public abstract decimal CalculateMonthlySalary(); 
    public abstract void DisplayInfo(); 
}
