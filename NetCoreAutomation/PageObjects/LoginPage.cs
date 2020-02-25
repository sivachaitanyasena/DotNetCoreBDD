using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreAutomation.PageObjects
{
    public class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement linkLogin => driver.FindElement(By.XPath("//a[text()='Login']"));
        public IWebElement textUsername => driver.FindElement(By.XPath("(//input[@type='text'])[2]"));
        public  IWebElement textPassword => driver.FindElement(By.XPath("//input[@type='password']"));
        public IWebElement buttonLogin => driver.FindElement(By.XPath("(//span[text()='Login'])[2]"));
        public IWebElement linkForgotPassword => driver.FindElement(By.XPath("//span[text()='Forgot?']"));
        public IWebElement buttonLogout => driver.FindElement(By.XPath("//a[contains(text(),'Logout')]"));
        public IWebElement errorMessage => driver.FindElement(By.XPath("//span[contains(text(),'Your username or password is incorrect')]"));


    }
}
