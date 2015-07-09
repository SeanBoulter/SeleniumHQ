using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.PhantomJS;
using TechTalk.SpecFlow;

namespace SeleniumHQ.Steps
{
    [Binding]
    public class SearchSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            var driver = new PhantomJSDriver{Url = @"http://www.google.com"};
            driver.Navigate();
            var searchBox = driver.FindElement(By.Name("q"));           
            Assert.IsTrue(searchBox.Displayed);
            searchBox.SendKeys("Hello World");
            driver.Dispose();
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
