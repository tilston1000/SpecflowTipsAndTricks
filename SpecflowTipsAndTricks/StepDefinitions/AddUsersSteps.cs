using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowTipsAndTricks.StepDefinitions
{
    [Binding]
    public class AddUsersSteps
    {
        [Given(@"I have input the following users")]
        public void GivenIHaveInputTheFollowingUsers(IEnumerable<NewUser> users)
        {
            // test code
        }
        
        [When(@"I choose add")]
        public void WhenIChooseAdd()
        {
            // Test code
        }

        [Then(@"the users should be added")]
        public void ThenTheUsersShouldBeAdded()
        {
            // Test code
        }
    }
}
