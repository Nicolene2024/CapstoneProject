using OpenQA.Selenium;
using SikuliSharp;
using WindowsInput;
using WindowsInput.Native;

namespace Capstone_Project
{
    internal class WebCart
    {
        public static void AddtoCart(IWebDriver driver, ISikuliSession session, WindowsInput.Native.VirtualKeyCode key) 
        {
            //Click on the  Shopping Cart Link in the page header
            //Shopping cart page is displayed
            driver.FindElement(By.XPath("//*[@id=\"topcartlink\"]/a/span[1]")).Click();  //*[@id=\"bar-notification\"]/p/a

            //Click on the Country dropdown 
            string path0 = @"C:\Users\NICOLEER\Documents\Capstone\Images\Select_Country.png"; 
            IPattern pattern0 = Patterns.FromFile(path0);
            session.Click(pattern0);

            //Select American Samoa as the downdrop option
            string path1 = @"C:\Users\NICOLEER\Documents\Capstone\Images\American_Samao.png";   
            IPattern pattern1 = Patterns.FromFile(path1);
            session.Click(pattern1);
            Thread.Sleep(500);
            InputSimulator sim = new InputSimulator();
            sim.Keyboard.KeyPress(key);

            //Insert 96799 into the Zipcode source field
            string path2 = @"C:\Users\NICOLEER\Documents\Capstone\Images\Zip_Postal_Code.png";
            IPattern pattern2 = Patterns.FromFile(path2);
            session.Click(pattern2);
            session.Type("96799");

            //Select the Agree to TC & C checkbox
            string path3 = @"C:\Users\NICOLEER\Documents\Capstone\Images\TC_&_C_Checkbox.png";   
            IPattern pattern3 = Patterns.FromFile(path3);
            session.Click(pattern3);

            //Click on the Checkout button
            string path4 = @"C:\Users\NICOLEER\Documents\Capstone\Images\Checkout_Button.png"; 
            IPattern pattern4 = Patterns.FromFile(path4);
            session.Click(pattern4);

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
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[1]/a/img")).Click();              
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a")).Click();  
        }

    }
}



     
      

