using System.Text.RegularExpressions; //Library to validate email and phone formats

class Contact 
{
    public string Name {get; set;} //properties of the class
    public string Phone {get; set;}
    public string Email {get; set;}

    public Contact(String name, string phone, string email) //constructor - defines how the methods are going to take the properties to act
    {
        if (!IsValidPhone(phone))
        {
            throw new ArgumentException("Phone must contain only numbers");
        }
        
        if (!IsValidEmail(email))
        {
            throw new ArgumentException("Invalid email format");
        }

        {
            Name = name;
            Phone = phone;
            Email = email;
        }
    }
    private bool IsValidPhone(string phone) //Method created to validate phone format
    {
        string phonePattern = @"^\d+$";
        return Regex.IsMatch(phone, phonePattern); //Regex.IsMatch is part of the library
    }

    private bool IsValidEmail (string email)
    {
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, emailPattern);
    }
    public string ContactInfo()
    {
        return $"Name: {Name}\nTel: {Phone}\nEmail: {Email}";
    }

}