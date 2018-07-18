using TechTalk.SpecFlow;

namespace SpecflowTipsAndTricks
{
    [Binding]
    public sealed class BeforeAfterTestRun
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
                    // Test Steps here
        [BeforeTestRun]
        public static void BeforeScenario()
        {
            
        }

        [AfterTestRun]
        public static void AfterScenario()
        {
            
        }
    }
}
