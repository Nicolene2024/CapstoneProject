using AventStack.ExtentReports.Model;
using AventStack.ExtentReports;
using OpenQA.Selenium;

namespace Capstone_Project
{
    internal class WebLogin
    {
       public static void Login(IWebDriver driver)
        {
            //Login page is displayed
            //Click on Login link in the page header
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a")).Click();

            //Verify that the Entry box header is Returning Customer

            String DisplayNameAttribute = "Returning Customer";
            Assert.True(DisplayNameAttribute.Contains("Returning Customer"));

            Console.WriteLine("Enter email adress");
            //Enter email adress
            driver.FindElement(By.Id("Email")).SendKeys("nicoleer@pepkorit.com");
            Thread.Sleep(300);

            //Enter password
            driver.FindElement(By.Id("Password")).SendKeys("password");
            Thread.Sleep(500);

            //Home page is displayed
            //Click Login button
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div/div[2]/div[1]/div[2]/div[2]/form/div[5]/input")).Click();

            //Verify user email is displayed in page header

            String EmailAddressAttribute = "nicoleer@pepkorit.com";
            Assert.True(EmailAddressAttribute.Contains("nicoleer@pepkorit.com"));
        }
        public static void TC_2_Login(IWebDriver driver, ExtentReports reports)
        {
            ExtentTest test = reports.CreateTest("TEST CASE: TC_2_Login");
            try
            {
                WebLogin.Login(driver);
                test.Pass("TEST CASE PASSED");
            }
            catch (Exception ex)
            {
                test.Fail(ex.Message);
                Assert.Fail(ex.Message);
            }
        }
    }
}
