
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
    }
}
    
