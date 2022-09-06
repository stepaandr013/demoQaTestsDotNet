using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoQATestsDotNet.core
{
    abstract public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        protected void setUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            BasePage.setDriver(driver);
        }

        [TearDown]
        protected void tearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
