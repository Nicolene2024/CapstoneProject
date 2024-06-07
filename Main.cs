using OpenQA.Selenium.DevTools.V123.IndexedDB;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SikuliSharp;
using WindowsInput.Native;
using WindowsInput;
using AventStack.ExtentReports.Model;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;

namespace Capstone_Project
{
    public class Main
    {
        ISikuliSession session;
        IWebDriver driver;
        VirtualKeyCode key;
        static ExtentReports reports;


        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            session = Sikuli.CreateSession();
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            reports = new ExtentReports();
            var htmlReporter = new ExtentSparkReporter("C:\\Training\\CapstoneProject\\Report\\CapstoneProjectSpark.html");
            reports.AttachReporter(htmlReporter);
        }

        [Test]
        public void OpenHomeWeb()
        {
            ExtentTest test = reports.CreateTest("TEST CASE: Open Web Home");
            try
            {
                WebHome.OpenWebHome(driver);
                test.Pass("OPEN WEB HOME: TEST CASE PASSED");
            }
            catch (Exception ex)
            {
                test.Fail(ex.Message);
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void Login()
        {
            ExtentTest test = reports.CreateTest("TEST CASE: Login");
            try
            {
                WebHome.OpenWebHome(driver);
                test.Pass("OPEN WEB HOME: TEST CASE 1 PASSED");
                WebLogin.Login(driver);
                test.Pass("LOGIN: TEST CASE 2 PASSED");
            }
            catch (Exception ex)
            {
                test.Fail(ex.Message);
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void SelectCategory()
        {
            ExtentTest test = reports.CreateTest("TEST CASE: Select Category");
            try
            {
                WebHome.OpenWebHome(driver);
                test.Pass("OPEN WEB HOME: TEST CASE 1 PASSED");
                WebLogin.Login(driver);
                test.Pass("LOGIN: TEST CASE 2 PASSED");
                WebJewelry.SelectCategoryJewelry(driver);
                test.Pass("SELECT CATEGORY JEWELRY: TEST CASE 3 PASSED");
                WebJewelry.ChangeDisplayView(driver);
                test.Pass("CHANGE DISPLAY VIEW: TEST CASE 4 PASSED");
            }
            catch (Exception ex)
            {
                test.Fail(ex.Message);
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void AddProduct()
        {
            ExtentTest test = reports.CreateTest("TEST CASE: Add Product");
            try
            {
                WebHome.OpenWebHome(driver);
                test.Pass("OPEN WEB HOME: TEST CASE 1 PASSED");
                WebLogin.Login(driver);
                test.Pass("LOGIN: TEST CASE 2 PASSED");
                WebJewelry.SelectCategoryJewelry(driver);
                test.Pass("SELECT CATEGORY JEWELRY: TEST CASE 3 PASSED");
                WebJewelry.ChangeDisplayView(driver);
                test.Pass("CHANGE DISPLAY VIEW: TEST CASE 4 PASSED");
                WebJewelry.CreateYourOwnJewelry(driver, session, key);
                test.Pass("CREATE YOUR OWN JEWELRY: TEST CASE 5 PASSED");
            }
            catch (Exception ex)
            {
                test.Fail(ex.Message);
                Assert.Fail(ex.Message);
            }
        } 

        [Test]
        public void Checkout()
        {
            ExtentTest test = reports.CreateTest("TEST CASE: Checkout");
            try
            {
                WebHome.OpenWebHome(driver);
                test.Pass("OPEN WEB HOME: TEST CASE 1 PASSED");
                WebLogin.Login(driver);
                test.Pass("LOGIN: TEST CASE 2 PASSED");
                WebJewelry.SelectCategoryJewelry(driver);
                test.Pass("SELECT CATEGORY JEWELRY: TEST CASE 3 PASSED");
                WebJewelry.ChangeDisplayView(driver);
                test.Pass("CHANGE DISPLAY VIEW: TEST CASE 4 PASSED");
                WebJewelry.CreateYourOwnJewelry(driver, session, key);
                test.Pass("CREATE YOUR OWN JEWELRY: TEST CASE 5 PASSED");
                WebCart.AddtoCart(driver, session, key);
                test.Pass("ADD TO CART: TEST CASE 6 PASSED");
            }
            catch (Exception ex)
            {
                test.Fail(ex.Message);
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void ReturnToHomeWeb()
        {
            ExtentTest test = reports.CreateTest("TEST CASE: Return To Home Web");
            try
            {
                WebHome.OpenWebHome(driver);
                test.Pass("OPEN WEB HOME: TEST CASE 1 PASSED");
                WebLogin.Login(driver);
                test.Pass("LOGIN: TEST CASE 2 PASSED");
                WebJewelry.SelectCategoryJewelry(driver);
                test.Pass("SELECT CATEGORY JEWELRY: TEST CASE 3 PASSED");
                WebJewelry.ChangeDisplayView(driver);
                test.Pass("CHANGE DISPLAY VIEW: TEST CASE 4 PASSED");
                WebJewelry.CreateYourOwnJewelry(driver, session, key);
                test.Pass("CREATE YOUR OWN JEWELRY: TEST CASE 5 PASSED");
                WebCart.AddtoCart(driver, session, key);
                test.Pass("ADD TO CART: TEST CASE 6 PASSED");
                WebCart.LogOut(driver);
                test.Pass("LOGOUT: TEST CASE 7 PASSED");
            }
            catch (Exception ex)
            {
                test.Fail(ex.Message);
                Assert.Fail(ex.Message);
            }
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Dispose();
            reports.Flush();
            reports = null;
        }
    }
}
    

        
        
            


    

    



    

        
        
            
        
        

            
           