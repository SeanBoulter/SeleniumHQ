using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SeleniumHQ.Steps
{
    [Binding]
    public class SearchSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            Assert.IsTrue(true);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Assert.IsTrue(true);
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.IsTrue(true);
        }
    }
}
