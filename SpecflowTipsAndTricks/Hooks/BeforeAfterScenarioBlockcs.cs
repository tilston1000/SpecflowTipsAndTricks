using TechTalk.SpecFlow;

namespace SpecflowTipsAndTricks.Hooks
{
    [Binding]
    public sealed class BeforeAfterScenarioBlockcs
    {
        [BeforeScenarioBlock]
        public void BeforeScenarioBlock()
        {

        }

        [AfterScenarioBlock]
        public void AfterScenarioBlock()
        {
            var b = ScenarioContext.Current.CurrentScenarioBlock;
        }
    }
}
