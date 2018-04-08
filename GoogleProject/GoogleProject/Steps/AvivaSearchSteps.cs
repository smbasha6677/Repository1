using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoogleProject.Common;
using GoogleProject.Pages;
using NUnit;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace GoogleProject.Steps
{
    [Binding]
    public class AvivaSearchSteps
    {
        public GoogleSearchPage googleSearchPage = new GoogleSearchPage(Hooks.driver);

        public IWebElement linkTextElement;

        [Given(@"I am on Google home page")]
        public void GivenINavigateToGoogleSearchPage()
        {
            Hooks.driver.Navigate().GoToUrl("http://google.co.uk");
        }

        [When(@"I search for text (.*)")]
        public void WhenIInititateSearch(string searchText)
        {
            googleSearchPage.SearchText(searchText);
        }

        [When(@"I see the (.*)th link")]
        public void WhenISeeTheThLink(int linkElement)
        {
            if (googleSearchPage.LinkElements.Count >= linkElement)
            {
                linkTextElement = googleSearchPage.LinkElements[linkElement - 1];   
            }            
        }

        [Then(@"I should see the (.*) text")]
        public void ThenIShouldSeeTheAvivaLink(string compareText)
        {
            Assert.IsTrue(linkTextElement.Text.Contains(compareText));
        }

        [Then(@"I should not see the (.*) text")]
        public void ThenIShouldNotSeeTheAvivaLink(string compareText)
        {
            Assert.IsFalse(linkTextElement.Text.Contains(compareText));
        }
    }
}
