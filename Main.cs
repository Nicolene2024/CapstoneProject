using OpenQA.Selenium.DevTools.V123.IndexedDB;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SikuliSharp;
using WindowsInput.Native;
using WindowsInput;

namespace Capstone_Project
{
    public class Main
    {
        ISikuliSession session;
        IWebDriver driver;
        VirtualKeyCode key;


        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            session = Sikuli.CreateSession();
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void OpenHomeWeb()
        {
            WebHome.OpenWebHome(driver);
        }

        [Test]
        public void Login()
        {
            WebHome.OpenWebHome(driver);
            WebLogin.Login(driver);
        }

        [Test]
        public void SelectCategory()
        {
            WebHome.OpenWebHome(driver);
            WebLogin.Login(driver);
            WebJewelry.SelectCategoryJewelry(driver);
            WebJewelry.ChangeDisplayView(driver);
        }

        [Test]
        public void AddProduct()
        {
            WebHome.OpenWebHome(driver);
            WebLogin.Login(driver);
            WebJewelry.SelectCategoryJewelry(driver);
            WebJewelry.ChangeDisplayView(driver);
            WebJewelry.CreateYourOwnJewelry(driver, session, key);            
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

        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Dispose();
        }
    }
}

        
        
            


    

    



    

        
        
            
        
        

            
           