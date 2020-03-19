using System;
using System.Collections.Generic;
using System.Text;

namespace DunderMifflin
{
    class Employee
    {
        public string Name { get; }
        public DateTime HiredOn { get; }

        public Employee(string name, DateTime hiredOn)
        {
            Name = name;
            HiredOn = hiredOn;
        }
    }
}
