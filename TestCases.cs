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
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }

               [Test]
                public void Sub_Input5and2_Returns3()
                {
                    //Arrange
                    double number1 = 5;
                    double number2 = 2;
                    double expectedResult = number1 - number2;
                    Calc testCalc = new Calc(number1, number2);
                    //Act 
                    double actualResult = testCalc.GetSubtraction();
                    //Assert 
                    Assert.AreEqual(expectedResult, actualResult);
                }



                [Test]
                public void Mul_Input5and2_Returns10()
                {
                    //Arrange
                    double number1 = 5;
                    double number2 = 2;
                    double expectedResult = number1 * number2;
                    Calc testCalc = new Calc(number1, number2);
                    //Act 
                    double actualResult = testCalc.GetMultiplication();
                    //Assert 
                    Assert.AreEqual(expectedResult, actualResult);
                }
                [Test]
                public void Div_Input6and2_Returns3()
                {
                    //Arrange
                    double number1 = 6;
                    double number2 = 2;
                    double expectedResult = number1 / number2;
                    Calc testCalc = new Calc(number1, number2);
                    //Act 
                    double actualResult = testCalc.GetDivision();
                    //Assert 
                    Assert.AreEqual(expectedResult, actualResult);
                }
                [Test]
                public void Add_Input3point3and5point5_Returns8point8()
                {
                    //Arrange
                    double number1 = 3.3;
                    double number2 = 5.5;
                    double expectedResult = number1 + number2;
                    Calc testCalc = new Calc(number1, number2);
                    //Act 
                    double actualResult = testCalc.GetAddition();
                    //Assert 
                    Assert.AreEqual(expectedResult, actualResult);
                }
                [Test]
                public void Sub_Input6point6and2point0_Returns3point0()
                {
                    //Arrange
                    double number1 = 6.6;
                    double number2 = 2.0;
                    double expectedResult = number1 - number2;
                    Calc testCalc = new Calc(number1, number2);
                    //Act 
                    double actualResult = testCalc.GetSubtraction();
                    //Assert 
                    Assert.AreEqual(expectedResult, actualResult);
                }
                [Test]
                public void Mul_Input5point2and2point0_Returns10point4()
                {
                    //Arrange
                    double number1 = 5.2;
                    double number2 = 2.0;
                    double expectedResult = number1 * number2;
                    Calc testCalc = new Calc(number1, number2);
                    //Act 
                    double actualResult = testCalc.GetMultiplication();
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
                    double actualResult = testCalc.GetDivision();
                    //Assert 
                    Assert.AreEqual(expectedResult, actualResult);
                }
                [Test]
                public void Add_InputMinus3andMinus5_Returns8()
                {
                    //Arrange
                    double number1 = -3;
                    double number2 = -5;
                    double expectedResult = number1 + number2;
                    Calc testCalc = new Calc(number1, number2);
                    //Act 
                    double actualResult = testCalc.GetAddition();
                    //Assert 
                    Assert.AreEqual(expectedResult, actualResult);
                }
                [Test]
                public void Sub_Input5and3_Returns2()
                {
                    //Arrange
                    double number1 = -5;
                    double number2 = -3;
                    double expectedResult = number1 - number2;
                    Calc testCalc = new Calc(number1, number2);
                    //Act 
                    double actualResult = testCalc.GetSubtraction();
                    //Assert 
                    Assert.AreEqual(expectedResult, actualResult);
                }
                [Test]
                public void Mul_Input5and1_Returns5()
                {
                    //Arrange
                    double number1 = -5;
                    double number2 = -2;
                    double expectedResult = number1 * number2;
                    Calc testCalc = new Calc(number1, number2);
                    //Act 
                    double actualResult = testCalc.GetMultiplication();
                    //Assert 
                    Assert.AreEqual(expectedResult, actualResult);
                }
                [Test]
                public void Div_Input6and1_Returns6()
                {
                    //Arrange
                    double number1 = -6;
                    double number2 = -1;
                    double expectedResult = number1 / number2;
                    Calc testCalc = new Calc(number1, number2);
                    //Act 
                    double actualResult = testCalc.GetDivision();
                    //Assert 
                    Assert.AreEqual(expectedResult, actualResult);
                }

            }
        }
}








