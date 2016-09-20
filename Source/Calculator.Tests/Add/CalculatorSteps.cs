using TechTalk.SpecFlow;

namespace SpecFlow.Exploration.Tests.Add
{
    [Binding]
    public class CalculatorSteps
    {
        private int _result;
        private readonly Calculator _calculator = new Calculator();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            _calculator.FirstNumber = number;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _result = _calculator.Add();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int number)
        {
            _calculator.SecondNumber = number;
        }
    }
}
