/* EmployeeTest.cs
 * Exercise 4.11 - Store and display the first and last name of an employee, along with their monthly
 * salary and annual salary. Allow for a single change to salary. Utilizing Employee objects.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ben_Oom_Wk3_Discussion
{
    class EmployeeTest 
    {
        static void Main(string[] args)
        {
            // Initilize two Employee objects
            Employee employee1 = new Employee("Bob ", "Lovelife", 9000);
            Employee employee2 = new Employee("Jane ", "Olufsen", 4000);

            // Display salary of each object
            Console.WriteLine(
                $"{employee1.Name}'s annual salary: {employee1.AnnualSalary:C}");
            Console.WriteLine(
                $"{employee2.Name}'s annual salary: {employee2.AnnualSalary:C}");

            // Prompt for and read input of adjusted monthly salary amount
            Console.Write($"\nEnter the new monthly salary for {employee1.Name}: ");
            int adjustment = int.Parse(Console.ReadLine());
            
            // change the monthly salary amount for employee1
            employee1.SalaryAdjustment(adjustment);

            // Prompt for and read input of adjusted monthly salary amount
            Console.Write($"Enter the new monthly salary for {employee2.Name}: ");
            adjustment = int.Parse(Console.ReadLine());

            // change the monthly salary amount for employee1
            employee2.SalaryAdjustment(adjustment);

            // display changed annual salary amounts
            Console.WriteLine(
                $"\n{employee1.Name}'s new salary is: {employee1.AnnualSalary:C}");
            Console.WriteLine(
                $"{employee2.Name}'s new salary is: {employee2.AnnualSalary:C}");

            // stop console from closing
            Console.ReadLine();
        }
    }
}
