
using AventStack.ExtentReports.Model;
using AventStack.ExtentReports;
using OpenQA.Selenium;

namespace Capstone_Project
{
    internal class WebHome
    {
        public static void OpenWebHome(IWebDriver driver)
        {
            //Verify page title displays Demo Web Shop

            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com");
            String PageTitle = driver.Title;
            Assert.True(PageTitle.Contains("Demo Web Shop"));
        }
        public static void TC_1_Home(IWebDriver driver, ExtentReports reports)
        {
            ExtentTest test = reports.CreateTest("TEST CASE: TC_1_Home");
            try
            {
                WebHome.OpenWebHome(driver);
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
