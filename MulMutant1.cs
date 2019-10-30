using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;


namespace TestCases
{
    public class TestCases
    {
        [TestFixture]
        class CalcTests
        {
           


            [Test]
            public void Mul_Input5and2_Returns10()
            {
                //Arrange
                double number1 = 5;
                double number2 = 2;
                double expectedResult = number1 - number1;
                Calc testCalc = new Calc(number1, number1);
                //Act 
                double actualResult = testCalc.GetMultiplication();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }

            [Test]
            public void Mul_Input5point2and2point0_Returns10point4()
            {
                //Arrange
                double number1 = 5.2;
                double number2 = 2.0;
                double expectedResult = number1 *= number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }

            [Test]
            public void Mul_Input5and1_Returns5()
            {
                //Arrange
                double number1 = -5;
                double number2 = -2;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetMultiplication();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Mul_Input1and2_Returns2()
            {
                //Arrange
                double number1 = 1;
                double number2 = 2;
                double expectedResult = number1 = number2;
                Calc testCalc = new Calc(number1, number1);
                //Act 
                double actualResult = testCalc.GetMultiplication();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }


        }
    }
}








