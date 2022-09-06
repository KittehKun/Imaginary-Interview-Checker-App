using System;
using CSharp_Challenge_ImaginaryCodingInterview;

namespace CSharp_EmployeeCreation.classes
{
    public class Employee : IEmployee
    {
        // - Interface -
        public string Name { get; private set; }

        public int Age { get; private set; }

        public int LastSSN { get; private set; }


        // - Constructor -
        public Employee()
        {

        }

        
    }
}

