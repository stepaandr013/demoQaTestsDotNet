using demoQATestsDotNet.core;
using demoQATestsDotNet.settings;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoQATestsDotNet.demoQAWebTablesPages
{
    public class MainPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div/div[1]")]
        private IWebElement elementButton;

        public MainPage()
        {
            driver.Navigate().GoToUrl(TestDataDemoQA.URL);
            PageFactory.InitElements(driver, this);
        }

        public ElementsPage goToElements()
        {
            elementButton.Click();
            return new ElementsPage();
        }

    }
}
