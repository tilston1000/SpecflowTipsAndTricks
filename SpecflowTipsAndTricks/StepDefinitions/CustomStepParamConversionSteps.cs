using System;
using TechTalk.SpecFlow;

namespace SpecflowTipsAndTricks.StepDefinitions
{
    [Binding]
    public class CustomStepParamConversionSteps
    {
        [Given(@"I last logged in (.* days ago)")]
        public void GivenILastLoggedInDaysAgo(DateTime lastLogin)
        {
            
        }
        
        [When(@"I try to log in")]
        public void WhenITryToLogIn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the new password wizard should start")]
        public void ThenTheNewPasswordWizardShouldStart()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
