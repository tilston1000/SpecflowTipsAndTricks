using System;
using TechTalk.SpecFlow;

namespace SpecflowTipsAndTricks.StepDefinitions
{
    [Binding]
    public class CustomerUpdatesSteps
    {
        [Given(@"I have changed a customer")]
        public void GivenIHaveChangedACustomer()
        {
            // test code
        }

        [When(@"I choose save")]
        [Scope(Tag = "cust")]
        public void WhenIChooseSave()
        {
            // test code
        }

        [Then(@"the updated customer should be saved")]
        public void ThenTheUpdatedCustomerShouldBeSaved()
        {
            // test code
        }
    }
}
