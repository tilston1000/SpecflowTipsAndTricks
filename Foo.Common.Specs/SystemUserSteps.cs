using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Foo.Common.Specs
{
    [Binding]
    public class SystemUserSteps
    {
        [Given(@"The user '(.*)' exists in the system")]
        public void GivenTheUserExistsInTheSystem(string p0)
        {
            // test code
        }

    }
}
