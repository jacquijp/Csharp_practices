using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Contact contact1 = new Contact("Jacqueline", "3329038645", "jacqui@gmail.com");
            Console.WriteLine(contact1.ContactInfo());
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error creating contact: {ex.Message}");
        }

        try 
        {
            //trying with wrong phone number
            Contact contact2 = new Contact("Paulo", "233ed", "email2@domain.com");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error creating contact: {ex.Message}");
        }

        try 
        {
            //trying wrong email
            Contact contact3 = new Contact("Paula", "018004333", "email@@os");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error creating contact: {ex.Message}");
        }
    }



}

