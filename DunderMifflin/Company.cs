using System;
using System.Collections.Generic;
using System.Text;

namespace DunderMifflin
{
    public class Company
    {
        // Some properties
        public string Name { get; }
        public DateTime CreatedOn { get; }
        public string Employee { get; set; }

        //private List<Employee>
    public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
        }

    // Create a method that allows a caller to add an employee

    // Create a method that allows a caller to remove an employee

    // Create a method that allows a caller to retrieve the list of employees

    }
}
