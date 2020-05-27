using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4._15_Digital_Health_Records
{
    class HealthProfileTest
    {
        // start of Main method
        static void Main(string[] args)
        {
            // simple intro to the application for the user
            Console.WriteLine("Welcome to the electronic health profile system!\n" +
                "Please enter in the following information");

            // prompt and read input for the parameters we will initialize in the HealthProfile
            // object constructor
            Console.Write("First name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Gender: ");
            string gender = Console.ReadLine();

            Console.Write("Date of birth month (MM): ");
            int doBMonth = int.Parse(Console.ReadLine());

            Console.Write("Date of birth day (DD): ");
            int doBDay = int.Parse(Console.ReadLine());

            Console.Write("Date of birth year (YYYY): ");
            int doBYear = int.Parse(Console.ReadLine());

            Console.Write("Height in inches: ");
            int heightInInches = int.Parse(Console.ReadLine());

            Console.Write("Weight in pounds: ");
            int weightInPounds = int.Parse(Console.ReadLine());

            // initialize HealthProfile object using parameter values inputted by user
            HealthProfile profile1 = new HealthProfile(firstName, lastName, gender, doBMonth, doBDay,
                doBYear, heightInInches, weightInPounds);

            // call methods to calculate and display user information
            profile1.UserAge();
            profile1.DisplayProfile();
            profile1.HeartRate();
            profile1.BodyMassIndex();

            // keep the console open
            Console.Read();

        } // end of Main method
    } // end of HealthProfileTest class
}
