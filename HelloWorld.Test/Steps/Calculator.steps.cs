using HelloWorld.Services;
using TechTalk.SpecFlow;
using Xunit;

namespace HelloWorld.Test.Steps
{
    [Binding]
    public sealed class Calculator
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext context;
        private readonly Services.Calculator calculator;

        public Calculator(ScenarioContext injectedContext, Services.Calculator injectedCalculator)
        {
            context = injectedContext;
            calculator = injectedCalculator;
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calculator.FirstNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            calculator.SecondNumber = number;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            calculator.Add();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.Equal(expectedResult, calculator.Total);
        }

    }
}

