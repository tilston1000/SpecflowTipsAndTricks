using System;
using TechTalk.SpecFlow;

namespace SpecflowTipsAndTricks.StepDefinitions
{
    [Binding]
    public class SomeOtherFeatureSteps
    {
        [Given(@"Alpha")]
        public void GivenAlpha()
        {
            // Test Steps here
        }
        
        [When(@"Beta")]
        public void WhenBeta()
        {
            // Test Steps here
        }

        [Then(@"Gamma")]
        public void ThenGamma()
        {
            // Test Steps here
        }
    }
}
