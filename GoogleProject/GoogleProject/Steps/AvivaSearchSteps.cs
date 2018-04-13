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
        public int noOfLinksCount;

        [Given(@"I am on Google home page")]
        public void GivenIAmOnGoogleHomePage()
        {
            Hooks.driver.Navigate().GoToUrl("http://google.co.uk");
        }

        [When(@"I search for text (.*)")]
        public void WhenISearchForTextAviva(string searchText)
        {
            googleSearchPage.SearchText(searchText);
        }

        [Then(@"I can see the search result page with the number of links")]
        public void ThenICanSeeTheSearchResultPageWithTheNumberOfLinks()
        {
            noOfLinksCount = googleSearchPage.LinkElements.Count;
            Console.WriteLine("no of links on google search result page:: " + noOfLinksCount);
        }

        [Then(@"I should print the (.*)th link text as (.*)")]
        public void ThenIShouldPrintTheThLinkTextAsAviva_HomeFacebook(int number, string compareText)
        {   
            if (googleSearchPage.LinkElements.Count >= number)
            {
                linkTextElement = googleSearchPage.LinkElements[number - 1];
                Console.WriteLine(number + "th. Element link text on google search result page is::: " + linkTextElement.Text);
                Assert.IsTrue(linkTextElement.Text.Contains(compareText));
            }
        }

        [Then(@"shoud not see (.*) text")]
        public void ThenShoudNotSeeAviva_HomeFacebookText(string compareText)
        {
            Assert.IsFalse(linkTextElement.Text.Contains(compareText));
        }

    }
}
