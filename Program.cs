using System;

// Contains the entry point and demonstration code for the console application.
class Program
{
    // Main is the method that runs when the application starts.
    static void Main(string[] args)
    {
        // Create the first Employee object.
        Employee employee1 = new Employee();

        // Set the first employee's ID and name properties.
        employee1.Id = 101;
        employee1.FirstName = "Ali";
        employee1.LastName = "Roble";

        // Create the second Employee object.
        Employee employee2 = new Employee();

        // Set the second employee's ID and name properties.
        // The names are different, but the ID matches employee1.
        employee2.Id = 101;
        employee2.FirstName = "Ahmed";
        employee2.LastName = "Hassan";

        // Print the first employee's information to the console.
        Console.WriteLine("First Employee:");
        Console.WriteLine("ID: " + employee1.Id);
        Console.WriteLine("First Name: " + employee1.FirstName);
        Console.WriteLine("Last Name: " + employee1.LastName);

        // Print the second employee's information to the console.
        Console.WriteLine("\nSecond Employee:");
        Console.WriteLine("ID: " + employee2.Id);
        Console.WriteLine("First Name: " + employee2.FirstName);
        Console.WriteLine("Last Name: " + employee2.LastName);

        // Use the overloaded == operator to compare the employee IDs.
        Console.WriteLine("\nAre employees equal? " + (employee1 == employee2));

        // Use the overloaded != operator to check whether the IDs differ.
        Console.WriteLine("Are employees different? " + (employee1 != employee2));

        // Wait for Enter so the console window remains open after displaying results.
        Console.ReadLine();
    }
}
