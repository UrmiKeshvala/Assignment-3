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
            public void Div_Input6and2_Returns3()
            {
                //Arrange
                double number1 = 6;
                double number2 = 2;
                double expectedResult = number1 / number1;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
           
            [Test]
            public void Div_Input20point0and2point0_Returns10point0()
            {
                //Arrange
                double number1 = 20.0;
                double number2 = 2.0;
                double expectedResult = number1 / number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }

            [Test]
            public void Div_Input6and1_Returns6()
            {
                //Arrange
                double number1 = -6;
                double number2 = -1;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Div_Input16and2_Returns8()
            {
                //Arrange
                double number1 = 16;
                double number2 = 8;
                double expectedResult = number1 = number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }

        }
    }
}
