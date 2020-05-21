/* EmployeeTest.cs
 * Exercise 4.11 - Store and display the first and last name of an employee, along with their monthly
 * salary and annual salary. Utilizing Employee objects.
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
            //Initilize two Employee objects
            Employee employee1 = new Employee("Bob", "Lovelife", 9000);
            Employee employee2 = new Employee("Jane", "Olufsen", 4000);

            //Display salary of each object
            Console.WriteLine(
                $"{employee1.Name}'s annual salary: {employee1.AnnualSalary:C}");
            Console.WriteLine(
                $"{employee2.Name}'s annual salary: {employee2.AnnualSalary:C}");


        }
    }
}
