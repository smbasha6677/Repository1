using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GoogleProject.Pages
{
    public class GoogleSearchPage
    {
        public IWebDriver driver;

        public IWebElement SearchTextBoxElement
        {
            get
            {
                return driver.FindElement(By.Id("lst-ib"));
            }
        }
       
        public IList<IWebElement> LinkElements
        {
            get
            {
                return driver.FindElements(By.CssSelector("div.rc > h3 > a"));
            }
        }

        public GoogleSearchPage(IWebDriver driver)
        {
            this.driver = driver;           
        }

        public void SearchText(string searchText)
        {
            SearchTextBoxElement.Clear();
            SearchTextBoxElement.SendKeys(searchText);
            SearchTextBoxElement.SendKeys(Keys.Enter);
        }
    }
}
