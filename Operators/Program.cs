using System;

namespace EmployeeApp
{
    // Define the Employee class that will store employee details
    public class Employee
    {
        // Define properties for the Employee class
        // The Id property will be used to compare Employee objects.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the '==' operator to compare two Employee objects based on their Id
        public static bool operator ==(Employee e1, Employee e2)
        {
            // If either of the Employee objects is null, treat them as not equal
            if (ReferenceEquals(e1, null) || ReferenceEquals(e2, null))
                return false;

            // Compare the Id properties of the two Employee objects
            return e1.Id == e2.Id;
        }

        // Overload the '!=' operator to check if two Employee objects are not equal
        public static bool operator !=(Employee e1, Employee e2)
        {
            // The negation of the '==' operator can be used to define '!='
            return !(e1 == e2);
        }

        // Override the 'Equals' method for good practice when overloading operators
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Employee))
                return false;

            Employee other = (Employee)obj;
            return this.Id == other.Id;  // Check if Ids are equal
        }

        // Override the 'GetHashCode' method to ensure consistency when comparing
        public override int GetHashCode()
        {
            return this.Id.GetHashCode(); // Use the Id's hash code
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create two Employee objects and assign values to their properties
            Employee emp1 = new Employee { Id = 101, FirstName = "Heba", LastName = "Taha" };
            Employee emp2 = new Employee { Id = 101, FirstName = "Jane", LastName = "John" };

            // Display the details of the Employee objects
            Console.WriteLine($"Employee 1: {emp1.FirstName} {emp1.LastName}, ID: {emp1.Id}");
            Console.WriteLine($"Employee 2: {emp2.FirstName} {emp2.LastName}, ID: {emp2.Id}");

            // Compare the two Employee objects using the overloaded '==' operator
            if (emp1 == emp2)
            {
                Console.WriteLine("The two employees are the same (based on Id).");
            }
            else
            {
                Console.WriteLine("The two employees are different (based on Id).");
            }

            // Compare the two Employee objects using the overloaded '!=' operator
            if (emp1 != emp2)
            {
                Console.WriteLine("The two employees are different (based on Id).");
            }
            else
            {
                Console.WriteLine("The two employees are the same (based on Id).");
            }

            // To prevent the console from closing immediately after execution
            Console.ReadLine();
        }
    }
}
