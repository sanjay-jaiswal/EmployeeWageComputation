using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeWage;

namespace MSTestForEmpWage
{
    [TestClass]
    public class UnitTest1
    {
        EmpWageBuilderArray empwage;

        public void Setup()
        {
            ///follow AAA rule
            ///Arrangr(create a object, input)
           // empwage = new CompanyEmpWage("Dmart", 12, 32, 12);
        }


        [TestMethod]
        [DataRow(10,20)]
        [DataRow(30,20)]
        public void GivenTwoNumbersOfInputForResultingAddition(int number1,int number2)
        {
            //Act
            int expected = number1 + number2; ;
            var actual = empwage.Addition(number2, number2);

            // Assert
            Assert.AreEqual(expected,actual);

        }
    }
}
