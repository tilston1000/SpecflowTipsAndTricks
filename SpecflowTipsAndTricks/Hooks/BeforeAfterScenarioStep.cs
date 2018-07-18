using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowTipsAndTricks.Hooks
{
    [Binding]
    public sealed class BeforeAfterScenarioStep
    {
        [BeforeStep]
        public void BeforeStep()
        {

        }

        [AfterStep]
        public void AfterStep()
        {

        }
    }
}
