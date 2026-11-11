using System;

// Represents an employee and stores the employee's identifying information.
public class Employee
{
    // Gets or sets the employee's unique identification number.
    public int Id { get; set; }

    // Gets or sets the employee's first name.
    public string FirstName { get; set; } = string.Empty;

    // Gets or sets the employee's last name.
    public string LastName { get; set; } = string.Empty;

    // Overloads == so two employees are equal when their IDs are equal.
    public static bool operator ==(Employee? employee1, Employee? employee2)
    {
        // Two references are equal if they point to the same object,
        // including when both references are null.
        if (ReferenceEquals(employee1, employee2))
        {
            return true;
        }

        // If only one reference is null, the employees are not equal.
        if (employee1 is null || employee2 is null)
        {
            return false;
        }

        // Compare the employee IDs; names do not affect equality.
        return employee1.Id == employee2.Id;
    }

    // Overloads != as the required pair for the == comparison operator.
    public static bool operator !=(Employee? employee1, Employee? employee2)
    {
        // Inequality is the logical opposite of equality.
        return !(employee1 == employee2);
    }

    // Overrides Equals so object-based equality uses the same ID comparison.
    public override bool Equals(object? obj)
    {
        // Return true only when obj is an Employee with the same ID.
        return obj is Employee employee && this == employee;
    }

    // Overrides GetHashCode so equal employees produce the same hash code.
    public override int GetHashCode()
    {
        // Use the employee ID because it determines equality.
        return Id.GetHashCode();
    }
}
