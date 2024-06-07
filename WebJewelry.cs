using OpenQA.Selenium;
using SikuliSharp;
using WindowsInput.Native;
using WindowsInput;
using OpenQA.Selenium.Support.UI;
using AventStack.ExtentReports.Gherkin.Model;
using System.Reactive.Joins;
using AventStack.ExtentReports.Model;
using AventStack.ExtentReports;


namespace Capstone_Project
{
    internal class WebJewelry
    {
        public static void SelectCategoryJewelry(IWebDriver driver)
        {
            //Select the Jewelry option under the Categories section
            //Jewelry downloads page is displayed
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div[1]/div[1]/div[2]/ul/li[6]/a")).Click();

            //Verify that the url contains Jewelry
            List<string> urlList = new List<string>();
            urlList.Add("https://demowebshop.tricentis.com/jewelry");
            bool isContains = urlList.Any(x => x.Contains("Jewelry"));
        }

        public static void ChangeDisplayView(IWebDriver driver)
        {
            //Select the Jewelry option under the Categories section
            //Jewelry downloads page is displayed
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div[1]/div[1]/div[2]/ul/li[6]/a")).Click();

            //Verify that the url contains Jewelry
            List<string> urlList = new List<string>();
            urlList.Add("https://demowebshop.tricentis.com/jewelry");
            bool isContains = urlList.Any(x => x.Contains("Jewelry"));

            //Select the List option under the View as dropdown
            //Products will be displayed underneath each other
            driver.FindElement(By.XPath("//*[@id=\"products-viewmode\"]")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[@id=\"products-viewmode\"]/option[2]")).Click();

            //Select the List option under the View as dropdown
            driver.FindElement(By.XPath("//*[@id=\"products-viewmode\"]")).Click();
            Thread.Sleep(500);

            //Products will be displayed underneath each other
            driver.FindElement(By.XPath("//*[@id=\"products-viewmode\"]/option[2]")).Click();
        }
        public static void CreateYourOwnJewelry(IWebDriver driver, ISikuliSession session, WindowsInput.Native.VirtualKeyCode Key)
        {
            // Click on the product Labled Create Your Own Jewelry image
            //Add product to the cart

            string path0 = @"C:\Training\CapstoneProject\Images\Create_Your_Own_Jewelry.png";
            IPattern pattern0 = Patterns.FromFile(path0);
            session.Click(pattern0);

            //Select the Gold (1mm) option from the Material dropdown
            //Material
            string path1 = @"C:\Training\CapstoneProject\Images\Material.png";
            IPattern pattern1 = Patterns.FromFile(path1);
            session.Click(pattern1);

            //Gold (1mm)
            string path2 = @"C:\Training\CapstoneProject\Images\Gold_(1mm).png";
            IPattern pattern2 = Patterns.FromFile(path2);
            session.Click(pattern2);

            Thread.Sleep(500);
            InputSimulator sim = new InputSimulator();
            sim.Keyboard.KeyPress(Key);

            //Enter 30 into the Length in cm source field 
            string path3 = @"C:\Training\CapstoneProject\Images\Length_30cm.png";
            IPattern pattern3 = Patterns.FromFile(path3);
            session.Click(pattern3);
            session.Type("30");
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);

            //Select the Heart radio button option under Pendant
            string path4 = @"C:\Training\CapstoneProject\Images\Heart.png";
            IPattern pattern4 = Patterns.FromFile(path4);
            session.Click(pattern4);

            //Increase Quantity to 2 
            string path5 = @"C:\Training\CapstoneProject\Images\Quantity_2.png";
            IPattern pattern5 = Patterns.FromFile(path5);
            session.Click(pattern5);
            sim.Keyboard.KeyPress(VirtualKeyCode.BACK);
            session.Type("2");

            //Click on the Add to cart button
            string path6 = @"C:\Training\CapstoneProject\Images\Add_to_cart.png";
            IPattern pattern6 = Patterns.FromFile(path6);
            session.Click(pattern6);
        }

    }

}

