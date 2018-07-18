using System;
using TechTalk.SpecFlow;

namespace SpecflowTipsAndTricks.StepDefinitions
{
    [Binding]
    public class NormalLoginSteps
    {
        [Given(@"I have signed in as '(.*)'")]
        [Given(@"I have successfully logged in as '(.*)'")]
        public void GivenIHaveSignedInAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"this is not the first time I have logged in")]
        public void GivenThisIsNotTheFirstTimeIHaveLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the tutorial video is hidden")]
        public void ThenTheTutorialVideoIsHidden()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
