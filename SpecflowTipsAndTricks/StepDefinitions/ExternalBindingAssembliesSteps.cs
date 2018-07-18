using System;
using TechTalk.SpecFlow;

namespace SpecflowTipsAndTricks.StepDefinitions
{
    [Binding]
    public class ExternalBindingAssembliesSteps
    {       
        [When(@"I submit a status update of ""(.*)""")]
        public void WhenISubmitAStatusUpdateOf(string p0)
        {
            // test code
        }

        [Then(@"the update should appear in my timeline")]
        public void ThenTheUpdateShouldAppearInMyTimeline()
        {
            // test code
        }
    }
}
