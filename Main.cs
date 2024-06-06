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
        ExtentReports reports;


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
            WebHome.OpenWebHome(driver);
            WebHome.TC_1_Home(driver, reports);
        }

        [Test]
        public void Login()
        {
            WebHome.OpenWebHome(driver);
            WebLogin.Login(driver);
            WebLogin.TC_2_Login(driver, reports);
        }

        [Test]
        public void SelectCategory()
        {
            WebHome.OpenWebHome(driver);
            WebLogin.Login(driver);
            WebJewelry.SelectCategoryJewelry(driver);
            WebJewelry.ChangeDisplayView(driver);
            WebJewelry.TC_3_SelectCategoryJewelry(driver, reports, session, key);
            WebJewelry.TC_4_ChangeDisplayView(driver, reports, session, key);
        }

        [Test]
        public void AddProduct()
        {
            WebHome.OpenWebHome(driver);
            WebLogin.Login(driver);
            WebJewelry.SelectCategoryJewelry(driver);
            WebJewelry.ChangeDisplayView(driver);
            WebJewelry.CreateYourOwnJewelry(driver, session, key);
            WebJewelry.TC_5_CreateYourOwnJewelry(driver, reports, session, key);
        }

        [Test]
        public void Checkout()
        {
            WebHome.OpenWebHome(driver);
            WebLogin.Login(driver);
            WebJewelry.SelectCategoryJewelry(driver);
            WebJewelry.ChangeDisplayView(driver);
            WebJewelry.CreateYourOwnJewelry(driver, session, key);
            WebCart.AddtoCart(driver, session, key);
            WebCart.TC_6_AddtoCart(driver, reports, session, key);
        }

        [Test]
        public void ReturnToHomeWeb()
        {
            WebHome.OpenWebHome(driver);
            WebLogin.Login(driver);
            WebJewelry.SelectCategoryJewelry(driver);
            WebJewelry.ChangeDisplayView(driver);
            WebJewelry.CreateYourOwnJewelry(driver, session, key);
            WebCart.AddtoCart(driver, session, key);
            WebCart.LogOut(driver);
            WebCart.TC_7_LogOut(driver, reports, session, key);

        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Dispose();
        }
    }
}

        
        
            


    

    



    

        
        
            
        
        

            
           