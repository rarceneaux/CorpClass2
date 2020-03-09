using System;

namespace CorpClass2
{
    public class Company
    {
        static void Main(string[] args)
        {
   
            var company = "Enterprise";
            string[] employees = {"Damon","Debo","Uncle Elroy" };
            Console.WriteLine(employees);
        }
         
        public string Name { get; set; }
        public string JobTitle { get; set; }

        public DateTime StartDate { get; set; }

            // Create a private property for holding a collection of current employees

            // Create a method that allows a caller to add an employee

            // Create a method that allows a caller to remove an employee

            // Create a method that allows a caller to retrieve the list of employees

            /*
                Create a constructor method that accepts two arguments:
                    1. The name of the company
                    2. The date it was created

                The constructor will set the value of the public properties
            */
        }
    }

