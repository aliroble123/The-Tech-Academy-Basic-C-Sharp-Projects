using System; // Provides access to Console input and output.

// Declares an interface that represents an object that can quit.
public interface IQuittable
{
    // Declares the Quit method; implementing classes must provide its behavior.
    void Quit();
}

// Declares the Employee class and requires it to implement IQuittable.
public class Employee : IQuittable
{
    // Stores the employee's first name.
    public string FirstName { get; set; }

    // Stores the employee's last name.
    public string LastName { get; set; }

    // Initializes a new Employee with the supplied first and last names.
    public Employee(string firstName, string lastName)
    {
        // Saves the supplied first name in the FirstName property.
        FirstName = firstName;

        // Saves the supplied last name in the LastName property.
        LastName = lastName;
    }

    // Implements the Quit method required by the IQuittable interface.
    public void Quit()
    {
        // Prints a message to confirm that this employee has quit.
        Console.WriteLine($"{FirstName} {LastName} has quit.");
    }
}

// Declares the application's entry-point class.
internal class Program
{
    // The Main method is where the console application starts running.
    private static void Main(string[] args)
    {
        // Creates an Employee object but stores its reference in an IQuittable variable.
        // This is polymorphism: an interface reference points to an implementing class object.
        IQuittable employee = new Employee("Ali", "Roble");

        // Calls the Employee implementation of Quit through the interface reference.
        employee.Quit();

        // Waits for the user to press Enter so the console window stays open.
        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();
    }
}
