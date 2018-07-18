using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowTipsAndTricks.StepDefinitions
{
    [Binding]
    public class AddUsersSecondOptionSteps
    {
        [Given(@"I have input these users")]
        public void GivenIHaveInputTheseUsers(IEnumerable<dynamic> users)
        {
            dynamic first = users.First();

            var fn = first.FirstName;
            var ln = first.LastName;
        }
        
        [When(@"I choose to add")]
        public void WhenIChooseToAdd()
        {
            // Test code
        }
        
        [Then(@"the users will be added")]
        public void ThenTheUsersWillBeAdded()
        {
            // Test code
        }
    }
}
