public class PartTimeEmployee : Employee
{
    public decimal HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public PartTimeEmployee(string firstName, string lastName, string position, decimal hourlyRate, int hoursWorked)
        : base(firstName, lastName, position, 0) //salary starts with 0 but then it'll be recalculated
    {
        this.HourlyRate = hourlyRate;
        this.HoursWorked = hoursWorked;
        this.MonthlySalary = CalculateMonthlySalary(); // this way MonthlySalary is updated and recalculated
    }

    public override decimal CalculateMonthlySalary()
    {
        return HourlyRate * HoursWorked;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Part-Time Employee: {FirstName} {LastName}, Position: {Position}, Hourly Rate: {HourlyRate:C}, Hours Worked: {HoursWorked}, Monthly Salary: {MonthlySalary:C}");
    }
}