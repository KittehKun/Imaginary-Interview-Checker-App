using System;
using CSharp_Challenge_ImaginaryCodingInterview;
using CSharp_Challenge_ImaginaryCodingInterview.classes;

namespace CSharp_EmployeeCreation.classes
{
    public class Employee : IEmployee
    {
        // - Interface -
        public string Name { get; private set; }

        public int Age { get; private set; }

        public string LastSSN { get; private set; }

        // - Fields -
        Interview interviewee;

        // - Constructor -
        public Employee(Interview interviewee)
        {
            this.Name = "Unknown";
            this.Age = 0;
            this.LastSSN = "";
            this.interviewee = interviewee;
        }

        public void CreateEmployee()
        {
            Console.WriteLine("Do you want to create a new employee? [Y/N]");
            string? choice = Console.ReadLine()!.ToUpper();
            string name;
            int age;
            bool isValidSSN = false;
            int lastSSN;
            string SSN;

            if(choice != null && choice == "Y" && interviewee.IsQualified)
            {

                // - Setting Name Property -
                Console.WriteLine("\nEnter the employee's name:");
                name = Console.ReadLine()!;
                while (string.IsNullOrEmpty(name)) //Input validation loop
                {
                    Console.WriteLine("Name cannot be empty. Please enter a valid name:");
                    name = Console.ReadLine()!;
                }
                this.Name = name;

                // - Setting Age Property -
                Console.WriteLine("Enter the employee's age:");
                while(!int.TryParse(Console.ReadLine(), out age)) //Input validation loop
                {
                    Console.WriteLine("Please enter a valid age:");
                }
                this.Age = age;

                // - Setting SSN Property -
                Console.WriteLine("Enter the employee's last four digits of their SSN:");
                do //Secondary validation loop
                {
                    while(!int.TryParse(Console.ReadLine(), out lastSSN)) //Input validation loop
                    {
                        Console.WriteLine("Please enter a valid SSN:");
                    }

                    SSN = lastSSN.ToString();

                    if(SSN.Length == 4)
                    {
                        isValidSSN = true;
                    } else
                    {
                        Console.WriteLine("SSN must be 4 digits long.");
                    }
                } while (!isValidSSN);
                this.LastSSN = SSN;

                Console.WriteLine("\nEmployee created successfully!");

            } else if(!interviewee.IsQualified)
            {
                Console.WriteLine("Cannot create a new employee. Candidate is not qualified.");
            } else
            {
                Console.WriteLine("\nEmployee will not be created.");
            }
            
        }
        
    }
}

