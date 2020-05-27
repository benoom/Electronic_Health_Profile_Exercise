using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4._15_Digital_Health_Records
{
    class HealthProfile
    {
        // auto-implemented properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int DoBMonth { get; set; }
        public int DoBDay { get; set; }
        public int DoBYear { get; set; }
        public int HeightInInches { get; set; }
        public int WeightInPounds { get; set; }

        // Age property setup to allow set access only within the class
        public int Age { get; private set; }

        // HealthProfile constructor that receives eight parameters
        public HealthProfile(string firstName, string lastName, string gender,
            int doBMonth, int doBDay, int doBYear, int heightInInches,
            int weightInPounds)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DoBMonth = doBMonth;
            DoBDay = doBDay;
            DoBYear = doBYear;
            HeightInInches = heightInInches;
            WeightInPounds = weightInPounds;
        }
        
        // method to calculate the user's age in years based on the inputted month, day and year
        public int UserAge()
        {
            // store today's date as an integer after converting to yyyyMMdd format
            int today = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            // store user's birthdate as an integer after converting to yyyyMMdd format
            int dob = int.Parse(DoBYear.ToString() + DoBMonth.ToString("D2") + 
                DoBDay.ToString("D2"));
            // return the age in years after removing the extra digits
            return Age = (today - dob) / 10000;
        }

        // method to calculate and display max heart rate and the heart rate range for the user
        public void HeartRate()
        {
            int max = 220 - Age;
            Console.WriteLine($"Max heart rate: {max}");

            double lowTarget = 0.50 * max;
            double highTarget = 0.85 * max;
            Console.WriteLine($"Target heart rate range (50-85% of max): {lowTarget} - {highTarget}");
        }

        // method to calculate the body mass index for the user. will also display the results
        // and a table for the user to compare their results against
        public void BodyMassIndex()
        {
            double bmi = (WeightInPounds * 703) / (HeightInInches * HeightInInches);
            Console.WriteLine($"Body Mass Index (please refer to the reference chart below): {bmi}");
            Console.WriteLine("\nBMI Values\nUnderweight: less than 18.5\nNormal: between 18.5 and 24.9" +
                "\nOverweight: between 25 and 29.9\nObese: 30 or greater");
        }

        // method to display back to the user their information
        public void DisplayProfile()
        {
            Console.WriteLine("\nCongratulations your electronic health profile has been created!");
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Date of Birth: {DoBMonth}/{DoBDay}/{DoBYear}. Age: {Age}");
            Console.WriteLine($"Height in Inches: {HeightInInches}");
            Console.WriteLine($"Weight in Pounds: {WeightInPounds}");
            Console.WriteLine("Based on the information you entered, we calculated your Max Heart" +
                "Rate, Target Heart Rate Range, and BMI as follows\n");
        }
    } // end of HealthProfile class
}
