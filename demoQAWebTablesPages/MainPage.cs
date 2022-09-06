using demoQATestsDotNet.core;
using demoQATestsDotNet.settings;
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
        public MainPage()
        {
            driver.Navigate().GoToUrl(TestDataDemoQA.URL);
            PageFactory.InitElements(driver, this);
        }

        public MainPage goToElements()
        {
            return this;
        }

    }
}
