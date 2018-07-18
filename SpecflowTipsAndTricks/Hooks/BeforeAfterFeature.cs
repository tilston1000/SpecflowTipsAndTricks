using TechTalk.SpecFlow;

namespace SpecflowTipsAndTricks.Hooks
{
    [Binding]
    public sealed class BeforeAfterFeature
    {
        [BeforeFeature]
        public static void BeforeFeature()
        {

        }

        [AfterFeature]
        public static void AfterFeature()
        {
            var t = FeatureContext.Current.FeatureInfo.Title;
        }
    }
}
