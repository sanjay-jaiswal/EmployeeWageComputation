
using System;

namespace EmployeeWage
{
    class Program
    {
        // constants declaration
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;

        /// <summary>
        /// Calculate emp wage using case statements
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("********Welome to Employee Wage Program***********");
            //local variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int employeeCheck = random.Next(0, 3);

            Console.WriteLine("random value " + employeeCheck);
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

            //Calculate employee's wages 
            empWage = EMP_RATE_PER_HOUR * empHrs;
            Console.WriteLine("Employee wage per day is : " + empWage);
            Console.ReadLine();
        }
    }
}