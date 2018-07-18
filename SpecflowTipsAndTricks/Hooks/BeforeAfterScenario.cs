using TechTalk.SpecFlow;

namespace SpecflowTipsAndTricks.Hooks
{
    [Binding]
    public sealed class BeforeAfterScenario
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            var t = ScenarioContext.Current.ScenarioInfo.Title;
        }

        [AfterScenario]
        public void AfterScenario()
        {

        }
    }
}
