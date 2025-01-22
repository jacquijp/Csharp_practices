
class Employee 
{
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string Position{get; set;}
    public decimal Salary{get; set;}

    public class Employee (string firstName, string lastName, string position, decimal salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Position = position;
        this.Salary = salary;
    }


}