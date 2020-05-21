/*Employee.cs
 * Employee class with a AnnualSalary method
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ben_Oom_Wk3_Discussion
{
    class Employee
    {
     public string Name { get; set; } // auto-implemented property
     private int annualSalary; //instance variable

     public Employee(string firstName, string lastName, int monthlySalary)
        {
            Name = firstName + lastName;
            AnnualSalary = monthlySalary;
        }
     
     //AnnualSalary propery with validation
     public int AnnualSalary
        {
            get
            {
                return annualSalary;
            }
            private set //only to be used within the class for validation
            {
                //validating the salary is greater than 0; if it is not, the instance variable
                //annualSalary keeps its prior value
                if (value > 0)
                { 
                    annualSalary = value * 12;
                }
            }
        }
    }
}
