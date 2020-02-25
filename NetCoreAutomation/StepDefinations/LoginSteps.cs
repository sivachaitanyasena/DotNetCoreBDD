using NetCoreAutomation.Hooks;
using NetCoreAutomation.PageObjects;
using NetCoreAutomation.TestData;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace NetCoreAutomation.StepDefinations
{
    [Binding]
    public class LoginExternalSiteSteps
    {
        [Given(@"User Navigates to application (.*) login page")]
        public void GivenUserNavigatesToApplicationLoginPage( String site)
        {
            try
            {
                DriverClass.StartTest(TestConfig.externalUrl);
                LoginPage loginPage = new LoginPage(CustomBaseClass.MyDriver);
                //Comment for Applications where default page is Login
                //loginPage.linkLogin.Click();
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: could not load the application : {0}", E.Message);
                DriverClass.CloseTest();
                throw;
            }
        }
        
        [When(@"User login using credentials (.*) and (.*)")]
        public void WhenUserLoginUsingCredentialsAnd(string username, string passwordType)
        {
            LoginPage loginPage = new LoginPage(CustomBaseClass.MyDriver);
            CustomBaseClass.EnterText(loginPage.textUsername, username);
            if (passwordType.Contains("validPassword"))
            {
                CustomBaseClass.EnterText(loginPage.textPassword, TestConfig.validPassword);
            }
            else
            {
                CustomBaseClass.EnterText(loginPage.textPassword, TestConfig.invalidPassword);
            }
            loginPage.buttonLogin.Click();            
        }
        
        [Then(@"User should be able to login succesfully (.*)")]
        public void ThenUserShouldBeAbleToLoginSuccesfully(String firstName)
        {
            try
            {
                CustomBaseClass.Thinktime(5);
                LoginPage loginPage = new LoginPage(CustomBaseClass.MyDriver);
                AssertClass.AssertElementIsPresent(CustomBaseClass.MyDriver.FindElement(By.XPath("//div[contains(text(),'"+ firstName + "')]")));


            }
            catch( Exception E)
            {
                Console.WriteLine("Test Failed: could not login to the application : {0}", E.Message);
                DriverClass.CloseTest();
                throw;
            }

        }
        
        [Then(@"Test completed Successfully")]
        public void ThenTestCompletedSuccessfully()
        {
            DriverClass.CloseTest();
        }

        [Then(@"Then User should get (.*) message")]
        public void ThenThenUserShouldGet( String errorMessage)
        {
            try
            {
                LoginPage loginPage = new LoginPage(CustomBaseClass.MyDriver);
                // AssertClass.ContainsText(loginPage.errorMessage, errorMessage);
                AssertClass.AssertElementIsPresent(loginPage.errorMessage);
                DriverClass.CloseTest();
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: could not verify error message: {0}", E.Message);
                DriverClass.CloseTest();
                throw;
            }
        }

        [When(@"User click on Logout link")]
        public void WhenUserClickOnLogoutLink()
        {
            LoginPage loginPage = new LoginPage(CustomBaseClass.MyDriver);
            loginPage.buttonLogout.Click();
        }

        [Then(@"User should be redirected to Login Page")]
        public void ThenUserShouldBeRedirectedToLoginPage()
        {
            try
            {
                LoginPage loginPage = new LoginPage(CustomBaseClass.MyDriver);
                AssertClass.AssertElementIsPresent(loginPage.buttonLogin);
                DriverClass.CloseTest();
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: could not logout : {0}", E.Message);
                DriverClass.CloseTest();
                throw;
            }
        }

        [Then(@"User should be able to validate forgot password link")]
        public void ThenUserShouldBeAbleToValidateForgotPasswordLink()
        {
            try
            {
                LoginPage loginPage = new LoginPage(CustomBaseClass.MyDriver);
                AssertClass.AssertElementIsPresent(loginPage.linkForgotPassword);
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: could not validate : {0}", E.Message);
                DriverClass.CloseTest();
                throw;
            }
        }



    }
}
