using System;
using TechTalk.SpecFlow;

namespace SpecflowTipsAndTricks.StepDefinitions
{
    [Binding]
    public class AdminLoginSteps
    {
        private readonly AdminLoginDetails _adminLoginDetails;

        public AdminLoginSteps(AdminLoginDetails adminLoginDetails)
        {
            _adminLoginDetails = adminLoginDetails;
        }

        [Given(@"I have logged in as administrator '(.*)'")]
        public void GivenIHaveLoggedInAsAdministrator(string p0)
        {
            _adminLoginDetails.UserName = p0;
        }
        
        [When(@"I navigate to the user profile page")]
        public void WhenINavigateToTheUserProfilePage()
        {
            // insert steps
        }
    }
}
