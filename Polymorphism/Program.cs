using System;

namespace QuittableApp
{
    // Interface definition: IQuittable
    // This interface will enforce that any class that implements it 
    // will need to define the Quit() method
    public interface IQuittable
    {
        void Quit(); // This method signifies the action of quitting, 
                     // which will be implemented by any class that uses this interface.
    }

    // Employee class that implements the IQuittable interface
    // This class will inherit from IQuittable and provide its own implementation of the Quit() method
    public class Employee : IQuittable
    {
        public string Name { get; set; } // Property to hold the employee's name
        
        // Constructor to initialize the employee's name
        public Employee(string name)
        {
            Name = name;  // When creating an Employee object, the Name property will be set
        }

        // Implementing the Quit() method from IQuittable
        // In this case, we simply print a message to the console
        public void Quit()
        {
            Console.WriteLine($"{Name} has quit their job!"); 
            // This method prints a message indicating the employee has quit.
            // The {Name} is a placeholder for the employee's actual name.
        }
    }

    // Main Program where we demonstrate polymorphism and the IQuittable interface
    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism in action: Here we create an Employee object,
            // but we refer to it as an IQuittable interface type.
            IQuittable employee1 = new Employee("HebaTaha");

            // Calling the Quit() method on the IQuittable interface variable
            // The actual method executed is determined by the type of object assigned
            // (which in this case is an Employee object).
            employee1.Quit(); // John Doe has quit their job!

            // Note: Even though employee1 is of type IQuittable, 
            // since it points to an Employee object, the Employee's Quit() method gets called.
        }
    }
}
