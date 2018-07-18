using System;
using TechTalk.SpecFlow;

namespace SpecflowTipsAndTricks.StepDefinitions
{
    [Binding]
    public class StandardConversionsSteps
    {
        [Given(@"I have entered (.*)")]
        public void GivenIHaveEntered(decimal p0)
        {
            // test code
        }
        
        [When(@"I choose the (.*) option")]
        public void WhenIChooseTheSaveOption(ActionOptions option)
        {
            // test code
        }

        [Then(@"the results should be (.*)")]
        public void ThenTheResultsShouldBe(Guid guid)
        {
            // test code
        }
    }
}
