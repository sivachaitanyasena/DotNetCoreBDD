using NetCoreAutomation.Hooks;
using NetCoreAutomation.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace NetCoreAutomation.StepDefinations
{
    [Binding]
    public class HomePageSteps
    {
        [Then(@"User should be redirected to Home Page")]
        public void ThenUserShouldBeRedirectedToHomePage()
        {
            try
            {
                HomePage homePage = new HomePage(CustomBaseClass.MyDriver);
                AssertClass.AssertElementIsPresent(homePage.linkHome);
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: could not verify Home: {0}", E.Message);
                DriverClass.CloseTest();
                throw;
            }
        }
        
        [Then(@"User should be able to see (.*)")]
        public void ThenUserShouldBeAbleToSee(string userFullName)
        {
            try
            {
                HomePage homePage = new HomePage(CustomBaseClass.MyDriver);
                AssertClass.ContainsText(homePage.textUserFullName,userFullName);
                DriverClass.CloseTest();
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Failed: could not verify username: {0}", E.Message);
                DriverClass.CloseTest();
                throw;
            }
        }
        
    }
}
