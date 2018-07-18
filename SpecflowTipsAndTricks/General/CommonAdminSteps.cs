using TechTalk.SpecFlow;

namespace SpecflowTipsAndTricks
{
    [Binding]
    public class CommonAdminLoginSteps
    {
        private readonly AdminLoginDetails _adminLoginDetails;

        public CommonAdminLoginSteps(AdminLoginDetails adminLoginDetails)
        {
            _adminLoginDetails = adminLoginDetails;
        }

        [Then(@"the correct username should be shown")]
        public void ThenTheCorrectUsernameShouldBeShown()
        {
            string un = _adminLoginDetails.UserName;
        }
    }
}
