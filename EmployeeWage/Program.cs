using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Welome to Employee Wage Program***********");
            Console.WriteLine("=====================================================================================================");

            //Creating the object of EmpWageBuilderArray
            EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray();
            //Calling the addCompanyEmpWage() method using object of class and Passing the argument.
            empWageBuilderArray.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilderArray.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilderArray.addCompanyEmpWage("Samsung", 25, 5, 22);
            empWageBuilderArray.addCompanyEmpWage("Facebook", 30, 6, 25);
            empWageBuilderArray.addCompanyEmpWage("PhonePay", 22, 6, 21);
            empWageBuilderArray.computeEmpWage();

            //Display company wise total wage
            Console.WriteLine("");
            Console.WriteLine("Total wage for Dmart company is= " + empWageBuilderArray.getTotalWage("Dmart"));
            Console.WriteLine("Total wage for Reliance company is= " + empWageBuilderArray.getTotalWage("Reliance"));
            Console.WriteLine("Total wage for Samsung company is= " + empWageBuilderArray.getTotalWage("Samsung"));
            Console.WriteLine("Total wage for Facebook company is= " + empWageBuilderArray.getTotalWage("Facebook"));
            Console.WriteLine("Total wage for PhonePay company is= " + empWageBuilderArray.getTotalWage("PhonePay"));
        }
    }
}