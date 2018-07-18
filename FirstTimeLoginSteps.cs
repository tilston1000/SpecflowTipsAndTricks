using System;
using TechTalk.SpecFlow;

namespace SpecflowTipsAndTricks
{
    [Binding]
    public class FirstTimeLoginSteps
    {
        //[Given(@"I have successfully logged in as '(.*)'")]
        //public void GivenIHaveSuccessfullyLoggedInAs(string p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        [Given(@"this is the first time I have logged in")]
        public void GivenThisIsTheFirstTimeIHaveLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the initial screen is shown")]
        public void WhenTheInitialScreenIsShown()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the tutorial video is available to watch")]
        public void ThenTheTutorialVideoIsAvailableToWatch()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
