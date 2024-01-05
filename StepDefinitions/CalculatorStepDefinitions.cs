using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowAssignment_1.StepDefinitions
{
    [Binding]
    
    public class CalculatorSteps
    {
        private Calculator calculator = new Calculator(); // Assume you have a Calculator class

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calculator.EnterNumber(number);
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            calculator.Multiply();
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            calculator.Subtract();
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            calculator.Divide();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, calculator.GetResult());
        }
    }

}
