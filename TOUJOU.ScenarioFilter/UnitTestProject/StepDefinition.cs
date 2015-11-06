using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace UnitTestProject
{
    [Binding]
    public sealed class StepDefinition
    {
        [Then("this( negative)? scenario should be inconclusive")]
        public void ThenThisNegativeScenarioShouldFail(string dummy)
        {
            Assert.Fail("This (negative) scenario should be inconclusive.");
        }

        [Then("this scenario should pass")]
        public void ThenThisScenarioShouldPass()
        {
            // noop
        }
    }
}
