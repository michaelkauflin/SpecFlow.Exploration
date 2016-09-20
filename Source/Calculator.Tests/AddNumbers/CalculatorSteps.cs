using NUnit.Framework;

using TechTalk.SpecFlow;

namespace SpecFlow.Exploration.Tests.AddNumbers
{
    [Binding]
    public class CalculatorSteps
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
            Assert.That(result, Is.EqualTo(_calculator.Result));
        }

        [When(@"I subtract (.*) to (.*)")]
        public void WhenISubtractTo(int first, int second)
        {
            _calculator.Subtract(first, second);
        }
    }
}
