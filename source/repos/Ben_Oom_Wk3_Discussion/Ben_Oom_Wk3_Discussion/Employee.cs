/*Employee.cs
 * Employee class with a SalaryAdjustment method
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

     // Employee constructor that receives three parameters
     public Employee(string firstName, string lastName, int monthlySalary)
        {
            Name = firstName + lastName; // Concatenate the inputted name strings
            AnnualSalary = monthlySalary; // AnnualSalary's set accessor validates the value
        }
     
     // AnnualSalary propery with validation
     public int AnnualSalary
        {
            get
            {
                return annualSalary;
            }
            private set // only to be used within the class for validation
            {
                // validating the salary is greater than 0; if it is not, the instance variable
                // annualSalary keeps its prior value
                if (value > 0)
                { 
                    annualSalary = value * 12; // multiplying monthly value to achieve annual
                }
            }
        }

     // method that can change the value of the AnnualSalary based on inputted adjustment to monthly
     public void SalaryAdjustment(int adjustment)
        {
            AnnualSalary = adjustment;
        }
    }
}
