using System;
using TechTalk.SpecFlow;

namespace SpecflowTipsAndTricks.StepDefinitions
{
    [Binding]
    public class CalculatorAdditionSteps : Steps
    {
        [Given(@"I have cleared any previous result")]
        public void GivenIHaveClearedAnyPreviousResult()
        {
            // test code
        }
        
        [Given(@"I have cleared any previous results")]
        public void GivenIHaveClearedAnyPreviousResults()
        {
            // test code
        }

        [When(@"I enter (.*) into the calculator")]
        public void WhenIEnterIntoTheCalculator(int p0)
        {
            // test code
        }

        [When(@"I choose addition")]
        public void WhenIChooseAddition()
        {
            // test code
        }

        [When(@"I add (.*) and (.*) together")]
        public void WhenIAddAndTogether(int p0, int p1)
        {
            When(string.Format("I enter {0} into the calculator", p0));
            When("I choose addition");
            When(string.Format("I enter {0} into the calculator", p1));
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            // test code
        }
    }
}
