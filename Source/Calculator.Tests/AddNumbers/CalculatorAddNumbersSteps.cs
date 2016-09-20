using NUnit.Framework;

using TechTalk.SpecFlow;

namespace SpecFlow.Exploration.Tests.AddNumbers
{
    [Binding]
    public class CalculatorAddNumbersSteps
    {
        private Calculator _calculator;

        [Given(@"I have a Calculator")]
        public void GivenIHaveACalculator()
        {
            _calculator = new Calculator();
        }

        [When(@"I add (.*) to (.*)")]
        public void WhenIAddTo(int first, int second)
        {
            _calculator.Add(first, second);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.That(_calculator.Result, Is.EqualTo(result));
        }
    }
}
