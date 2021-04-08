
using System;

namespace EmployeeWage
{
    class Program
    {
        // constants declaration
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAY = 20;

        /// <summary>
        /// Calculate emp wage using case statements
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("********Welome to Employee Wage Program***********");

            //Variables declaration
            int empHrs = 0, empWage = 0, totalEmpWage = 0;
            //Calculating wages

            for (int day = 0; day < NUM_OF_WORKING_DAY; day++)
            {
                Random random = new Random();
                int employeeCheck = random.Next(0, 3);
                switch (employeeCheck)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Employee wage is : " + empWage);
            }
            Console.WriteLine("Employee's wage monthly is : " + totalEmpWage);

        }
    }
}