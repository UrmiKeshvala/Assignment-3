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


        [Test]
        public void Sub_Input5and2_Returns3()
        {
            //Arrange
            double number1 = 5;
            double number2 = 2;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetSubtraction();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void Sub_Input6point6and2point0_Returns3point0()
        {
            //Arrange
            double number1 = 6.6;
            double number2 = 2.0;
            double expectedResult = number1 = number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetSubtraction();
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
            Calc testCalc = new Calc(number1, number1);
            //Act 
            double actualResult = testCalc.GetSubtraction();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void Sub_Input8and2_Returns6()
        {
            //Arrange
            double number1 = 8;
            double number2 = 2;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
