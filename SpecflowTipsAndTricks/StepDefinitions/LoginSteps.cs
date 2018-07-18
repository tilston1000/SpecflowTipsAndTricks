using System;
using TechTalk.SpecFlow;

namespace SpecflowTipsAndTricks.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I have entered a username of '(.*)'")]
        public void GivenIHaveEnteredAUsernameOf(string p0)
        {
           // Test Steps here
        }
        
        [Given(@"a password of '(.*)'")]
        public void GivenAPasswordOf(string p0)
        {
            // Test Steps here
        }

        [Given(@"A")]
        public void GivenA()
        {
            // Test Steps here
        }

        [Given(@"X")]
        public void GivenX()
        {
            // Test Steps here
        }

        [When(@"I choose login")]
        public void WhenIChooseLogin()
        {
            // Test Steps here
        }

        [When(@"I don't choose remember me")]
        public void WhenIDonTChooseRememberMe()
        {
            // Test Steps here
        }

        [When(@"B")]
        public void WhenB()
        {
            // Test Steps here
        }

        [When(@"Y")]
        public void WhenY()
        {
            // Test Steps here
        }

        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            // Test Steps here
        }

        [Then(@"taken to the home screen")]
        public void ThenTakenToTheHomeScreen()
        {
            // Test Steps here
        }

        [Then(@"my username should not be remembered")]
        public void ThenMyUsernameShouldNotBeRemembered()
        {
            // Test Steps here
        }

        [Then(@"C")]
        public void ThenC()
        {
            // Test Steps here
        }

        [Then(@"Z")]
        public void ThenZ()
        {
            // Test Steps here
        }
    }
}
