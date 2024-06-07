using AventStack.ExtentReports.Model;
using AventStack.ExtentReports;
using OpenQA.Selenium;
using SikuliSharp;
using WindowsInput;
using WindowsInput.Native;

namespace Capstone_Project
{
    internal class WebCart
    {
        private VirtualKeyCode key;
        private object reports;

        public static void AddtoCart(IWebDriver driver, ISikuliSession session, WindowsInput.Native.VirtualKeyCode key)
        {
            //Click on the  Shopping Cart Link in the page header
            //Shopping cart page is displayed
            driver.FindElement(By.XPath("//*[@id=\"topcartlink\"]/a/span[1]")).Click();

            //Click on the Country dropdown 
            string path7 = @"C:\Training\CapstoneProject\Images\Country.png";
            IPattern pattern7 = Patterns.FromFile(path7);
            session.Click(pattern7);

            //Select American Samoa as the downdrop option
            string path8 = @"C:\Training\CapstoneProject\Images\American_Samoa.png";
            IPattern pattern8 = Patterns.FromFile(path8);
            session.Click(pattern8);

            //Insert 96799 into the Zipcode source field
            string path9 = @"C:\Training\CapstoneProject\Images\Zip_Postal_Code.png";
            IPattern pattern9 = Patterns.FromFile(path9);
            session.Click(pattern9);
            Thread.Sleep(500);
            session.Type("96799");

            //Select the Agree to TC & C checkbox
            string path10 = @"C:\Training\CapstoneProject\Images\TC_&_C_Checkbox.png";
            IPattern pattern10 = Patterns.FromFile(path10);
            session.Click(pattern10);

            //Click on the Checkout button
            string path11 = @"C:\Training\CapstoneProject\Images\Checkout_Button.png";
            IPattern pattern11 = Patterns.FromFile(path11);
            session.Click(pattern11);

            //Checkout Page is displayed
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div/div/div[1]/h1")).Click();

            //Verify that the page header is Checkout
            //Page header is displayed as Checkout
            String PageHeader = "Checkout";
            Assert.That(PageHeader.Contains("Checkout"));
        }
        public static void LogOut(IWebDriver driver)
        {
            //Click on the Demo Work Shop Logo - Home page is displayed
            //Select on the Logout link in the page header - Home page with login option is displayed
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[1]/a/img")).Click();
            Thread.Sleep(1500);
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a")).Click();
        }
    }
}



     
      

