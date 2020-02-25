using NetCoreAutomation.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreAutomation.PageObjects
{
    public class HomePage
    {
        IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement linkHome => driver.FindElement(By.XPath("//a[@title='Home']"));
        public IWebElement textUserFullName => driver.FindElement(By.XPath("Testtt"));
    }
}
