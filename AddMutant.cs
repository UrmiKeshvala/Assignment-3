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
            public void Add_Input3and5_Returns8()
            {
                //Arrange
                double number1 = 3;
                double number2 = 5;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Add_Input3point3and5point5_Returns8point8()
            {
                //Arrange
                double number1 = 3.3;
                double number2 = 5.5;
                double expectedResult = number1 += number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }

            [Test]
            public void Add_InputMinus3andMinus5_Returns8()
            {
                //Arrange
                double number1 = -3;
                double number2 = -5;
                double expectedResult = number1 = number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Add_Input1and5_Returns6()
            {
                //Arrange
                double number1 = 3;
                double number2 = 5;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetSubtraction();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
        }
    }
}

    