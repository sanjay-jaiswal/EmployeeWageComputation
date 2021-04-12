using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Welome to Employee Wage Program***********");
            Console.WriteLine("=====================================================================================================");

            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            EmpWageBuilderObject phonePay = new EmpWageBuilderObject("PhonePay", 15, 5, 22);
            dMart.computeEmpwage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpwage();
            Console.WriteLine(reliance.toString());
            phonePay.computeEmpwage();
            Console.WriteLine(phonePay.toString());
        }       
    }
}