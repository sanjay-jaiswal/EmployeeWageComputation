using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Welome to Employee Wage Program***********");

            //Constants
            int EMP_RATE_PER_HOUR = 20;
            int FULL_TIME = 1;
            int PART_TIME = 2;
            //local variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int employeeCheck = random.Next(0, 3);

            Console.WriteLine("random value " + employeeCheck);
            if (employeeCheck == FULL_TIME)
            {
                empHrs = 8;
            }
            else if (employeeCheck == PART_TIME)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }

            empWage = EMP_RATE_PER_HOUR * empHrs;
            Console.WriteLine("Employee wage per day is : " + empWage);
            Console.ReadLine();
        }
    }
}