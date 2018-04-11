using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GoogleProject.Common
{
    [Binding]
    public sealed class Hooks
    {   
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
